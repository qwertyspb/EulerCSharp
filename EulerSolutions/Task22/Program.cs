using System.Xml.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        var alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

        var income = File.ReadAllText(@"C:\Users\alexa\PracticeCSharp\EulerCSharp_repo\EulerSolutions\Task22\p022_names.txt");

        var names = income
            .Split(',')
            .Select(x => x.Replace("\"", string.Empty))
            .ToList();
        names.Sort();

        var result = new List<decimal>();

        names.ForEach(name =>
        {
            var arr = name.ToCharArray();

            var letterSum = arr.Select(letter => Array.IndexOf(alphabet, letter) + 1)
                .Sum();

            var place = names.IndexOf(name) + 1;

            result.Add(letterSum * place);
        });

        Console.WriteLine(result.Sum());
    }
}