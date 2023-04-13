using Enums;

namespace HelpingLibrary
{
    public class Helpers
    {
        public static long MultiplyInCycle(int i, List<int> list, int adjacent, MultiplyDirection side, int divider = 0)
        {
            var counter = 0;
            long product = 1;

            while (counter < adjacent)
            {
                counter++;

                product *= list[i];

                i = side switch
                {
                    MultiplyDirection.Row => i + 1,
                    MultiplyDirection.Column => i + divider,
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

        public static List<int> GetListOfNumbers(int i)
        {
            var arr = i.ToString().ToCharArray();

            return arr.Select(x => int.Parse(x.ToString())).ToList();
        }
    }
}
