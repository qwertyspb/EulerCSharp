internal class Program
{
    private static void Main(string[] args)
    {
        var dictionary = new Dictionary<int, int>();

        for (var p = 2; p <= 1000; p++) 
        {
            var variants = GetSideLengthVariants(p);

            var count = variants.Count();

            if (count == 0)
                continue;

            Console.WriteLine($"p: {p}, count: {count}");

            dictionary.Add(p, count);
        }

        var pWithMaxCount = dictionary.MaxBy(x => x.Value).Key;
        Console.WriteLine($"p with max count: {pWithMaxCount}");
    }

    private static IEnumerable<List<int>> GetSideLengthVariants(int p)
    {
        for (int a = 1; a < p; a++)
        {
            for (int b = a; b < p; b++)
            {
                var hypotenuse = p - a - b;

                var isValid = Math.Pow(hypotenuse, 2) == Math.Pow(a, 2) + Math.Pow(b, 2);

                if (isValid)
                    yield return new List<int> { a, b, hypotenuse };
            }
        }
    }
}