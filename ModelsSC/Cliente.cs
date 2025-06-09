using System.Data.Common;

namespace sc_linq.ModelsSC;

public class Cliente
{


    public Cliente()
    {

    }
    public Cliente(string id, string nome, string indirizzo, IEnumerable<OrdineEuro> ordini)
    {
        this.Id = id;
        this.Nome = nome;
        this.Indirizzo = indirizzo;
        this.Ordini = ordini;

    }
    public string Id { get; set; } = string.Empty;

    private string nome = string.Empty;
    public string Nome
    {
        get => nome;
        set => nome = value;
    }

    private string indirizzo = string.Empty;
    public string Indirizzo
    {
        get => indirizzo;
        set => indirizzo = value;
    }

    private IEnumerable<OrdineEuro> ordini = new List<OrdineEuro>();
    public IEnumerable<OrdineEuro> Ordini
    {
        get => ordini;
        set => ordini = value;
    }


    public override string ToString()
    {
        string clienteInfo = $"ID: {this.Id.PadRight(10)}  Nome: {this.Nome.PadRight(30)} Indirizzo: {this.Indirizzo.PadRight(30)}";

        string ordiniInfo = "";

        foreach (OrdineEuro ordine in this.Ordini)
        {
            ordiniInfo += "\n" + new string(' ', 8) + ordine.ToString();
        }

        return $"{clienteInfo} {(Ordini.Any() ? ordiniInfo : "\n   Nessun ordine")}";
    }
}