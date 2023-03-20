using Task3;

internal class Program
{
    private static void Main(string[] args)
    {
        const int Limit = 10001;
        var counter = 0;
        var i = 1;
        var result = 0;

        while (counter <= Limit)
        {
            if (i.IsPrime())
            {
                counter++;
                result = i;
            }

            i++;
        }

        Console.WriteLine(result);
    }
}