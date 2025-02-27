/*
 * Created by SharpDevelop.
 * User: Matheus
 * Date: 26/02/2025
 * Time: 22:23
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Atividade_21
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class FormCurso : Form
    {
        // DataTable para armazenar os dados em memória
       

        public FormCurso()
        {
           
            
            
        }

        // Evento para inserir (GRAVAR) os dados no DataGridView (DataTable)
        private void btnGravar_Click(object sender, EventArgs e)
        {
            
        }

        // Evento que ocorre ao clicar em uma célula do DataGridView
        // Carrega os dados nos TextBoxes
        private void dgvCursos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se o clique foi em uma linha válida
            if (e.RowIndex >= 0)
            {
                
            }
        }

        // Evento para ALTERAR os dados da linha selecionada
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            // Verifica se há linha selecionada
            

            // Limpa os campos depois de alterar
            LimparCampos();
        }

        // Evento para EXCLUIR a linha selecionada
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            
        }

        // Evento para LIMPAR os campos (sem alterar o DataGridView)
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        // Método auxiliar para limpar os campos de texto
        private void LimparCampos()
        {
        }
    }
}

