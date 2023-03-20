internal class Program
{
    private static void Main(string[] args)
    {
        const int Number = 100;

        double sumOfSquares = GetSumOfSquares(Number);
        double squareOfSum = GetSquareOfSum(Number);

        Console.WriteLine($"Sum of the squares is {sumOfSquares}");
        Console.WriteLine($"Square of the sum is {squareOfSum}");
        Console.WriteLine($"The difference is {squareOfSum - sumOfSquares}");
    }

    private static double GetSquareOfSum(int number)
    {
        double result = 0;

        for (var i = 1; i <= number; i++)
            result += i;

        return Math.Pow(result, 2);
    }

    private static double GetSumOfSquares(int number)
    {
        double result = 0;
        
        for (var i = 1; i <= number; i++)
            result += Math.Pow(i, 2);
        
        return result;
    }
}