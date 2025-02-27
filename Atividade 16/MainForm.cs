/*
 * Created by SharpDevelop.
 * User: Matheus
 * Date: 24/02/2025
 * Time: 21:45
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Atividade_16
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Label2Click(object sender, EventArgs e)
		{
	
		}
		void Label4Click(object sender, EventArgs e)
		{
	
		}
		private void btnOk_Click(object sender, EventArgs e)
			{
			    // Texto digitado
			    string texto = txtTexto.Text;
			    
			    // 1) Total de Caracteres
			    txtTotalCaracteres.Text = texto.Length.ToString();
			    
			    // 2) Remove espaços antes e depois
			    txtRemoveEspacos.Text = texto.Trim();
			    
			    // 3) Maiúscula
			    txtMaiuscula.Text = texto.ToUpper();
			    
			    // 4) Minúscula
			    txtMinuscula.Text = texto.ToLower();
			
			    // 5) Extrair texto usando 'Início' e 'Fim' (opcional)
			    if (!string.IsNullOrEmpty(txtInicio.Text) && !string.IsNullOrEmpty(txtFim.Text))
			    {
			        int inicio = int.Parse(txtInicio.Text);
			        int fim = int.Parse(txtFim.Text);
			
			        // Verifica se os índices são válidos
			        if (inicio >= 0 && fim <= texto.Length && fim > inicio)
			        {
			            string sub = texto.Substring(inicio, fim - inicio);
			            txtExtracao.Text = sub;
			        }
			        else
			        {
			            txtExtracao.Text = "Índices inválidos!";
			        }
			    }
			}

		private void btnAlterar_Click(object sender, EventArgs e)
			{
			    string original = txtTexto.Text;
			    string novoTrecho = txtSubstituir.Text;
			    
			    // Exemplo: substitui TODAS as ocorrências da palavra "texto" pelo valor em novoTrecho
			    // Ajuste conforme a lógica que você desejar
			    string resultado = original.Replace("texto", novoTrecho);
			    
			    // Exibe no TextBox de resultado
			    txtSubstituido.Text = resultado;
			}
		private void btnDividir_Click(object sender, EventArgs e)
			{
			    string frase = txtFrase.Text;
			    
			    // Divide a frase em palavras usando espaço como separador
			    string[] partes = frase.Split(' ');
			    
			    // Limpa o TextBox multiline antes de mostrar o resultado
			    txtResultado.Clear();
			    
			    // Exibe cada palavra em uma nova linha
			    foreach (string p in partes)
			    {
			        txtResultado.AppendText(p + Environment.NewLine);
			    }
			}
		void MainFormLoad(object sender, EventArgs e)
		{
	
		}
	}
}
