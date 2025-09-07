using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryCalculator
{
    internal class BinaryCalcImpl
    {
        private static long StringToDecimal(string b)
        {
            return Convert.ToInt32(b, 2);
        }

        private static string DecimalToBinaryString(long b)
        {
            return Convert.ToString(b, 2);
        }

        public static string Add(string b1, string b2)
        {
            long b1_10 = StringToDecimal(b1);
            long b2_10 = StringToDecimal(b2);
            long result = b1_10 + b2_10;
            return DecimalToBinaryString(result);
        }

        public static string Subtract(string b1, string b2)
        {
            long b1_10 = StringToDecimal(b1);
            long b2_10 = StringToDecimal(b2);
            long result = b1_10 - b2_10;
            return DecimalToBinaryString(result);
        }

        public static string Multiply(string b1, string b2)
        {
            long b1_10 = StringToDecimal(b1);
            long b2_10 = StringToDecimal(b2);
            long result = b1_10 * b2_10;
            return DecimalToBinaryString(result);
        }

        public static string Divide(string b1, string b2)
        {
            long b1_10 = StringToDecimal(b1);
            long b2_10 = StringToDecimal(b2);
            long result = 0;
            string r = null;
            if (b2_10 != 0)
            {
                result = b1_10 / b2_10;
                r = DecimalToBinaryString(result);
            }
            else r = "Math Error!";

            return r;
        }

        public static string ShiftRight(string b)
        {
            long b_10 = StringToDecimal(b);
            long result = (b_10 >> 1);
            return DecimalToBinaryString(result);
        }

        public static string ShiftLeft(string b)
        {
            long b_10 = StringToDecimal(b);
            long result = (b_10 << 1);
            return DecimalToBinaryString(result);
        }

        public static string NotGate(string b)
        {
            long b_10 = StringToDecimal(b);
            long result = ~b_10;
            return DecimalToBinaryString(result);
        }

        public static string AndGate(string b1, string b2)
        {
            long b1_10 = StringToDecimal(b1);
            long b2_10 = StringToDecimal(b2);
            long result = (b1_10 & b2_10);
            return DecimalToBinaryString(result);
        }

        public static string OrGate(string b1, string b2)
        {
            long b1_10 = StringToDecimal(b1);
            long b2_10 = StringToDecimal(b2);
            long result = (b1_10 | b2_10);
            return DecimalToBinaryString(result);
        }

        public static string XorGate(string b1, string b2)
        {
            long b1_10 = StringToDecimal(b1);
            long b2_10 = StringToDecimal(b2);
            long result = (b1_10 ^ b2_10);
            return DecimalToBinaryString(result);
        }

        public static string TwoComplement(string b)
        {
            long b_10 = StringToDecimal(b);
            string not_b = NotGate(b);
            string result = Add(b, "1");
            return result;
        }
    }
}
