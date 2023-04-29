using HelpersLibrary;

internal class Program
{
    private static void Main(string[] args)
    {
        var circularPrimes = new List<int>();

        for (int num = 2; num < 1000000; num++)
        {
            var digits = Helpers.GetListOfDigits(num);

            if (digits.Contains(0) || circularPrimes.Contains(num))
                continue;

            var rotatedNumbers = GetRotatedNumbers(num);

            var isPrimeList = rotatedNumbers.All(num => Helpers.IsPrime(num));

            if (isPrimeList)
                rotatedNumbers.ForEach(x => circularPrimes.Add(x));
        }

        circularPrimes = circularPrimes.Distinct().ToList();

        Console.Write(circularPrimes.Count);
    }

    private static List<int> GetRotatedNumbers(int num)
    {
        var rotatedNumbers = new List<int> { num };

        var digits = Helpers.GetListOfDigits(num);

        if (digits.Contains(0))
            throw new Exception($"This method cannot be applied to zero containing numbers. Number you try to rotate is {num}");

        for (var i = 0; i < digits.Count - 1; i++)
        {
            num = Rotate(num);
            rotatedNumbers.Add(num);
        }

        return rotatedNumbers;
    }

    private static int Rotate(int num)
    {
        var firstDigit = Helpers.GetFirstDigit(num, out var rest);

        return int.Parse(rest.ToString() + firstDigit.ToString());
    }
}