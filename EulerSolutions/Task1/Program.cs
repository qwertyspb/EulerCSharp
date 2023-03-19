internal class Program
{
    private static void Main(string[] args)
    {
        var nums = Enumerable.Range(1, 9);

        var dividers = new List<int>() { 3, 5, 2};

        nums = GetAllMultiplesOf(dividers, nums);

        foreach (var i in nums)
        {
            Console.Write($"{i}; ");
        }

        Console.WriteLine();
        Console.WriteLine($"Sum of the multiples: {nums.Sum()}");
    }

    private static IEnumerable<int> GetAllMultiplesOf(IEnumerable<int> dividers, IEnumerable<int> arr)
    {
        var lists = new List<List<int>>();

        foreach (var d in dividers) 
            lists.Add(arr.Where(x => x % d == 0).ToList());

        IEnumerable<int> result = new List<int>();

        for (var i = 0; i < lists.Count; i++)
        {
            result = result.Union(lists[i]);
        }

        return result;
    }
}