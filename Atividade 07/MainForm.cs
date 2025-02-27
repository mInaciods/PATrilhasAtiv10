/*
 * Created by SharpDevelop.
 * User: Matheus
 * Date: 23/02/2025
 * Time: 21:43
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Atividade_07
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
        
        // Evento associado ao clique do botão para carregar a imagem
        void Button1Click(object sender, EventArgs e)
        {
            // Cria uma instância do OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();
            // Define o filtro para arquivos de imagem
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            
            // Exibe o diálogo e verifica se o usuário selecionou um arquivo
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Carrega a imagem selecionada e exibe-a no PictureBox
                pictureBox1.Image = new Bitmap(openFileDialog.FileName);
                // Opcional: ajusta o tamanho da imagem para caber no PictureBox
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}