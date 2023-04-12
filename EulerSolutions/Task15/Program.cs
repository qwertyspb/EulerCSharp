internal class Program
{
    private static void Main(string[] args)
    {
        const int Pow = 15;

        var income = Math.Pow(2, Pow);

        var arr = income.ToString().ToCharArray();

        var nums = new List<double>();

        foreach (var c in arr)
        {
            double.TryParse(c.ToString(), out var result);
            nums.Add(result);
        }

        Console.WriteLine(nums.Sum());
    }
}