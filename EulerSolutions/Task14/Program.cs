internal class Program
{
    private static void Main(string[] args)
    {
        const decimal MaxValue = 1000000;

        decimal i = 1;
        var dictionary = new Dictionary<decimal, decimal>();

        while (i < MaxValue)
        {
            var sequence = GenerateCollatzSequence(i).ToList();

            dictionary.Add(i, sequence.Count);

            i++;
        }

        var maxLength = dictionary.Values.Max();
        var desired = dictionary.SingleOrDefault(x => x.Value == maxLength).Key;

        Console.WriteLine($"desired - {desired}, length - {maxLength}");
    }

    private static IEnumerable<decimal> GenerateCollatzSequence(decimal i)
    {
        yield return i;

        while (i > 1)
        {
            GenerateCollatzMember(ref i);
            yield return i;
        }
    }

    private static void GenerateCollatzMember(ref decimal i)
    {
        if (i % 2 == 0)
            i /= 2;

        else
            i = 3 * i + 1;
    }
}