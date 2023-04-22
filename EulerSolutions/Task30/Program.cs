internal class Program
{
    private static void Main(string[] args)
    {
        const int Pow = 5;
        const int ApproximateLimit = 1000000;

        var list = new List<int>();
        var magicNumbers = new List<int>();

        for (var i = 2; i < ApproximateLimit; i++)
        {
            list.Clear();

            var arr = i.ToString().ToCharArray() as IEnumerable<char>;

            foreach (var digit in arr)
                list.Add(int.Parse(digit.ToString()));

            var sum = list.Select(x => Math.Pow(x, Pow)).Sum();

            if (sum == i)
                magicNumbers.Add(i);
        }

        Console.WriteLine(string.Join(", ", magicNumbers));
        Console.WriteLine($"Sum of magic numbers: {magicNumbers.Sum()}");
    }
}