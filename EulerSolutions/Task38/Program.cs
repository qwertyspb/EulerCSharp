using HelpersLibrary;

internal class Program
{
    private static void Main(string[] args)
    {
        const int Limit = 10000;

        var panDigits = new List<int>();

        for (var i = 1; i <= Limit; i++)
        {
            bool hasNineDigits = TryMultiplyTillNineDigits(i, out var nineDigitNumber);

            if (hasNineDigits)
            {
                panDigits.Add(nineDigitNumber);
                Console.WriteLine($"{nineDigitNumber}, {i}");
            }
        }

        Console.WriteLine($"Max: {panDigits.Max()}");
    }

    private static bool TryMultiplyTillNineDigits(int i, out int nineDigitNumber)
    {
        nineDigitNumber = 0;

        var result = Multiply(i);

        if (string.IsNullOrEmpty(result))
            return false;

        var parsed = int.Parse(result);

        var isPandigital = Helpers.IsPandigital(parsed, 9);

        if (isPandigital)
            nineDigitNumber = parsed;

        return isPandigital;
    }

    private static string Multiply(int num)
    {
        if (num.ToString().Length > 9)
            throw new Exception();

        var result = "";

        for (var j = 1; result.Length < 9; j++)
        {
            var product = num * j;
            result += product;
        }

        return result.Length == 9 ? result : string.Empty;
    }
}