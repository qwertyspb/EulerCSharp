namespace Task3
{
    public static class Extensions
    {
        public static bool IsPrimeLong(this long num)
        {
            for (long i = 2; i < num; i++)
            {
                if (num % i == 0)
                    return false;
            }

            return true;
        }

        public static bool IsPrime(this int num)
        {
            if (num == 1 || num == 2)
                return true;

            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                    return false;
            }

            return true;
        }
    }
}
