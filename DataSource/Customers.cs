using System.Xml.Linq;
using sc_linq.Models;

namespace sc_linq.DataSource;

public static class Customers
{
    public static List<Customer> CustomerList { get; } =
        (from e in XDocument.Parse(File.ReadAllText(Path.Combine("DataSource", "customers.xml"))).Root!.Elements("customer")
         select new Customer
         {
             CustomerID = (string)e.Element("id")!,
             CompanyName = (string)e.Element("name")!,
             Address = (string)e.Element("address")!,
             City = (string)e.Element("city")!,
             Region = (string)e.Element("region")!,
             PostalCode = (string)e.Element("postalcode")!,
             Country = (string)e.Element("country")!,
             Phone = (string)e.Element("phone")!,
             Orders = (
                from o in e.Elements("orders").Elements("order")
                select new Order
                {
                    OrderID = (int)o.Element("id")!,
                    OrderDate = (DateTime)o.Element("orderdate")!,
                    Total = (decimal)o.Element("total")!
                }).ToList()
         }).ToList();
}
