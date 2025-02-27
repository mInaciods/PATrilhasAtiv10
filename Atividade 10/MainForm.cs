/*
 * Created by SharpDevelop.
 * User: Matheus
 * Date: 23/02/2025
 * Time: 21:49
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Atividade_10
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
            // Formata a data selecionada no DateTimePicker
            string dataSelecionada = dateTimePicker1.Value.ToString("dd/MM/yyyy");
            MessageBox.Show("Data selecionada: " + dataSelecionada, "Data Selecionada");
        }
    }
}
