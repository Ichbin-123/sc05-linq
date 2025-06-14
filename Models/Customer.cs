namespace sc_linq.Models;

public class Customer
{
    public string CustomerID { get; set; } = string.Empty;
    public string CompanyName { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string Region { get; set; } = string.Empty;
    public string PostalCode { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public List<Order> Orders { get; set; } = new List<Order>();

    public override string ToString() =>
        $"{CustomerID} {CompanyName}\n{Address}\n{City}, {Region} {PostalCode} {Country}\n{Phone}";
}
