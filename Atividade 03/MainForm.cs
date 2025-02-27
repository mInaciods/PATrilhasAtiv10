/*
 * Created by SharpDevelop.
 * User: Matheus
 * Date: 23/02/2025
 * Time: 21:24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Atividade_03
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
        
        // Este método é chamado quando o botão é clicado
        void Button1Click(object sender, EventArgs e)
        {
            // Exibe um MessageBox com o texto digitado na caixa de texto (textBox1)
            MessageBox.Show(textBox1.Text, "Mensagem Digitada");
        }
    }
}