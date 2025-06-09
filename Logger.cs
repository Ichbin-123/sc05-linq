namespace sc_linq;

public static class Logger
{
    public static void Titolo(string titolo)
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine(titolo);
        Console.ResetColor();
    }
}