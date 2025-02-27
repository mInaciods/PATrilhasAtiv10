/*
 * Created by SharpDevelop.
 * User: Matheus
 * Date: 25/02/2025
 * Time: 21:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Atividade_18
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent(); // Gerado automaticamente pelo Designer
        }

        // Evento do botão Calcular
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Tenta converter cada TextBox em número (double)
            double nota1, nota2, nota3, nota4;
            bool n1Valida = double.TryParse(textBoxNota1.Text, out nota1);
            bool n2Valida = double.TryParse(textBoxNota2.Text, out nota2);
            bool n3Valida = double.TryParse(textBoxNota3.Text, out nota3);
            bool n4Valida = double.TryParse(textBoxNota4.Text, out nota4);

            if (n1Valida && n2Valida && n3Valida && n4Valida)
            {
                // Calcula a maior e menor nota
                double maior = Math.Max(nota1, Math.Max(nota2, Math.Max(nota3, nota4)));
                double menor = Math.Min(nota1, Math.Min(nota2, Math.Min(nota3, nota4)));

                // Calcula a média
                double media = (nota1 + nota2 + nota3 + nota4) / 4.0;

                // Exibe os resultados
                textBoxMaior.Text = maior.ToString("F2");
                textBoxMenor.Text = menor.ToString("F2");
                textBoxMedia.Text = media.ToString("F2");
            }
            else
            {
                MessageBox.Show("Digite valores numéricos válidos para todas as notas.");
            }
        }

        // Evento do botão Limpar
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            // Limpa as caixas de texto
            textBoxNota1.Clear();
            textBoxNota2.Clear();
            textBoxNota3.Clear();
            textBoxNota4.Clear();
            textBoxMaior.Clear();
            textBoxMenor.Clear();
            textBoxMedia.Clear();
        }

        // Evento do botão Sair
        private void btnSair_Click(object sender, EventArgs e)
        {
            // Fecha o formulário
            this.Close();
        }
    }
}
