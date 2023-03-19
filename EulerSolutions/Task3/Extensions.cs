namespace Task3
{
    internal static class Extensions
    {
        internal static bool IsPrime(this long num)
        {
            for (long i = 2; i < num; i++)
            {
                if (num % i == 0)
                    return false;
            }

            return true;
        }
    }
}
