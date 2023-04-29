using HelpersLibrary;

internal class Program
{
    private static void Main(string[] args)
    {
        var limit = 0;
        var incomeSum = 0d;

        try
        {
            limit = int.Parse(args.FirstOrDefault());
            incomeSum = double.Parse(args.LastOrDefault());
        }
        catch (Exception)
        {
            limit = 1000;
            incomeSum = 0d;
        }

        var result = new List<int>();

        for (var i = 1; i < limit; i++)
        {
            for (var j = 1; j < limit; j++)
            {
                var product = i * j;

                if (IsPandigital(i, j, product))
                    result.Add(product);
            }
        }

        var sum = MySum(result.Distinct());

        if (sum == incomeSum)
        {
            Console.WriteLine($"Searched sum: {sum}");
            return;
        }

        else
            Console.WriteLine($"Sum from 1 to {limit}: {sum}");

        var parameters = new string[] { (limit + 1000).ToString(), sum.ToString() };

        Main(parameters);
    }

    private static double MySum(IEnumerable<int> list)
    {
        var sum = 0d;

        foreach (var item in list)
            sum += item;

        return sum;
    }

    private static bool IsPandigital(int i, int j, int product)
    {
        var num = PrepareData(i, j, product);

        return Helpers.IsPandigitalFrom1To9(num);
    }

    private static long PrepareData(int a, int b, int c)
    {
        var list = new List<int> { a, b, c };

        var result = string.Join(string.Empty, list.Select(x => x.ToString()));

        return long.Parse(result);
    }
}