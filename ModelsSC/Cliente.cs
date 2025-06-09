using System.Data.Common;

namespace sc_linq.ModelsSC;

public class Cliente
{


    private string id = "Unknown";
    public string Id
    {
        get { return id; }

        set { this.id = value ?? "Unknown"; }
    }



}