using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProgrammingProblems
{
    public class ArthmeticProblems
    {
        public static int ThreeNplusOne(int i, int j)
        {
            int maximumCycleLength = 0;
            int start, end;
            if (i < j)
            {
                start = i + 1;
                end = j - 1;
            }
            else
            {
                start = j + 1;
                end = i - 1;
            }
            for (int k = start; k <= end; k++)
            {
                int currentCycleLength = 1;
                int s = k;
                while (s != 1)
                {
                    if (s%2 == 0)
                        s = s/2;
                    else
                        s = (3*s) + 1;
                    currentCycleLength++;
                }
                if (currentCycleLength > maximumCycleLength)
                    maximumCycleLength = currentCycleLength;
            }
            return maximumCycleLength;
        }

        public static double MultiplyWithoutOperator(int x, int factor)
        {
            if (x == 0 || factor == 0)
                return 0;

            if (x == 1)
                return factor;

            if (factor == 1)
                return x;

            if (factor < 0)
                throw new ArgumentOutOfRangeException("factor");

            if (x < 0)
                return -MultiplyWithoutOperator(-x, factor);

            double result = 0;
            for (int i = 0; i < factor; i++)
            {
                result += x;
            }

            return result;
        }


        public static double MultiplyWithoutOperatorV2(int x, int factor)
        {
            if (x == 0 || factor == 0)
                return 0;

            if (x == 1)
                return factor;

            if (factor == 1)
                return x;

            if (factor < 0)
                throw new ArgumentOutOfRangeException("factor");

            if (x < 0)
                return -MultiplyWithoutOperatorV2(-x, factor);

            double result = 0;

            while (factor != 0)
            {
                if (Convert.ToBoolean(factor & 01))
                {
                    result = result + x;
                }
                x = x << 1;
                factor = factor >> 1;
            }

            return result;
        }

        public static int DivideWithoutOperator(int numerator, int divider)
        {
            if (numerator == 0)
                return 0;

            if (divider == 1)
                return numerator;

            if (divider == 0)
                throw new DivideByZeroException("divider");

            if (divider > numerator)
                throw new InvalidDataException("Don't want to handle this!!");

            if (numerator < 0)
                return -DivideWithoutOperator(-numerator, divider);

            int quotient = 0;

            while (numerator >= divider)
            {
                numerator = numerator - divider;
                quotient++;
            }
            return quotient;
        }

        public static int[] IterativeFibonacci(int max)
        {
            if (max < 1)
                return new[] {0};

            var result = new List<int>(new[] {0, 1});

            int n = 2;

            while (true)
            {
                int sum = result[n - 1] + result[n - 2];
                if (sum > max)
                    break;
                result.Insert(n, sum);
                n++;
            }
            return result.ToArray();
        }

        public static int RecursiveFibonacci(int n)
        {
            if (n == 0 || n == 1)
                return n;

            else if (n > 1)
                return RecursiveFibonacci(n - 1) + RecursiveFibonacci(n - 2);

            else return -1;
        }

        public static int GreatestCommonDivisior(int m, int n)
        {
            //Used euclid algorithm to find out GCD or GCF
            int remainder = -1;
            while (remainder != 0)
            {
                remainder = m%n;
                m = n;
                n = remainder;
            }
            return m;
        }

        public static int LeastCommonMultiple(int m, int n)
        {
            return ((m*n)/GreatestCommonDivisior(m, n));
        }

        public static bool IsPrime(int n)
        {
            for (int i = 2; i <= n; i++)
            {
                if (n%i == 0)
                {
                    if (i == n)
                        return true;
                    else
                        return false;
                }
            }
            return false;
        }

        public static int[] PrimeFactors(int n)
        {
            var factors = new List<int>();
            for (int i = 2; i <= n; i++)
            {
                while (n%i == 0 && IsPrime(i))
                {
                    factors.Add(i);
                    n = n/i;
                }
            }
            return factors.ToArray();
        }

        public static int LeastCommonMultipleByPrimeFactorization(int m, int n)
        {
            int[] mFactors = PrimeFactors(m);
            int[] nFactors = PrimeFactors(n);

            Dictionary<int, int> mFactorsCountHash = CreateCounterHash(mFactors);
            Dictionary<int, int> nFactorsCountHash = CreateCounterHash(nFactors);

            var primeFactors = new List<int>();
            primeFactors.AddRange(mFactors);
            primeFactors.AddRange(nFactors);

            int result = 1;

            foreach (int factor in primeFactors.Distinct())
            {
                int mfactorCount = 0;
                int nfactorCount = 0;
                if (mFactorsCountHash.ContainsKey(factor))
                {
                    mfactorCount = mFactorsCountHash[factor];
                }

                if (nFactorsCountHash.ContainsKey(factor))
                {
                    nfactorCount = nFactorsCountHash[factor];
                }

                int numberOfCount = mfactorCount > nfactorCount ? mfactorCount : nfactorCount;
                result = factor*result*numberOfCount;
            }

            return result;
        }

        private static Dictionary<int, int> CreateCounterHash(IEnumerable<int> mFactors)
        {
            var hash = new Dictionary<int, int>();
            foreach (int factor in mFactors)
            {
                if (hash.ContainsKey(factor))
                    hash[factor]++;
                else
                    hash.Add(factor, 1);
            }
            return hash;
        }
    }
}