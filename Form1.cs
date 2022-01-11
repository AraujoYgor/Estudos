using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1:Form
    {
        decimal valor1, valor2 = 0;
        string operacao = "";
        public Form1()
        {
            InitializeComponent();
        }
        private void ConcatenarValor(string Vbtn)
        {
            txtResultado.Text += Vbtn;
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            ConcatenarValor("0");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            ConcatenarValor("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            ConcatenarValor("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            ConcatenarValor("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            ConcatenarValor("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            ConcatenarValor("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            ConcatenarValor("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            ConcatenarValor("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            ConcatenarValor("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            ConcatenarValor("9");
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            ConcatenarValor(".");
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            operacao = "SOMA";
            lblOperacao.Text = "+";
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            operacao = "Sub";
            lblOperacao.Text = "-";
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            operacao = "MULT";
            lblOperacao.Text = "*";
        }
        private void btnDiv_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            operacao = "DIV";
            lblOperacao.Text = "/";
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            ConcatenarValor("");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtResultado.Clear();
            lblOperacao.Text = "";
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            if(operacao == "SOMA")
            {
                txtResultado.Text = Convert.ToString(valor1 + valor2);

            }else if(operacao == "SUB")
            {
                txtResultado.Text = Convert.ToString(valor1 - valor2);
            }
            else if(operacao == "MULT")
            {
                txtResultado.Text = Convert.ToString(valor1 * valor2);
            }
            else
            {
                txtResultado.Text = Convert.ToString(valor1 / valor2);
            }
        }
    }
}
