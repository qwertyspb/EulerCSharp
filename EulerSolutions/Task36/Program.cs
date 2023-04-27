using HelpingLibrary;

internal class Program
{
    private static void Main(string[] args)
    {
        var result = new List<int>();

        for (var i = 1; i < 1000000; i++)
        {
            if (!i.Equals(Helpers.Reverse(i)))
                continue;

            var binary = Convert.ToString(i, 2);
            var reversed = string.Join(string.Empty, binary.Reverse());

            if (binary.Equals(reversed))
                result.Add(i);
        }

        Console.WriteLine(result.Sum());
    }
}