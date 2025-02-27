/*
 * Created by SharpDevelop.
 * User: Matheus
 * Date: 23/02/2025
 * Time: 21:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Atividade_12
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
            // Obtém o valor selecionado no NumericUpDown e exibe no MessageBox
            MessageBox.Show("Valor selecionado: " + numericUpDown1.Value.ToString(), "Valor Selecionado");
        }
    }
}
