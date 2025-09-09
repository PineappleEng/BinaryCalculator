using System;
using System.Windows.Forms;

namespace BinaryCalculator
{
    public partial class BinaryCalcForm : Form
    {
        private static long StringToDecimal(string b)
        {
            return Convert.ToInt64(b, 2);
        }

        private static string DecimalToBinaryString(long b)
        {
            return Convert.ToString(b, 2);
        }

        private static string Add(string b1, string b2)
        {
            long result = StringToDecimal(b1) + StringToDecimal(b2);
            return DecimalToBinaryString(result);
        }

        private static string Subtract(string b1, string b2)
        {
            long result = StringToDecimal(b1) - StringToDecimal(b2);
            return DecimalToBinaryString(result);
        }

        private static string Multiply(string b1, string b2)
        {
            long result = StringToDecimal(b1) * StringToDecimal(b2);
            return DecimalToBinaryString(result);
        }

        private static string Divide(string b1, string b2)
        {
            long b1_10 = StringToDecimal(b1);
            long b2_10 = StringToDecimal(b2);

            if (b2_10 != 0)
                return DecimalToBinaryString(b1_10 / b2_10);
            return "Math Error!";
        }

        private static string ShiftRight(string b)
        {
            long result = (StringToDecimal(b) >> 1);
            return DecimalToBinaryString(result);
        }

        private static string ShiftLeft(string b)
        {
            long result = (StringToDecimal(b) << 1);
            return DecimalToBinaryString(result);
        }

        private static string Not(string b)
        {
            long bit_mask = (1L << b.Length) - 1L;
            long result = ~StringToDecimal(b) & bit_mask;
            return DecimalToBinaryString(result);
        }

        private static string And(string b1, string b2)
        {
            long result = (StringToDecimal(b1) & StringToDecimal(b2));
            return DecimalToBinaryString(result);
        }

        private static string Or(string b1, string b2)
        {
            long result = (StringToDecimal(b1) | StringToDecimal(b2));
            return DecimalToBinaryString(result);
        }

        private static string Xor(string b1, string b2)
        {
            long result = (StringToDecimal(b1) ^ StringToDecimal(b2));
            return DecimalToBinaryString(result);
        }

        private static string TwoComplement(string b)
        {
            return Add(Not(b), "1");
        }
    }
}
