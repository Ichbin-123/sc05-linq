namespace sc_linq.Models;

public class Dummy
{

    public Dummy(string digit, bool even)
    {
        Digit = digit;
        Even = even;
    }
    public string Digit { get; set; }
    public bool Even { get; set; }
}