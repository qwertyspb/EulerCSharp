internal class Program
{
    private static void Main(string[] args)
    {
        var nums = Enumerable.Range(1, 999);

        var dividers = new List<int>() { 3, 5 };

        var models = GetAllMultiplesOf(dividers, nums);

        foreach (var i in models)
        {
            var str = WriteMultiples(i.Multiples);
            Console.WriteLine($"Divider: {i.Divider}, Multiples: {str}");
        }

        IEnumerable<int> result = new List<int>();

        for (var i = 0; i < models.Count; i++)
        {
            result = result.Union(models[i].Multiples);
        }

        Console.WriteLine();
        Console.WriteLine($"Sum of the multiples: {result.Sum()}");
    }

    private static string WriteMultiples(List<int> nums)
    {
        var str = string.Empty;
        foreach (var i in nums)
            str += $"{i}; ";

        return str;
    }

    private static List<MultiplesResultModel> GetAllMultiplesOf(IEnumerable<int> dividers, IEnumerable<int> arr)
    {
        var lists = new List<List<int>>();
        var models = new List<MultiplesResultModel>();

        foreach (var d in dividers)
        {
            var model = new MultiplesResultModel();

            model.Multiples = arr.Where(x => x % d == 0).ToList();
            model.Divider = d;

            models.Add(model);
        }

        return models;
    }
}

internal class MultiplesResultModel
{
    public int Divider { get; set; }
    public List<int> Multiples { get; set; }

}