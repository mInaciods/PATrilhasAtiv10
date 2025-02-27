/*
 * Created by SharpDevelop.
 * User: Matheus
 * Date: 23/02/2025
 * Time: 21:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Atividade_04
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            
            // Preenche a lista suspensa com algumas opções
            comboBox1.Items.Add("Opção 1");
            comboBox1.Items.Add("Opção 2");
            comboBox1.Items.Add("Opção 3");
            
            // Define a primeira opção como padrão (opcional)
            comboBox1.SelectedIndex = 0;
        }
        
        // Evento associado ao clique do botão
        void Button1Click(object sender, EventArgs e)
        {
            // Verifica se há um item selecionado
            if (comboBox1.SelectedItem != null)
            {
                MessageBox.Show("Opção selecionada: " + comboBox1.SelectedItem.ToString(), "Selecionado");
            }
            else
            {
                MessageBox.Show("Nenhuma opção selecionada.", "Atenção");
            }
        }
    }
}
