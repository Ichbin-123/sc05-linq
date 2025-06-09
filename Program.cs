// LINQ Language Integrated Query

using sc_linq.Models;
using sc_linq.DataSource;
using sc_linq.ModelsSC;

namespace sc_linq;

class Program
{
    static void Main(string[] args)
    {
        #region select syntax
        int[] numbers = [5, 4, 1, 3, 9, 8, 6, 7, 2, 0];
        var numPlusOne = numbers.Select(x => x + 1);
        Logger.Titolo("Restituisci n+1");
        Console.WriteLine(string.Join(", ", numPlusOne));
        #endregion

        #region select property
        var productsNames = Products.ProductList.Select(x => x.ProductName);
        Logger.Titolo("Solo nomi:");
        foreach (var name in productsNames)
        {
            Console.WriteLine(name);
        }
        #endregion

        #region select transform
        string[] strings = ["zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"];
        var textNums = numbers.Select(n => strings[n]);
        Logger.Titolo("Numeri in stringa ");
        Console.WriteLine(string.Join(" ", textNums));
        #endregion

        #region select anonymous typs
        var gigi = new { Nome = "Gigi", Cognome = "Verdi" };
        Console.WriteLine(gigi.Cognome);

        string[] words = ["aPPLE", "BlUeBeRrY", "cHeRry"];
        var transformedWords = words.Select(x => new
        {
            UPPER = x.ToUpper(),
            lower = x.ToLower()
        });

        Logger.Titolo("Upper/Lower");
        foreach (var t in transformedWords)
        {
            Console.WriteLine($"UPPER: {t.UPPER}, lower: {t.lower}");
        }

        #endregion

        #region select new type
        var digitOddEvens = numbers.Select(x => new Dummy(strings[x], x % 2 == 0));
        Logger.Titolo("Cifra/Pari/Dispari");
        foreach (var d in digitOddEvens)
        {
            Console.WriteLine($"La cifra {d.Digit} è {(d.Even ? "pari" : "dispari")}.");
        }

        // var d = new Dummy
        // {
        //     Digit = "Uno",
        //     Even = true
        // };

        #endregion

        #region select subset properties
        var productInfos = Products.ProductList.Where(x => x.UnitsInStock > 0).Select(x => new { x.ProductName, x.Category, Price = x.UnitPrice });
        Logger.Titolo("Prodotti");
        foreach (var productInfo in productInfos)
        {
            Console.WriteLine($"{productInfo.ProductName} è nella categoria {productInfo.Category} e costa {productInfo.Price:C} per unità.");
        }
        #endregion



    }
}



