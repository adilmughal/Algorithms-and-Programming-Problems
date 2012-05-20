using System;

namespace ProgrammingProblems
{
    public partial class Numeric
    {
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
                factor = factor>> 1;
            }

            return result;
        }
    }


}