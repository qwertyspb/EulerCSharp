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

            var pRow = GetRow(t, i, RowType.Pentagonal);
            if (pRow.Contains(t))
            {
                var hRow = GetRow(t, i, RowType.Hexagonal);
                if (hRow.Contains(t))
                {
                    Console.WriteLine(t);
                    break;
                }
            }

            i++;
        }
    }

    private static List<double> GetRow(double max, double position, RowType rowType)
    {
        var num = max;
        var row = new List<double>();

        for (double i = position; num >= max; i--)
        {
            num = rowType switch
            {
                RowType.Pentagonal => Helpers.GetPentagonalNumber(i),
                RowType.Hexagonal => Helpers.GetHexagonalNumber(i),
                _ => throw new NotImplementedException()
            };

            row.Add(num);
        }

        return row;
    }

    private enum RowType
    {
        Pentagonal,
        Hexagonal
    }

}