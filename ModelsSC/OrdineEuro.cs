namespace sc_linq.ModelsSC;

public class OrdineEuro
{

    public OrdineEuro()
    {

    }
    public OrdineEuro(decimal totaleEuro, DateTime? data)
    {
        this.TotaleEuro = totaleEuro;
        this.Data = data ?? DateTime.Now;
    }

    private decimal? totaleEuro = 0;
    public decimal? TotaleEuro
    {
        get => totaleEuro;
        // https://learn.microsoft.com/de-de/dotnet/api/system.midpointrounding?view=net-8.0
        set => totaleEuro = value.HasValue ? Math.Round(value.Value, 2, MidpointRounding.AwayFromZero) : null;
    }
    private DateTime data;
    public DateTime Data
    {
        get => data;
        set => data = value;
    }

    public override string ToString() => $"Data acquisto: {data.ToString("d").PadRight(15)}. Importo: {(totaleEuro.HasValue ? totaleEuro.Value.ToString("C2") : "N/D")}";

}