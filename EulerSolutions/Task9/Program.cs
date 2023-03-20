internal class Program
{
    private static void Main(string[] args)
    {
        const int Limit = 998;

        const int Aim = 1000;

        for (int a = 1; a < Limit; a++)
        {
            for (int b = a + 1; b < Limit; b++)
            {
                var cSquared = Math.Pow(a, 2) + Math.Pow(b, 2);

                var c = Math.Sqrt(cSquared);

                if (a + b + c == Aim)
                {
                    Console.WriteLine($"a - {a}; b - {b}, c - {c}");
                    Console.WriteLine($"Product - {a * b * c}");
                    return;
                }
            }
        }
    }
}