using Enums;
using HelpersLibrary;

internal class Program
{
    private static void Main(string[] args)
    {
        var result = new List<int>();

        for (var i = 11; i < 1000000; i++)
        {
            if (IsValid(i))
                result.Add(i);

            if (result.Count == 11)
                break;
        }

        Console.WriteLine($"Sum {result.Sum()}");
    }

    private static bool IsValid(int i)
    {
        if (!Helpers.IsPrime(i))
            return false;

        var sides = new[] { Side.Left, Side.Right };

        foreach (var side in sides)
        {
            if (!IsTruncatablePrime(i, side))
                return false;
        }

        Console.WriteLine(i);

        return true;
    }

    private static bool IsTruncatablePrime(int i, Side side)
    {
        while (i > 10)
        {
            i = Helpers.TruncateFrom(side, i);

            if (!Helpers.IsPrime(i))
                return false;
        }

        return true;
    }
}