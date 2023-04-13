using HelpingLibrary.Interpretator;

internal class Program
{
    private static void Main(string[] args)
    {
        var i = 9999;

        string wordInterpretation = NumberInterpretator.GetWordInterpretation(i);

        Console.WriteLine(wordInterpretation);
    }
}