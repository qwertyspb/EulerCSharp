using System.Runtime.InteropServices;

internal class Program
{
    private static void Main(string[] args)
    {
        var input = 1000;
        var results = new List<int>();

        for (var x = 100; x < input; x++)
        {
            for (var y = 100; y < input; y++)
            {
                var result = x * y;

                if (IsPalindromic(result))
                {
                    results.Add(result);
                }
            }
        }

        Console.WriteLine(results.Max());
    }

    private static bool IsPalindromic(int value)
    {
        var str = value.ToString();
        var reversed = string.Join(string.Empty, str.Reverse());

        return str.Equals(reversed);
    }
}