namespace sc_linq.ModelsSC;

public class OrdineEuro
{

    public OrdineEuro(decimal totaleEuro, DateTime? data)
    {
        this.TotaleEuro = totaleEuro;
        this.Data = data ?? DateTime.Now;
    }
    private decimal totaleEuro = 0;
    public decimal TotaleEuro
    {
        get { return totaleEuro; }
        // https://learn.microsoft.com/de-de/dotnet/api/system.midpointrounding?view=net-8.0
        set { this.totaleEuro = Math.Round(value, 2, MidpointRounding.AwayFromZero); }
    }
    private DateTime data = DateTime.Now;
    public DateTime Data
    {
        get { return data; }
        set { data = value; }
    }

    public override string ToString()
    {
        return $"{totaleEuro:F2} €";
    }

}