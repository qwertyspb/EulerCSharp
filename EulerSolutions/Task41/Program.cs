using HelpersLibrary;

internal class Program
{
    private static void Main(string[] args)
    {
        var max = 0;

        for (var i = 98765431; i > 0; i--)
        {
            if (i % 1000000 == 0)
                Console.WriteLine(i);

            if (Helpers.IsPandigital(i) && Helpers.IsInOrder(i, 1) && Helpers.IsPrime(i))
            {
                max = i;
                break;
            }
        }

        Console.WriteLine(max);
    }
}