using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        var row = GetFibonacciRow(4000000);

        var evenRow = row.Where(x => x % 2 == 0).ToList();

        Console.WriteLine($"Sum of the evens: {evenRow.Sum()}");
    }

    private static List<int> GetFibonacciRow(int lastNumber)
    {
        var row = new List<int> { 1, 2 };

        while ((row[^1] + row[^2]) < lastNumber)
        {
            row.Add(row[^1] + row[^2]);
        }

        return row;
    }
}