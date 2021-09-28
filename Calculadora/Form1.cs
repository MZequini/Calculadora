using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora {
    public partial class Calculadora : Form {
        public Calculadora() {
            InitializeComponent();
        }

        private void txt_Num1_TextChanged(object sender, EventArgs e) {

        }

        private void txt_Resultado_TextChanged(object sender, EventArgs e) {

        }

        private void rbtn_Soma_CheckedChanged(object sender, EventArgs e) {
            {
                int Valor1, Valor2, resultado;
                Valor1 = int.Parse(txt_Num1.Text);
                Valor2 = int.Parse(txt_Num2.Text);
                resultado = Valor1 + Valor2;
                txt_Resultado.Text = resultado.ToString();
            }
        }

        private void rbtn_Subtracao_CheckedChanged(object sender, EventArgs e) {

            int Valor1, Valor2, resultado;
            Valor1 = int.Parse(txt_Num1.Text);
            Valor2 = int.Parse(txt_Num2.Text);
            resultado = Valor1 - Valor2;
            txt_Resultado.Text = resultado.ToString();
        }

        private void rbtn_Multiplicacao_CheckedChanged(object sender, EventArgs e) {
            int Valor1, Valor2, resultado;
            Valor1 = int.Parse(txt_Num1.Text);
            Valor2 = int.Parse(txt_Num2.Text);
            resultado = Valor1 * Valor2;
            txt_Resultado.Text = resultado.ToString();
        }

        private void rbtn_Divisao_CheckedChanged(object sender, EventArgs e) {
            int Valor1, Valor2, resultado;
            Valor1 = int.Parse(txt_Num1.Text);
            Valor2 = int.Parse(txt_Num2.Text);

            if (Valor2 != 0) {
                resultado = Valor1 / Valor2;
                txt_Resultado.Text = resultado.ToString();

            } else
                MessageBox.Show("É impossível dividir um número por 0.");

            
        }
    }
}

    
            
        
       
