using System;
using System.Security.AccessControl;
using System.Windows.Forms;

namespace BinaryCalculator
{
    public enum Operation { None, Sum, Subt, Mult, Div, And, Or, Xor }

    public partial class BinaryCalcForm : Form
    {
        string display_num;
        string curr_result;
        Operation last_op;

        static string kZero = "0";
        static string kEmpty_str = "";

        public BinaryCalcForm()
        {
            InitializeComponent();
            ResetToDefault();
        }

        public void ResetToDefault()
        {
            display_num       = kEmpty_str;
            curr_result       = kEmpty_str;
            calc_display.Text = kZero;
            octLabel.Text     = kZero;
            decLabel.Text     = kZero;
            hexLabel.Text     = kZero;
            last_op           = Operation.None;
        }

        private void label_Change(object sender, EventArgs e)
        {
            if (display_num != kEmpty_str)
            {
                octLabel.Text = Convert.ToString(Convert.ToInt64(display_num, 2), 8);
                decLabel.Text = Convert.ToString(Convert.ToInt64(display_num, 2), 10);
                hexLabel.Text = Convert.ToString(Convert.ToInt64(display_num, 2), 16).ToUpper();
            }
        }

        private string Stylize(string num)
        {
            int pad = (4 - num.Length % 4) % 4;
            string result = num.PadLeft(num.Length + pad, '0');

            for (int i = 4, c = 0; i + c < result.Length; i += 5, c++)
                result = result.Insert(i + c, " ");

            return result;
        }

        private void buton0_Click(object sender, EventArgs e)
        {
            if (calc_display.Text == kZero) return;
            if (display_num == kEmpty_str)
            {
                calc_display.Text = kZero;
                display_num += '0';
            }
            else
            {
                display_num += '0';
                calc_display.Text = Stylize(display_num);
            }

            this.ActiveControl = null;
        }

        private void buton1_Click(object sender, EventArgs e)
        {
            display_num += '1';
            calc_display.Text = Stylize(display_num);

            this.ActiveControl = null;
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            ResetToDefault();

            this.ActiveControl = null;
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            if (display_num.Length == 1) ResetToDefault();
            else if (display_num.Length > 1)
            {
                display_num = display_num.Substring(0, display_num.Length - 1);
                calc_display.Text = Stylize(display_num);
            }

            this.ActiveControl = null;
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (curr_result == kEmpty_str)
                curr_result = display_num;
            else if (display_num != kEmpty_str)
            {
                curr_result = Add(curr_result, display_num);
                calc_display.Text = Stylize(curr_result);
            }
            display_num = kEmpty_str;
            last_op = Operation.Sum;

            this.ActiveControl = null;
        }

        private void substract_Click(object sender, EventArgs e)
        {
            if (curr_result == kEmpty_str)
                curr_result = display_num;
            else if (display_num != kEmpty_str)
            {
                curr_result = Subtract(curr_result, display_num);
                calc_display.Text = Stylize(curr_result);
            }
            display_num = kEmpty_str;
            last_op = Operation.Subt;

            this.ActiveControl = null;
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            if (curr_result == kEmpty_str)            
                curr_result = display_num;
            else if (display_num != kEmpty_str)
            {
                curr_result = Multiply(curr_result, display_num);
                calc_display.Text = Stylize(curr_result);
            }
            display_num = kEmpty_str;
            last_op = Operation.Mult;

            this.ActiveControl = null;
        }

        private void divide_Click(object sender, EventArgs e)
        {
            if (curr_result == kEmpty_str)
                curr_result = display_num;
            else if (display_num != kEmpty_str)
            {
                curr_result = Divide(curr_result, display_num);
                if (curr_result == "Math Error!")
                {
                    calc_display.Text = curr_result;
                    curr_result = kEmpty_str;
                }
                else
                    calc_display.Text = Stylize(curr_result);
            }
            display_num = kEmpty_str;
            last_op = Operation.Div;

            this.ActiveControl = null;
        }

        private void bitwise_not_Click(object sender, EventArgs e)
        {
            if (display_num != kEmpty_str)
            {
                display_num = Not(display_num);
                calc_display.Text = Stylize(display_num);
            }
            else
            {
                display_num = "1";
                calc_display.Text = Stylize(display_num);
            }
        }

        private void bitwise_and_Click(object sender, EventArgs e)
        {
            if (curr_result == kEmpty_str)
                curr_result = display_num;
            else if (display_num != kEmpty_str)
            {
                curr_result = And(curr_result, display_num);
                calc_display.Text = Stylize(curr_result);
            }
            display_num = kEmpty_str;
            last_op = Operation.And;

            this.ActiveControl = null;
        }

        private void bitwise_or_Click(object sender, EventArgs e)
        {
            if (curr_result == kEmpty_str)
                curr_result = display_num;
            else if (display_num != kEmpty_str)
            {
                curr_result = Or(curr_result, display_num);
                calc_display.Text = Stylize(curr_result);
            }
            display_num = kEmpty_str;
            last_op = Operation.Or;

            this.ActiveControl = null;
        }

        private void bitwise_xor_Click(object sender, EventArgs e)
        {
            if (curr_result == kEmpty_str)
                curr_result = display_num;
            else if (display_num != kEmpty_str)
            {
                curr_result = Xor(curr_result, display_num);
                calc_display.Text = Stylize(curr_result);
            }
            display_num = kEmpty_str;
            last_op = Operation.Xor;

            this.ActiveControl = null;
        }

        private void two_complement_Click(object sender, EventArgs e)
        {
            if (display_num != kEmpty_str)
            {
                display_num = TwoComplement(display_num);
                calc_display.Text = Stylize(display_num);
            }
        }

        private void shift_left_Click(object sender, EventArgs e)
        {
            if (display_num != kEmpty_str)
            {
                display_num = ShiftLeft(display_num);
                calc_display.Text = Stylize(display_num);
            }
        }

        private void shift_right_Click(object sender, EventArgs e)
        {
            if (display_num != kEmpty_str)
            {
                display_num = ShiftRight(display_num);
                calc_display.Text = Stylize(display_num);
            }
        }

        private void equal_Click(object sender, EventArgs e)
        {
            if (curr_result != kEmpty_str)
            {
                switch (last_op)
                {
                    case Operation.Sum:
                        calc_display.Text = Stylize(Add(curr_result, display_num));
                        curr_result = kEmpty_str;
                        break;
                    case Operation.Subt:
                        calc_display.Text = Stylize(Subtract(curr_result, display_num));
                        curr_result = kEmpty_str;
                        break;
                    case Operation.Mult:
                        calc_display.Text = Stylize(Multiply(curr_result, display_num));
                        curr_result = kEmpty_str;
                        break;
                    case Operation.Div:
                        curr_result = Divide(curr_result, display_num);
                        if (curr_result == "Math Error!")
                            calc_display.Text = curr_result;
                        else
                            calc_display.Text = Stylize(curr_result);
                        curr_result = kEmpty_str;
                        break;
                    case Operation.And:
                        calc_display.Text = Stylize(And(curr_result, display_num));
                        curr_result = kEmpty_str;
                        break;
                    case Operation.Or:
                        calc_display.Text = Stylize(Or(curr_result, display_num));
                        curr_result = kEmpty_str;
                        break;
                    case Operation.Xor:
                        calc_display.Text = Stylize(Xor(curr_result, display_num));
                        curr_result = kEmpty_str;
                        break;
                }
                last_op = Operation.None;
            }

            this.ActiveControl = null;
        }
    }
}
