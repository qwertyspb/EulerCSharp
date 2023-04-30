using HelpersLibrary;

internal class Program
{
    private static void Main(string[] args)
    {
        var income = File.ReadAllText(@"../../../p042_words.txt");

        var words = income.Split(',')
            .Select(x => x.Replace("\"", string.Empty))
            .ToList();

        var wordValues = GetValues(words);

        var triangleNumbers = GetTriangleNumbersTill(wordValues.Max());

        var count = wordValues.Where(x => triangleNumbers.Contains(x)).Count();

        Console.WriteLine(count);
    }

    private static IEnumerable<int> GetTriangleNumbersTill(int max)
    {
        for (var n = 1; n <= max; n++)
            yield return n * (n + 1) / 2;
    }

    private static List<int> GetValues(List<string> words)
        => words.Select(x => GetWordValue(x)).ToList();

    private static int GetWordValue(string word)
        => Helpers.GetListOfLetterIndexes(word).Sum();
}