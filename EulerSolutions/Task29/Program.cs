internal class Program
{
    private static void Main(string[] args)
    {
        var range = Enumerable.Range(2, 99);
        var list = new List<double>();

        foreach (var i in range)
            foreach (var j in range)
                list.Add(Math.Pow(i, j));

        list = list.Distinct()
            .OrderBy(x => x)
            .ToList();

        Console.WriteLine($"Count: {list.Count}");
    }
}