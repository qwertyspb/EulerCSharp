using HelpersLibrary;

internal class Program
{
    private static void Main(string[] args)
    {
        const double Limit = 100000000;

        var i = 286d;

        var t = 0d;
        var p = 0d;
        var h = 0d;

        while (i < Limit)
        {
            t = Helpers.GetTriangleNumber(i);

            var pRow = GetPentagonalRow(t, i);
            if (!pRow.Contains(t))
            {
                i++;
                continue;
            }

            var hRow = GetHexagonalRow(t, i);
            if (!hRow.Contains(t))
            {
                i++;
                continue;
            }

            Console.WriteLine(t);
            break;
        }
    }

    private static List<double> GetPentagonalRow(double max, double position)
    {
        var num = max;
        var row = new List<double>();

        for (double i = position; num >= max; i--)
        {
            num = Helpers.GetPentagonalNumber(i);
            row.Add(num);
        }

        return row;
    }
    private static List<double> GetHexagonalRow(double max, double position)
    {
        var num = max;
        var row = new List<double>();

        for (double i = position; num >= max; i--)
        {
            num = Helpers.GetHexagonalNumber(i);
            row.Add(num);
        }

        return row;
    }

}