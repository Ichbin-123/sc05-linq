// LINQ Language Integrated Query

using sc_linq.Models;
using sc_linq.DataSource;
using sc_linq.ModelsSC;

namespace sc_linq;

class Program
{
    static void Main(string[] args)
    {
        #region loading Datei
        List<Customer> clienti = Customers.CustomerList;
        Logger.Titolo("Caricamento Clienti");
        Console.WriteLine(clienti.Count);
        // foreach (Customer cliente in clienti)
        // {
        //     Console.WriteLine(cliente);
        // }
        #endregion

        #region where condizione con proprietà + here in elenco
        List<Customer> clientiUSA = clienti.Where(c => c.Country == "USA").ToList();
        Logger.Titolo("Clienti USA");
        int counter = 0;
        foreach (var client in clientiUSA)
        {
            counter++;
            if (counter % 2 == 0)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
            }
            Console.WriteLine(client);
        }
        Console.ResetColor();
        Console.Write($"Totale clienti USA: {clientiUSA.Count}");
        List<Customer> clientiL = new List<Customer>();
        try
        {
            clientiL = clientiUSA.Where(u => u.CompanyName.ToUpper().StartsWith('L')).ToList();
            Logger.Titolo("Clienti USA il cui nome inizia con la Lettera L");
            foreach (var client in clientiL)
            {
                counter++;
                if (counter % 2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                }
                Console.WriteLine(client);

            }
            Console.ResetColor();
            if (clientiL.Count > 0)
            {
                Console.Write($"Totale clienti USA il cui nome inizia con la lettera L: {clientiL.Count}\n\n");
            }
            else
            {
                throw new NullReferenceException();
            }

        }
        catch (NullReferenceException)
        {
            Console.ResetColor();
            Console.Write($"Non ci sono clienti negli USA che posseggono un nome che inizia con la 'L'\n\n");
        }
        #endregion

        #region where condizione con proprietà Matrjoschka
        decimal tassoDiCambio = 0.9m;
        List<Cliente> nostriClienti;
        Logger.Titolo("I nostri clienti nelle nostre Classi");
        if (clientiL.Count > 0)
        {
            nostriClienti = clientiL.Select(x =>
                new Cliente(x.CustomerID, x.CompanyName, x.Address, x.Orders.Select(y =>
                new OrdineEuro(y.Total * tassoDiCambio, y.OrderDate)).ToList())).ToList();
            foreach (Cliente cliente in nostriClienti)
            {
                Console.WriteLine(cliente);
            }
        }
        else
        {
            Console.ResetColor();
            Console.Write($"Non ci sono clienti negli USA che posseggono un nome che inizia con la 'L'. Il nostro Portafoglio Clienti è vuoto.");
        }
        #endregion
    }
}