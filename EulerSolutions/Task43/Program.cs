using HelpersLibrary;

internal class Program
{
    private static List<long> _variants = new();
    private static void Main(string[] args)
    {
        var result = new List<long>();

        var arr = "1234567890".ToCharArray();

        Permute(arr, 0, arr.Length - 1);

        _variants = _variants.Where(x => x.ToString().Length == arr.Length).ToList();

        foreach (var i in _variants)
        {
            if (IsSubstringDivisible(i, 3))
            {
                result.Add(i);
                Console.WriteLine(i);
            }
        }

        Console.WriteLine(result.Sum());
    }

    private static bool IsSubstringDivisible(long num, int substringLength)
    {
        var digits = Helpers.GetListOfDigits(num);
        var str = num.ToString();

        var length = digits.Count - substringLength;

        var primeRow = GetPrimeRow(length);

        if (str == null)
            return false;

        for (var i = length; i > 0; i--)
        {
            var substr = str.Substring(i, substringLength);

            var parsed = int.Parse(substr);

            if (parsed % primeRow[i - 1] != 0)
                return false;
        }

        return true;
    }

    private static List<int> GetPrimeRow(int length)
    {
        var result = new List<int>();

        for (var i = 1; result.Count < length; i++)
        {
            if (Helpers.IsPrime(i))
                result.Add(i);
        }

        return result;
    }

    private static void Permute(char[] a, int i, int n)
    {
        int j;

        if (i == n)
            _variants.Add(long.Parse(string.Join(string.Empty, a)));

        else
        {
            char temp;
            for (j = i; j <= n; j++)
            {
                // swap(a[i], a[j]);
                temp = a[i];
                a[i] = a[j];
                a[j] = temp;

                Permute(a, i + 1, n);

                // swap(a[i], a[j]);
                temp = a[i];
                a[i] = a[j];
                a[j] = temp;
            }
        }
    }
}