using Enums;

namespace HelpingLibrary
{
    public class Helpers
    {
        public static long MultiplyInCycle(int i, List<int> list, int adjacent, MultiplySide side)
        {
            var counter = 0;
            long product = 1;

            while (counter < adjacent)
            {
                counter++;

                product *= list[i];

                i = side switch
                {
                    MultiplySide.Right => i + 1,
                    MultiplySide.Left => i - 1,
                    _ => throw new NotImplementedException()
                };
            }

            return product;
        }

        public static bool IsPrime(long num)
        {
            if (num == 1)
                return false;

            if (num == 2)
                return true;

            for (long i = 2; i < num; i++)
            {
                if (num % i == 0)
                    return false;
            }

            return true;
        }

        public static bool IsPrime(int num)
        {
            if (num == 1)
                return false;

            if (num == 2)
                return true;

            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                    return false;
            }

            return true;
        }

        public static long GetProductWithSide(int i, List<int> numbers, int adjacentDigits, MultiplySide side)
        {
            return side switch
            {
                MultiplySide.Right => MultiplyInCycle(i, numbers, adjacentDigits, side),
                MultiplySide.Left => MultiplyInCycle(i + (adjacentDigits - 1), numbers, adjacentDigits, side),
                _ => throw new NotImplementedException()
            };
        }
    }
}
