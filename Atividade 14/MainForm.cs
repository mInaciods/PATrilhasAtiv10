/*
 * Created by SharpDevelop.
 * User: Matheus
 * Date: 23/02/2025
 * Time: 21:57
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Atividade_14
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            
            // Preenche o ComboBox com opções de cores
            comboBox1.Items.Add("Vermelho");
            comboBox1.Items.Add("Azul");
            comboBox1.Items.Add("Verde");
            comboBox1.Items.Add("Amarelo");
            comboBox1.Items.Add("Branco");
            comboBox1.Items.Add("Preto");
            
            // Define um item padrão
            comboBox1.SelectedIndex = 0;
        }
        
        // Evento acionado quando um item é selecionado no ComboBox
        void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
        {
            // Altera a cor de fundo do formulário com base na seleção do usuário
            switch (comboBox1.SelectedItem.ToString())
            {
                case "Vermelho":
                    this.BackColor = Color.Red;
                    break;
                case "Azul":
                    this.BackColor = Color.Blue;
                    break;
                case "Verde":
                    this.BackColor = Color.Green;
                    break;
                case "Amarelo":
                    this.BackColor = Color.Yellow;
                    break;
                case "Branco":
                    this.BackColor = Color.White;
                    break;
                case "Preto":
                    this.BackColor = Color.Black;
                    break;
                default:
                    this.BackColor = SystemColors.Control; // Cor padrão
                    break;
            }
        }
    }
}
