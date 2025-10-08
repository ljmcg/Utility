namespace ljmcg
{
    public static partial class Math
    {
        public static long RoundUpToMultiple(long original, long factor)
        {
            ArgumentOutOfRangeException.ThrowIfLessThan(original, 0);
            ArgumentOutOfRangeException.ThrowIfLessThan(factor, 1);
            var remainder = original % factor;
            if (remainder == 0)
            {
                return original;
            }
            return original - remainder + factor;
        }
        public static int RoundUpToMultiple(int original, int factor)
        {
            ArgumentOutOfRangeException.ThrowIfLessThan(original, 0);
            ArgumentOutOfRangeException.ThrowIfLessThan(factor, 1);
            var remainder = original % factor;
            if (remainder == 0)
            {
                return original;
            }
            return original - remainder + factor;
        }
        public static bool IsPrime(long candidate)
        {
            if (candidate > 2 && (candidate & 1) != 0)
            {
                int limit = (int)System.Math.Sqrt(candidate);
                for (int divisor = 3; divisor <= limit; divisor += 2)
                {
                    if ((candidate % divisor) == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
            return candidate == 2;
        }
        public static long GreatestPrimeLessThan(long candidate)
        {
            ArgumentOutOfRangeException.ThrowIfLessThan(candidate, 4);
            --candidate;
            if (0 == candidate % 2)
            {
                --candidate;
            }
            for (; !IsPrime(candidate); candidate -= 2)
            {
            }
            return candidate;
        }
        public static long LeastPrimeGreaterThan(long candidate)
        {
            ArgumentOutOfRangeException.ThrowIfLessThan(candidate, 2);
            ++candidate;
            if (0 == candidate % 2)
            {
                ++candidate;
            }
            for (; !IsPrime(candidate); candidate += 2)
            {
            }
            return candidate;
        }
        public static bool IsPrime(int candidate)
        {
            if (candidate > 2 && (candidate & 1) != 0)
            {
                int limit = (int)System.Math.Sqrt(candidate);
                for (int divisor = 3; divisor <= limit; divisor += 2)
                {
                    if ((candidate % divisor) == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
            return candidate == 2;
        }
        public static int GreatestPrimeLessThan(int candidate)
        {
            ArgumentOutOfRangeException.ThrowIfLessThan(candidate, 4);
            --candidate;
            if (0 == candidate % 2)
            {
                --candidate;
            }
            for (; !IsPrime(candidate); candidate -= 2)
            {
            }
            return candidate;
        }
        public static int LeastPrimeGreaterThan(int candidate)
        {
            ArgumentOutOfRangeException.ThrowIfLessThan(candidate, 2);
            ++candidate;
            if (0 == candidate % 2)
            {
                ++candidate;
            }
            for (; !IsPrime(candidate); candidate += 2)
            {
            }
            return candidate;
        }
    }
}
