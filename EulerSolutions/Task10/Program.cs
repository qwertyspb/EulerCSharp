using Task3;

internal class Program
{
    private static void Main(string[] args)
    {
        const int Million = 2000000;

        long result = 0;

        var counter = 0;

        for (long i = 1; i < Million; i++)
        {
            counter++;

            if (i.IsPrime())
                result += i;

            if (counter % 1000 == 0)
                Console.WriteLine(counter/1000);
        }

        Console.WriteLine(result);
    }
}