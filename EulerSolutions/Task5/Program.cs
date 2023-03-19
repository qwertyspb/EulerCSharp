internal class Program
{
    private static void Main(string[] args)
    {
        var till = 20;
        const int Limit = 1000000000;

        for (var i = till; i < Limit; i++)
        {
            for (var x = 1; x <= till; x++)
            {
                var reminder = i % x;

                if (reminder == 0)
                {
                    if (x == till)
                    {
                        Console.WriteLine($"The smallest positive number that is evenly divisible by all of the numbers from 1 to {till} is {i}");
                        return;
                    }
                }

                else
                    break;
            }
        }
    }
}