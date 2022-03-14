using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_Bicudo
{
    public partial class frmCurso : Form
    {
        public float a = 0;
        public float b = 0;
        public float resultado;
        public frmCurso()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }


        private void somar_Click(object sender, EventArgs e)
        {
            if(valor1.Text == "" || valor2.Text == "")
            {
                MessageBox.Show("Corrija os valores");
                valor1.Focus();
                return;
            }
            else
            {
                a = Convert.ToSingle(valor1.Text); b = Convert.ToSingle(valor2.Text);
                resultado = a + b;
                Historico.Text += valor1.Text + "+" + valor2.Text + "=" + resultado.ToString("F") + ", ";
                valor1.Text = resultado.ToString("F"); valor2.Text = "0";
                ResultadoValor.Text = resultado.ToString("F");
                return;
            }
        }

        private void Subtrair_Click(object sender, EventArgs e)
        {
            if (valor1.Text == "" || valor2.Text == "")
            {
                MessageBox.Show("Corrija os valores");
                valor1.Focus();
                return;
            }
            else
            {
                a = Convert.ToSingle(valor1.Text); b = Convert.ToSingle(valor2.Text);
                resultado = a - b;
                Historico.Text += valor1.Text + "-" + valor2.Text + "=" + resultado.ToString("F") + ", ";
                valor1.Text = resultado.ToString("F"); valor2.Text = "0";
                ResultadoValor.Text = resultado.ToString("F");
                return;
            }
        }

        private void vezes_Click(object sender, EventArgs e)
        {
            if (valor1.Text == "" || valor2.Text == "")
            {
                MessageBox.Show("Corrija os valores");
                valor1.Focus();
                return;
            }
            else
            {
                a = Convert.ToSingle(valor1.Text); b = Convert.ToSingle(valor2.Text);
                resultado = a * b;
                Historico.Text += valor1.Text + "x" + valor2.Text + "=" + resultado.ToString("F") + ", ";
                valor1.Text = resultado.ToString("F"); valor2.Text = "0";
                ResultadoValor.Text = resultado.ToString("F");
                return;
            }
        }

        private void Dividir_Click(object sender, EventArgs e)
        {
            if (valor1.Text == "" || valor2.Text == "")
            {
                MessageBox.Show("Corrija os valores");
                valor1.Focus();
                return;
            }
            else
            {
                a = Convert.ToSingle(valor1.Text); b = Convert.ToSingle(valor2.Text);
                resultado = a / b;
                Historico.Text += valor1.Text + "/" + valor2.Text + "=" + resultado.ToString("F") + ", ";
                valor1.Text = resultado.ToString("F"); valor2.Text = "0";
                ResultadoValor.Text = resultado.ToString("F");
                return;
            }
        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            Historico.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            valor2.Text = ""; valor1.Text = "";
            ResultadoValor.Text = "0";
        }
    }
}