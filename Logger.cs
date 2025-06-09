namespace sc_linq;

public static class Logger
{
    public static void Titolo(string titolo)
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.Write(System.Environment.NewLine);
        Console.WriteLine(new String('=', 60));
        Console.WriteLine($"{titolo}");
        Console.WriteLine(new String('=', 60));
        Console.Write(System.Environment.NewLine);
        Console.ResetColor();
    }
}