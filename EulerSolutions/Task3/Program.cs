using Task3;

internal class Program
{
    private static void Main(string[] args)
    {
        var num = 600851475143;

        var result = GetPrimeFactorsFor(num);

        Console.WriteLine(result);
    }

    private static long GetPrimeFactorsFor(long num)
    {
        const long Billion = 1000000000;
        long counter = 0;

        for (long i = num/2; i > 1; i--)
        {
            counter++;

            if (counter % Billion == 0)
            {
                var bilCounbter = counter / Billion;
                Console.WriteLine(bilCounbter);
            }

            if (num % i == 0 && i.IsPrime())
                return i;
        }

        return 0;
    }
}