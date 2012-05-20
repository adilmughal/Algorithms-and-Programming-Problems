using System;
using System.IO;

namespace ProgrammingProblems
{
    public partial class Numeric
    {
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
    }
}