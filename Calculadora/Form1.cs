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
        private double numero1;
        private double numero2;
        private string operacao;
        private double resultado;
        private Boolean pressionouIgual;

        private void limparCampo()
        {
            numero1 = 0;
            numero2 = 0;
            operacao = string.Empty;
            resultado = 0;
            pressionouIgual = false;
            txtDisplay.Clear();
        }

        private void adicionarOperacao(string caractere)
        {
            if (!txtDisplay.Text.Trim().Equals(string.Empty))
            {
                numero1 = Convert.ToDouble(txtDisplay.Text.Trim());
                txtDisplay.Clear();
                operacao = caractere;
            }
        }

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
                txtDisplay.Text = txtDisplay.Text + digito;
            }
            else
                txtDisplay.Text = digito;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adicionarDigito("1");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            limparCampo();
        }


        private void buttonZero_Click(object sender, EventArgs e)
        {
            adicionarDigito("0");
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

        private void buttonIgual_Click(object sender, EventArgs e)
        {
            if (!txtDisplay.Text.Trim().Equals(String.Empty))
            {
                numero2 = Convert.ToDouble(txtDisplay.Text.Trim());
                Calcular();
                pressionouIgual = true;
            }
        }

        private void Calcular()
        {
            switch (operacao)
            {
                case "/":
                    if (numero2 == 0)
                    {
                        MessageBox.Show("IMPOSSÍVEL DIVISÃO POR 0 !", "AVISO DO SISTEMA", MessageBoxButtons.OK);
                        break;
                    }
                    resultado = numero1 / numero2;
                    break;

                case "+":
                    resultado = numero1 + numero2;
                    break;
                case "-":
                    resultado = numero1 - numero2;
                    break;
                case "*":
                    resultado = numero1 * numero2;
                    break;

                case "^2":
                    resultado = numero1 * numero1;
                    break;

                case "^":
                    resultado = Math.Pow(numero1, numero2);
                    break;
            }
            txtDisplay.Text = resultado.ToString();
        }

        private void buttonSoma_Click(object sender, EventArgs e)
        {
            adicionarOperacao("+");
        }

        private void buttonSubtracao_Click(object sender, EventArgs e)
        {
            adicionarOperacao("-");
        }

        private void buttonMultiplicacao_Click(object sender, EventArgs e)
        {
            adicionarOperacao("*");
        }

        private void buttonPonto_Click(object sender, EventArgs e)
        {
            if (pressionouIgual)
            {
                limparCampo();
            }
            if (txtDisplay.Text.Trim().Equals(String.Empty))
            {
                txtDisplay.Text += "0,";
            }
            if (txtDisplay.Text.Trim().Contains(",")) return;
            txtDisplay.Text += ",";
        }

        private void buttonQuadrado_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToDouble(txtDisplay.Text.Trim());
            resultado = numero1 * numero1;
            txtDisplay.Text = resultado.ToString();
            pressionouIgual = true;
        }

        private void buttonPotencia_Click(object sender, EventArgs e)
        {
            adicionarOperacao("^");
        }

        private void buttonRaizQuadrada_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToDouble(txtDisplay.Text.Trim());
            resultado = Math.Sqrt(numero1);
            txtDisplay.Text = resultado.ToString();
            pressionouIgual = true;
        }

        private void buttonInverso_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToDouble(txtDisplay.Text.Trim());
            resultado = 1 / numero1;
            txtDisplay.Text = resultado.ToString();
            pressionouIgual = true;
        }


        private void buttonC_Click(object sender, EventArgs e)
        {
            limparCampo();
        }
    }
}
