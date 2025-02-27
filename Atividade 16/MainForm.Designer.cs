/*
 * Created by SharpDevelop.
 * User: Matheus
 * Date: 24/02/2025
 * Time: 21:45
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Atividade_16
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtTexto;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtSubstituir;
		private System.Windows.Forms.Button btnAlterar;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtFrase;
		private System.Windows.Forms.Button btnDividir;
		private System.Windows.Forms.Label lblTotalCaracteres;
		private System.Windows.Forms.TextBox lblRemoveEspacos;
		private System.Windows.Forms.Label lblMaiuscula;
		private System.Windows.Forms.Label lblMinuscula;
		private System.Windows.Forms.Label lblSubstituido;
		private System.Windows.Forms.Label lblExtracao;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtInicio;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox txtFim;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox txtResultado;
		private System.Windows.Forms.TextBox txtTotalCaracteres;
		private System.Windows.Forms.TextBox txtRemoveEspacos;
		private System.Windows.Forms.TextBox txtMaiuscula;
		private System.Windows.Forms.TextBox txtMinuscula;
		private System.Windows.Forms.TextBox txtSubstituido;
		private System.Windows.Forms.TextBox txtExtracao;
		private System.Windows.Forms.Label lbl1;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.txtTexto = new System.Windows.Forms.TextBox();
			this.btnOk = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.txtSubstituir = new System.Windows.Forms.TextBox();
			this.btnAlterar = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.txtFrase = new System.Windows.Forms.TextBox();
			this.btnDividir = new System.Windows.Forms.Button();
			this.lblTotalCaracteres = new System.Windows.Forms.Label();
			this.lbl1 = new System.Windows.Forms.Label();
			this.lblMaiuscula = new System.Windows.Forms.Label();
			this.lblMinuscula = new System.Windows.Forms.Label();
			this.lblSubstituido = new System.Windows.Forms.Label();
			this.lblExtracao = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.txtInicio = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.txtFim = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.txtResultado = new System.Windows.Forms.TextBox();
			this.txtTotalCaracteres = new System.Windows.Forms.TextBox();
			this.txtRemoveEspacos = new System.Windows.Forms.TextBox();
			this.txtMaiuscula = new System.Windows.Forms.TextBox();
			this.txtMinuscula = new System.Windows.Forms.TextBox();
			this.txtSubstituido = new System.Windows.Forms.TextBox();
			this.txtExtracao = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(105, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Digite um texto:";
			// 
			// txtTexto
			// 
			this.txtTexto.Location = new System.Drawing.Point(211, 27);
			this.txtTexto.Name = "txtTexto";
			this.txtTexto.Size = new System.Drawing.Size(100, 20);
			this.txtTexto.TabIndex = 1;
			// 
			// btnOk
			// 
			this.btnOk.Location = new System.Drawing.Point(340, 27);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(75, 23);
			this.btnOk.TabIndex = 2;
			this.btnOk.Text = "Ok";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(105, 70);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "Substituir texto por:";
			this.label2.Click += new System.EventHandler(this.Label2Click);
			// 
			// txtSubstituir
			// 
			this.txtSubstituir.Location = new System.Drawing.Point(211, 67);
			this.txtSubstituir.Name = "txtSubstituir";
			this.txtSubstituir.Size = new System.Drawing.Size(100, 20);
			this.txtSubstituir.TabIndex = 4;
			// 
			// btnAlterar
			// 
			this.btnAlterar.Location = new System.Drawing.Point(340, 70);
			this.btnAlterar.Name = "btnAlterar";
			this.btnAlterar.Size = new System.Drawing.Size(75, 23);
			this.btnAlterar.TabIndex = 5;
			this.btnAlterar.Text = "Alterar";
			this.btnAlterar.UseVisualStyleBackColor = true;
			this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(105, 106);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 6;
			this.label3.Text = "Digite uma frase:";
			// 
			// txtFrase
			// 
			this.txtFrase.Location = new System.Drawing.Point(211, 103);
			this.txtFrase.Name = "txtFrase";
			this.txtFrase.Size = new System.Drawing.Size(100, 20);
			this.txtFrase.TabIndex = 7;
			// 
			// btnDividir
			// 
			this.btnDividir.Location = new System.Drawing.Point(340, 103);
			this.btnDividir.Name = "btnDividir";
			this.btnDividir.Size = new System.Drawing.Size(75, 23);
			this.btnDividir.TabIndex = 8;
			this.btnDividir.Text = "Dividir";
			this.btnDividir.UseVisualStyleBackColor = true;
			this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
			// 
			// lblTotalCaracteres
			// 
			this.lblTotalCaracteres.Location = new System.Drawing.Point(73, 149);
			this.lblTotalCaracteres.Name = "lblTotalCaracteres";
			this.lblTotalCaracteres.Size = new System.Drawing.Size(111, 23);
			this.lblTotalCaracteres.TabIndex = 9;
			this.lblTotalCaracteres.Text = "Total de Caracteres:";
			this.lblTotalCaracteres.Click += new System.EventHandler(this.Label4Click);
			// 
			// lbl1
			// 
			this.lbl1.Location = new System.Drawing.Point(12, 188);
			this.lbl1.Name = "lbl1";
			this.lbl1.Size = new System.Drawing.Size(183, 21);
			this.lbl1.TabIndex = 10;
			this.lbl1.Text = "Remove os espaços antes e depois";
			// 
			// lblMaiuscula
			// 
			this.lblMaiuscula.Location = new System.Drawing.Point(125, 218);
			this.lblMaiuscula.Name = "lblMaiuscula";
			this.lblMaiuscula.Size = new System.Drawing.Size(59, 23);
			this.lblMaiuscula.TabIndex = 11;
			this.lblMaiuscula.Text = "Maiúscula";
			// 
			// lblMinuscula
			// 
			this.lblMinuscula.Location = new System.Drawing.Point(125, 245);
			this.lblMinuscula.Name = "lblMinuscula";
			this.lblMinuscula.Size = new System.Drawing.Size(59, 23);
			this.lblMinuscula.TabIndex = 12;
			this.lblMinuscula.Text = "Minúscula";
			// 
			// lblSubstituido
			// 
			this.lblSubstituido.Location = new System.Drawing.Point(84, 277);
			this.lblSubstituido.Name = "lblSubstituido";
			this.lblSubstituido.Size = new System.Drawing.Size(100, 23);
			this.lblSubstituido.TabIndex = 13;
			this.lblSubstituido.Text = "Substituindo o texto";
			// 
			// lblExtracao
			// 
			this.lblExtracao.Location = new System.Drawing.Point(57, 309);
			this.lblExtracao.Name = "lblExtracao";
			this.lblExtracao.Size = new System.Drawing.Size(138, 23);
			this.lblExtracao.TabIndex = 14;
			this.lblExtracao.Text = "Extrair o texto à esquerda:";
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(178, 339);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(43, 23);
			this.label10.TabIndex = 15;
			this.label10.Text = "Início";
			// 
			// txtInicio
			// 
			this.txtInicio.Location = new System.Drawing.Point(228, 339);
			this.txtInicio.Name = "txtInicio";
			this.txtInicio.Size = new System.Drawing.Size(44, 20);
			this.txtInicio.TabIndex = 16;
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(296, 339);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(37, 23);
			this.label11.TabIndex = 17;
			this.label11.Text = "Fim";
			// 
			// txtFim
			// 
			this.txtFim.Location = new System.Drawing.Point(340, 339);
			this.txtFim.Name = "txtFim";
			this.txtFim.Size = new System.Drawing.Size(52, 20);
			this.txtFim.TabIndex = 18;
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(66, 370);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(148, 23);
			this.label12.TabIndex = 19;
			this.label12.Text = "Separar a frase pelo espaço:";
			// 
			// txtResultado
			// 
			this.txtResultado.Location = new System.Drawing.Point(93, 397);
			this.txtResultado.Multiline = true;
			this.txtResultado.Name = "txtResultado";
			this.txtResultado.Size = new System.Drawing.Size(308, 77);
			this.txtResultado.TabIndex = 20;
			// 
			// txtTotalCaracteres
			// 
			this.txtTotalCaracteres.Location = new System.Drawing.Point(211, 146);
			this.txtTotalCaracteres.Name = "txtTotalCaracteres";
			this.txtTotalCaracteres.Size = new System.Drawing.Size(100, 20);
			this.txtTotalCaracteres.TabIndex = 21;
			// 
			// txtRemoveEspacos
			// 
			this.txtRemoveEspacos.Location = new System.Drawing.Point(211, 188);
			this.txtRemoveEspacos.Name = "txtRemoveEspacos";
			this.txtRemoveEspacos.Size = new System.Drawing.Size(100, 20);
			this.txtRemoveEspacos.TabIndex = 22;
			// 
			// txtMaiuscula
			// 
			this.txtMaiuscula.Location = new System.Drawing.Point(211, 220);
			this.txtMaiuscula.Name = "txtMaiuscula";
			this.txtMaiuscula.Size = new System.Drawing.Size(100, 20);
			this.txtMaiuscula.TabIndex = 23;
			// 
			// txtMinuscula
			// 
			this.txtMinuscula.Location = new System.Drawing.Point(211, 247);
			this.txtMinuscula.Name = "txtMinuscula";
			this.txtMinuscula.Size = new System.Drawing.Size(100, 20);
			this.txtMinuscula.TabIndex = 24;
			// 
			// txtSubstituido
			// 
			this.txtSubstituido.Location = new System.Drawing.Point(211, 277);
			this.txtSubstituido.Name = "txtSubstituido";
			this.txtSubstituido.Size = new System.Drawing.Size(100, 20);
			this.txtSubstituido.TabIndex = 25;
			// 
			// txtExtracao
			// 
			this.txtExtracao.Location = new System.Drawing.Point(211, 303);
			this.txtExtracao.Name = "txtExtracao";
			this.txtExtracao.Size = new System.Drawing.Size(100, 20);
			this.txtExtracao.TabIndex = 26;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(510, 486);
			this.Controls.Add(this.txtExtracao);
			this.Controls.Add(this.txtSubstituido);
			this.Controls.Add(this.txtMinuscula);
			this.Controls.Add(this.txtMaiuscula);
			this.Controls.Add(this.txtRemoveEspacos);
			this.Controls.Add(this.txtTotalCaracteres);
			this.Controls.Add(this.txtResultado);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.txtFim);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.txtInicio);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.lblExtracao);
			this.Controls.Add(this.lblSubstituido);
			this.Controls.Add(this.lblMinuscula);
			this.Controls.Add(this.lblMaiuscula);
			this.Controls.Add(this.lbl1);
			this.Controls.Add(this.lblTotalCaracteres);
			this.Controls.Add(this.btnDividir);
			this.Controls.Add(this.txtFrase);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnAlterar);
			this.Controls.Add(this.txtSubstituir);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.txtTexto);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "Atividade 16";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
