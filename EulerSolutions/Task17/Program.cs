using HelpingLibrary.Interpretator;

internal class Program
{
    private static void Main(string[] args)
    {
        var arr = Enumerable.Range(1, 1000).ToList();

        var i = 12;
        Console.WriteLine(NumberInterpretator.GetWordInterpretation(i));

        //var sb = new StringBuilder();

        //arr.ForEach(x =>
        //{
        //    var wordInterpretation = NumberInterpretator.GetWordInterpretation(x);
        //    sb.Append(wordInterpretation);
        //});

        //sb.Replace(" ", string.Empty);

        //Console.WriteLine(sb.ToString().Length);
    }
}