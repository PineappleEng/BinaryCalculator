using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinaryCalculator
{
    public partial class Form1 : Form
    {
        string numeroBinario = "";
        
        public Form1()
        {
            InitializeComponent();
        }

        private void layout_Click(object sender, EventArgs e)
        {

        }

        private void label_Change(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(numeroBinario)) 
            {
                hexLabel.Text = "0";
                decLabel.Text = "0";
                octLabel.Text = "0";

                return;
            }
           int decim= Convert.ToInt32(numeroBinario, 2);

            decLabel.Text = decim.ToString();
            octLabel.Text = Convert.ToString(decim,8);
            hexLabel.Text = Convert.ToString(decim,16).ToUpper();
        }

        private string separa_Digitos(string binario)
        {
            for (int i = binario.Length - 4; i > 0; i-=4 )
            {
                binario = binario.Insert(i, " ");

            }
            return binario;
        }

        private void buton0_Click(object sender, EventArgs e)
        {
            if (numeroBinario.Length > 0)
            {
                numeroBinario += 0;
                layout.Text = separa_Digitos(numeroBinario);
            }
        } 

        private void buton1_Click(object sender, EventArgs e)
        {
            numeroBinario += 1;
            layout.Text = separa_Digitos(numeroBinario);
        }

        private void ereaseAll_Click(object sender, EventArgs e)
        {
            numeroBinario = "";
            layout.Text = numeroBinario ;
        }

        private void ereaseDigit_Click(object sender, EventArgs e)
        {
            if(numeroBinario.Length > 0)
            {
                numeroBinario = numeroBinario.Substring(0, numeroBinario.Length - 1);
                layout.Text = separa_Digitos(numeroBinario);

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       
    }
}
