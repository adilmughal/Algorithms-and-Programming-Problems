using System;

namespace ProgrammingProblems
{
    public class BitwiseProblems
    {
        public static double ConvertToBase10(byte input)
        {
            int power = 0;
            double result = 0;
            while (input != 0)
            {
                int bitValue = input & 1;
                result = result + Math.Pow(2, power)*bitValue;
                power++;
                input = (byte) (input >> 1);
            }

            return result;
        }
    }
}