/*
 * Created by SharpDevelop.
 * User: Matheus
 * Date: 23/02/2025
 * Time: 21:41
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Atividade_06
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
        
        // Evento associado ao clique do botão
        void Button1Click(object sender, EventArgs e)
        {
            // Verifica se o TextBox está vazio ou contém somente espaços em branco
            if(string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Erro: O campo está vazio!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Sucesso: O campo não está vazio!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
