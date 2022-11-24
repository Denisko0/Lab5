using Lab1;

namespace Lab1;

public class Colors : Printer
{
    private Random random = new Random();
    public override void Print(string value)
    {
        var prevColor = Console.ForegroundColor;

        Console.ForegroundColor = (ConsoleColor)random.Next(0, 12);

        Console.WriteLine(value.GetType());

        Console.ForegroundColor = (ConsoleColor)random.Next(0, 12);

        base.Print(value);

        Console.ForegroundColor = prevColor;
    }
}