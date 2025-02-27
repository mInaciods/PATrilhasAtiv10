/*
 * Created by SharpDevelop.
 * User: Matheus
 * Date: 23/02/2025
 * Time: 21:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Atividade_08
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            
            // Preenche o ListBox com alguns itens
            listBox1.Items.Add("Item 1");
            listBox1.Items.Add("Item 2");
            listBox1.Items.Add("Item 3");
            listBox1.Items.Add("Item 4");
        }
        
        // Evento associado ao clique do botão para exibir o item selecionado
        void Button1Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedItem != null)
            {
                MessageBox.Show("Item selecionado: " + listBox1.SelectedItem.ToString(), "Seleção");
            }
            else
            {
                MessageBox.Show("Nenhum item selecionado.", "Atenção");
            }
        }
    }
}