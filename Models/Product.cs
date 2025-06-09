namespace sc_linq.Models;

public class Product
{
    public int ProductID { get; set; }
    public string ProductName { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public decimal UnitPrice { get; set; }
    public int UnitsInStock { get; set; }

    public override string ToString()
    {
        var id = ("ID=" + ProductID).PadRight(8); // 3 + 2 + 2
        var name = ("Name=" + ProductName).PadRight(39); // 5 + 32 + 2;
        var category = ("Cat=" + Category).PadRight(20); // 4 + 14 + 2;
        var stock = ("Stock=" + UnitsInStock).PadRight(11); // 6 + 3 + 2;
        var price = "Price=" + UnitPrice.ToString("c");

        return $"{id}{name}{category}{stock}{price}";
    }
}