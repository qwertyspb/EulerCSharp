using Enums;

namespace HelpersLibrary
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

        /// <summary>
        /// Rerurns int as a list of digits
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public static List<int> GetListOfDigits(long i)
        {
            var arr = i.ToString().ToCharArray();

            return arr.Select(x => int.Parse(x.ToString())).ToList();
        }

        /// <summary>
        /// Rerurns double as a list of digits
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public static List<int> GetListOfDigits(double i)
        {
            var arr = i.ToString().ToCharArray();

            return arr.Select(x => int.Parse(x.ToString())).ToList();
        }

        public static double GetFactorial(int d)
        {
            var result = 1d;

            for (int i = 1; i <= d; i++)
                result *= i;

            return result;
        }

        public static int GetFirstDigit(int num, out int rest)
        {
            var divider = 0.1;
            bool hasManyDigits = true;

            while (hasManyDigits)
            {
                divider *= 10;
                hasManyDigits = num / divider > 10;
            }

            rest = num % (int)divider;

            return num / (int)divider;
        }

        public static int GetLastDigit(int num)
            => num < 10 ? num : num % 10;

        public static int GetLastDigit(int num, out int rest)
        {
            rest = num / 10;
            return GetLastDigit(num);
        }

        public static int Reverse(int num)
        {
            if (num == 0)
                return num;

            var list = new List<int>();

            while (num > 0)
            {
                var lastDigit = GetLastDigit(num, out var rest);

                list.Add(lastDigit);

                num = rest;
            }

            var reversedStr = string.Join(string.Empty, list.Select(i => i.ToString()));

            return int.Parse(reversedStr);
        }

        public static int TruncateRight(int num)
            => num / 10;

        public static int TruncateLeft(int num)
        {
            var divider = 0.1;
            bool hasManyDigits = true;

            while (hasManyDigits)
            {
                divider *= 10;
                hasManyDigits = num / divider > 10;
            }

            return num % (int)divider;
        }

        public static int TruncateFrom(Side side, int i)
        {
            return side switch
            {
                Side.Left => TruncateLeft(i),
                Side.Right => TruncateRight(i),
                _ => throw new NotImplementedException()
            };
        }

        public static bool IsPandigitalFrom1To9(long num)
        {
            var limit = 9;

            var list = GetListOfDigits(num).ToList();

            return !list.Contains(0)
                && list.Count <= limit
                && list.Distinct().Count() == limit;
        }

        private static IEnumerable<int> PrepareData(long num)
        {
            var result = new List<int>();

            var arr = num.ToString()
                .ToCharArray();

            foreach (var i in arr)
                result.Add(int.Parse(i.ToString()));

            return result;
        }

        public static bool IsPandigital(long num, int? limit = null, bool includeZero = false)
        {
            limit ??= num.ToString().Length;

            var list = GetListOfDigits(num) as IEnumerable<int>;

            list = list.Distinct();

            return includeZero 
                ? list.Count() == limit
                : list.Count() == limit && !list.Contains(0);
        }

        public static bool IsInOrder(long num, int startDigit)
        {
            var list = GetListOfDigits(num) as IEnumerable<int>;

            list = list.OrderBy(x => x);

            var previous = startDigit - 1;
            foreach (var i in list)
            {
                if (i - previous != 1)
                    return false;

                previous = i;
            }

            return true;
        }

        public static IEnumerable<int> GetListOfLetterIndexes(string word)
        {
            var alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

            var arr = word.ToCharArray();

            return arr.Select(letter => Array.IndexOf(alphabet, letter) + 1);
        }

        public static double GetPentagonalNumber(double position)
            => position * (3 * position - 1) / 2;

        public static double GetTriangleNumber(double position)
            => position * (position + 1) / 2;

        public static double GetHexagonalNumber(double position)
            => position * (2 * position - 1);
    }
}