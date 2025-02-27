/*
 * Created by SharpDevelop.
 * User: Matheus
 * Date: 23/02/2025
 * Time: 21:51
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Atividade_11
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            
            // Atualiza o texto do botão com base no estado inicial do CheckBox
            UpdateButtonText();
        }
        
        // Método para atualizar o texto do botão conforme o estado do CheckBox
        void UpdateButtonText()
        {
            if(checkBox1.Checked)
                button1.Text = "Desmarcar";
            else
                button1.Text = "Marcar";
        }
        
        // Evento disparado quando o estado do CheckBox é alterado
        void CheckBox1CheckedChanged(object sender, EventArgs e)
        {
            UpdateButtonText();
        }
    }
}
