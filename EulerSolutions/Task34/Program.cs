using HelpingLibrary;

internal class Program
{
    private static void Main(string[] args)
    {
        var curiousNumbers = new List<double>();

        for (int i = 10; i < 1000000; i++)
        {
            var digits = Helpers.GetListOfDigits(i);

            var factorials = new List<double>();

            foreach (var d in digits)
                factorials.Add(Helpers.GetFactorial(d));

            var sum = factorials.Sum();

            if (sum == i)
                curiousNumbers.Add(i);
        }

        Console.WriteLine("Curious numbers:");
        curiousNumbers.ForEach(i => Console.WriteLine(i));

        Console.WriteLine($"Sum: {curiousNumbers.Sum()}");
    }
}