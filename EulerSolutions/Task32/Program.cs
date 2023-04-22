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

                if (isPandigitalFrom1To9(i, j, product))
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

    private static bool isPandigitalFrom1To9(int i, int j, int product)
    {
        var limit = 9;

        var list = PrepareData(i, j, product);

        return list.Contains(0) || list.Count > limit
            ? false
            : list.Distinct().ToList().Count() == limit;
    }

    private static List<int> PrepareData(int a, int b, int c)
    {
        var list = new List<int> { a, b, c };
        var result = new List<int>();

        foreach (var item in list)
        {
            var arr = item.ToString()
                .ToCharArray();

            foreach (var x in arr)
                result.Add(int.Parse(x.ToString()));
        }

        return result;
    }
}