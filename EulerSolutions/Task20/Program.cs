using HelpersLibrary;

internal class Program
{
    // Doesn't work for doubles. Todo:
    private static void Main(string[] args)
    {
        var x = 10;
        var factorial = GetFactorialOf(x);

        var result = Helpers.GetListOfDigits(factorial);

        Console.WriteLine(result.Sum());
    }

    private static double GetFactorialOf(int x)
    {
        var result = 1d;

        for (var i = x; i > 0; i--)
            result *= i;

        return result;
    }
}