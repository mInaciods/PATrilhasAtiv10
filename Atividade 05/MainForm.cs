/*
 * Created by SharpDevelop.
 * User: Matheus
 * Date: 23/02/2025
 * Time: 21:37
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Atividade_05
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
        
        // Evento para aumentar o tamanho da fonte do label1
        void btnAumentar_Click(object sender, EventArgs e)
        {
            // Aumenta o tamanho da fonte em 2 pontos
            label1.Font = new Font(label1.Font.FontFamily, label1.Font.Size + 2, label1.Font.Style);
        }
        
        // Evento para diminuir o tamanho da fonte do label1
        void btnDiminuir_Click(object sender, EventArgs e)
        {
            // Diminui o tamanho da fonte em 2 pontos (evita deixar o texto muito pequeno)
            float novoTamanho = label1.Font.Size - 2;
            if(novoTamanho < 2)
                novoTamanho = 2;
            label1.Font = new Font(label1.Font.FontFamily, novoTamanho, label1.Font.Style);
        }
		void Button2Click(object sender, EventArgs e)
		{
	
		}
		void Label1Click(object sender, EventArgs e)
		{
	
		}
    }
}
