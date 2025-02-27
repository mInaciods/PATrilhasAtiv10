/*
 * Created by SharpDevelop.
 * User: Matheus
 * Date: 26/02/2025
 * Time: 22:23
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Atividade_21
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
	
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtCodigo;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtConteudo;
		private System.Windows.Forms.TextBox txtCargaHoraria;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtValor;
		private System.Windows.Forms.DataGridView dgvCursos;
		private System.Windows.Forms.Button btnGravar;
		private System.Windows.Forms.Button btnAlterar;
		private System.Windows.Forms.Button btnExcluir;
		private System.Windows.Forms.Button btnLimpar;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.txtCodigo = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtConteudo = new System.Windows.Forms.TextBox();
			this.txtCargaHoraria = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtValor = new System.Windows.Forms.TextBox();
			this.dgvCursos = new System.Windows.Forms.DataGridView();
			this.btnGravar = new System.Windows.Forms.Button();
			this.btnAlterar = new System.Windows.Forms.Button();
			this.btnExcluir = new System.Windows.Forms.Button();
			this.btnLimpar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).BeginInit();
			
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(52, 135);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Código:";
			// 
			// txtCodigo
			// 
			this.txtCodigo.Location = new System.Drawing.Point(148, 132);
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.Size = new System.Drawing.Size(100, 20);
			this.txtCodigo.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(52, 158);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Nome:";
			// 
			// txtNome
			// 
			this.txtNome.Location = new System.Drawing.Point(148, 161);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(100, 20);
			this.txtNome.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 198);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(128, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Conteúdo Programático:";
			// 
			// txtConteudo
			// 
			this.txtConteudo.Location = new System.Drawing.Point(148, 201);
			this.txtConteudo.Multiline = true;
			this.txtConteudo.Name = "txtConteudo";
			this.txtConteudo.Size = new System.Drawing.Size(228, 78);
			this.txtConteudo.TabIndex = 5;
			// 
			// txtCargaHoraria
			// 
			this.txtCargaHoraria.Location = new System.Drawing.Point(148, 299);
			this.txtCargaHoraria.Name = "txtCargaHoraria";
			this.txtCargaHoraria.Size = new System.Drawing.Size(100, 20);
			this.txtCargaHoraria.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(40, 299);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 7;
			this.label4.Text = "Carga horária:";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(276, 298);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 8;
			this.label5.Text = "Valor:";
			// 
			// txtValor
			// 
			this.txtValor.Location = new System.Drawing.Point(336, 299);
			this.txtValor.Name = "txtValor";
			this.txtValor.Size = new System.Drawing.Size(100, 20);
			this.txtValor.TabIndex = 9;
			// 
			// dgvCursos
			// 
			this.dgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCursos.Location = new System.Drawing.Point(52, 23);
			this.dgvCursos.Name = "dgvCursos";
			this.dgvCursos.Size = new System.Drawing.Size(362, 87);
			this.dgvCursos.TabIndex = 10;
			// 
			// btnGravar
			// 
			this.btnGravar.Location = new System.Drawing.Point(40, 325);
			this.btnGravar.Name = "btnGravar";
			this.btnGravar.Size = new System.Drawing.Size(75, 23);
			this.btnGravar.TabIndex = 11;
			this.btnGravar.Text = "Gravar";
			this.btnGravar.UseVisualStyleBackColor = true;
			// 
			// btnAlterar
			// 
			this.btnAlterar.Location = new System.Drawing.Point(148, 325);
			this.btnAlterar.Name = "btnAlterar";
			this.btnAlterar.Size = new System.Drawing.Size(75, 23);
			this.btnAlterar.TabIndex = 12;
			this.btnAlterar.Text = "Alterar";
			this.btnAlterar.UseVisualStyleBackColor = true;
			// 
			// btnExcluir
			// 
			this.btnExcluir.Location = new System.Drawing.Point(253, 325);
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.Size = new System.Drawing.Size(75, 23);
			this.btnExcluir.TabIndex = 13;
			this.btnExcluir.Text = "Excluir";
			this.btnExcluir.UseVisualStyleBackColor = true;
			// 
			// btnLimpar
			// 
			this.btnLimpar.Location = new System.Drawing.Point(339, 325);
			this.btnLimpar.Name = "btnLimpar";
			this.btnLimpar.Size = new System.Drawing.Size(75, 23);
			this.btnLimpar.TabIndex = 14;
			this.btnLimpar.Text = "Limpar";
			this.btnLimpar.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			

		}
	}
}
