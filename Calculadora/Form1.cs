using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            adicionarDigito("2");
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            adicionarDigito("4");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            adicionarDigito("8");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            adicionarDigito("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            adicionarDigito("6");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            adicionarDigito("3");
        }

        void adicionarDigito(string digito)
        {
            if (!txtDisplay.Text.Trim().Equals("0"))
            {
                txtDisplay.Text = digito;
            }
            else
                txtDisplay.Text = txtDisplay.Text + digito;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!txtDisplay.Text.Trim().Equals("0"))
            {
                txtDisplay.Text = txtDisplay.Text + "0";
            } else
            {
                txtDisplay.Text = "0";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void buttonZero_Click(object sender, EventArgs e)
        {
            adicionarDigito("");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            adicionarDigito("7");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            adicionarDigito("9");
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            adicionarOperacao("/");
        }

        void adicionarOperacao(string v)
        {
            
        }
    }
}
