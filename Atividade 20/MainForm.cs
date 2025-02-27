/*
 * Created by SharpDevelop.
 * User: Matheus
 * Date: 25/02/2025
 * Time: 21:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Atividade_20
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // Evento do botão Calcular
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Tentar converter o peso e a altura
            double peso, altura;
            bool pesoValido = double.TryParse(txtPeso.Text, out peso);
            bool alturaValida = double.TryParse(txtAltura.Text, out altura);

            if (!pesoValido || !alturaValida || peso <= 0 || altura <= 0)
            {
                MessageBox.Show("Digite valores numéricos válidos e maiores que zero para Peso e Altura.");
                return;
            }

            // Cálculo do IMC: peso / (altura^2)
            double imc = peso / (altura * altura);

            // Exibir o valor do IMC formatado
            txtIMC.Text = imc.ToString("F2");

            // Determinar a classificação
            // Referência:
            // < 18.5        => Abaixo do peso
            // 18.5 - 24.9   => Peso normal
            // 25 - 29.9     => Pré-obesidade
            // 30 - 34.9     => Obesidade Grau 1
            // 35 - 39.9     => Obesidade Grau 2
            // >= 40         => Obesidade Grau 3

            string classificacao;
            if (imc < 18.5)
                classificacao = "Abaixo do peso";
            else if (imc < 25)
                classificacao = "Peso normal";
            else if (imc < 30)
                classificacao = "Pré-obesidade";
            else if (imc < 35)
                classificacao = "Obesidade Grau 1";
            else if (imc < 40)
                classificacao = "Obesidade Grau 2";
            else
                classificacao = "Obesidade Grau 3";

            txtStatus.Text = classificacao;
        }
    }
}