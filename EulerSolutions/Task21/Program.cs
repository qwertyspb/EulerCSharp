internal class Program
{
    private static void Main(string[] args)
    {
        var matches = new List<decimal>();
        var amicables = new List<decimal>();

        for (var n = 1; n <= 10000; n++)
        {
            if (matches.Contains(n))
                continue;

            var a = Get_d(n);
            var b = Get_d(a);

            if (n == b && a != b)
            {
                matches.Add(a);

                amicables.Add(b);
                amicables.Add(a);
            }
        }

        amicables.ForEach(x => Console.WriteLine(x));
        Console.WriteLine();
        Console.WriteLine(amicables.Sum());
    }

    private static decimal Get_d(decimal n)
    {
        var result = new List<decimal>();

        for (var i = n - 1; i > 0; i--)
            if (n % i == 0)
                result.Add(i);

        return result.Sum();
    }
}