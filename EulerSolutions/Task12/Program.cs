using System.Net.Http.Headers;

internal class Program
{

    private static void Main(string[] args)
    {
        const int Aim = 501;
        long x = 0;
        long sum = 0;
        int value = 0;

        while (!HasEnoughDivisors(sum, Aim, out var newValue))
        {
            if (newValue > value)
            {
                value = newValue;
                Console.WriteLine($"Current maximum number of found divisors: {value}");
            }

            x++;
            sum += x;
        }

        Console.WriteLine(sum);
    }

    private static bool HasEnoughDivisors(long sum, int aim, out int divisorNumber)
    {
        if (sum % (2 * 3) != 0)
        {
            divisorNumber = 0;
            return false;
        }

        var list = new List<long>();

        for (long i = 1; i <= sum; i++)
        {
            if (sum % i == 0)
                list.Add(i);

            if (list.Count == aim)
            {
                divisorNumber = list.Count;
                return true;
            }
        }
        
        divisorNumber = list.Count;

        return false;
    }
}