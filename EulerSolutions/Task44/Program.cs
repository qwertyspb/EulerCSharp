using HelpersLibrary;

internal class Program
{
    private static void Main(string[] args)
    {
        var limit = 30;

        var pentagonals = new List<int>();

        var position = 0;

        for (int i = 1; i <= limit; i++)
        {
            pentagonals.Add(Helpers.GetPentagonal(i));
            position = i;
        }

        limit = pentagonals.Last() * 2;

        for (int j = position + 1; j <= limit; j++)
            pentagonals.Add(Helpers.GetPentagonal(j));

        for (int i = 0; i < pentagonals.Count; i++)
        {
            var pj = pentagonals[i];

            int pk;
            var k = i;

            while (k < pentagonals.Count - 1)
            {
                k++;
                pk = pentagonals[k];

                var diff = pk - pj;
                var sum = pk + pj;

                if (pentagonals.Contains(sum) && pentagonals.Contains(diff))
                    Console.WriteLine($"Pj: {pj}, Pk: {pk}, D: {diff}");
            }
        }
    }

    
}