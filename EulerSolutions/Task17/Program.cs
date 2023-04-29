using HelpersLibrary.Interpretator;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        var arr = Enumerable.Range(1, 1000).ToList();

        //arr.ForEach(x => Console.WriteLine(NumberInterpretator.GetWordInterpretation(x)));

        var sb = new StringBuilder();

        arr.ForEach(x =>
        {
            var wordInterpretation = NumberInterpretator.GetWordInterpretation(x);
            sb.Append(wordInterpretation);
        });

        sb.Replace(" ", string.Empty);

        Console.WriteLine(sb.ToString().Length);
    }
}