/*
 * Created by SharpDevelop.
 * User: Matheus
 * Date: 25/02/2025
 * Time: 21:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Atividade_18
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBoxNota1;
		private System.Windows.Forms.TextBox textBoxNota2;
		private System.Windows.Forms.TextBox textBoxNota3;
		private System.Windows.Forms.TextBox textBoxNota4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBoxMaior;
		private System.Windows.Forms.TextBox textBoxMenor;
		private System.Windows.Forms.TextBox textBoxMedia;
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.Button btnLimpar;
		private System.Windows.Forms.Button btnSair;
		
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
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxNota1 = new System.Windows.Forms.TextBox();
			this.textBoxNota2 = new System.Windows.Forms.TextBox();
			this.textBoxNota3 = new System.Windows.Forms.TextBox();
			this.textBoxNota4 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.textBoxMaior = new System.Windows.Forms.TextBox();
			this.textBoxMenor = new System.Windows.Forms.TextBox();
			this.textBoxMedia = new System.Windows.Forms.TextBox();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.btnLimpar = new System.Windows.Forms.Button();
			this.btnSair = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(13, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Digite a nota 1:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(13, 57);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Digite a nota 2:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(13, 84);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Digite a nota 3:";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(13, 111);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "Digite a nota 4:";
			// 
			// textBoxNota1
			// 
			this.textBoxNota1.Location = new System.Drawing.Point(108, 27);
			this.textBoxNota1.Name = "textBoxNota1";
			this.textBoxNota1.Size = new System.Drawing.Size(100, 20);
			this.textBoxNota1.TabIndex = 4;
			// 
			// textBoxNota2
			// 
			this.textBoxNota2.Location = new System.Drawing.Point(108, 54);
			this.textBoxNota2.Name = "textBoxNota2";
			this.textBoxNota2.Size = new System.Drawing.Size(100, 20);
			this.textBoxNota2.TabIndex = 5;
			// 
			// textBoxNota3
			// 
			this.textBoxNota3.Location = new System.Drawing.Point(108, 81);
			this.textBoxNota3.Name = "textBoxNota3";
			this.textBoxNota3.Size = new System.Drawing.Size(100, 20);
			this.textBoxNota3.TabIndex = 6;
			// 
			// textBoxNota4
			// 
			this.textBoxNota4.Location = new System.Drawing.Point(108, 108);
			this.textBoxNota4.Name = "textBoxNota4";
			this.textBoxNota4.Size = new System.Drawing.Size(100, 20);
			this.textBoxNota4.TabIndex = 7;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(13, 170);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 8;
			this.label5.Text = "Sua maior nota é:";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(13, 197);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 9;
			this.label6.Text = "Sua menor nota é:";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(13, 224);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 10;
			this.label7.Text = "Sua média é:";
			// 
			// textBoxMaior
			// 
			this.textBoxMaior.Location = new System.Drawing.Point(108, 168);
			this.textBoxMaior.Name = "textBoxMaior";
			this.textBoxMaior.Size = new System.Drawing.Size(100, 20);
			this.textBoxMaior.TabIndex = 11;
			// 
			// textBoxMenor
			// 
			this.textBoxMenor.Location = new System.Drawing.Point(108, 195);
			this.textBoxMenor.Name = "textBoxMenor";
			this.textBoxMenor.Size = new System.Drawing.Size(100, 20);
			this.textBoxMenor.TabIndex = 12;
			// 
			// textBoxMedia
			// 
			this.textBoxMedia.Location = new System.Drawing.Point(108, 222);
			this.textBoxMedia.Name = "textBoxMedia";
			this.textBoxMedia.Size = new System.Drawing.Size(100, 20);
			this.textBoxMedia.TabIndex = 13;
			// 
			// btnCalcular
			// 
			this.btnCalcular.Location = new System.Drawing.Point(244, 39);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(75, 23);
			this.btnCalcular.TabIndex = 14;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
			// 
			// btnLimpar
			// 
			this.btnLimpar.Location = new System.Drawing.Point(244, 76);
			this.btnLimpar.Name = "btnLimpar";
			this.btnLimpar.Size = new System.Drawing.Size(75, 23);
			this.btnLimpar.TabIndex = 15;
			this.btnLimpar.Text = "Limpar";
			this.btnLimpar.UseVisualStyleBackColor = true;
			this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
			// 
			// btnSair
			// 
			this.btnSair.Location = new System.Drawing.Point(244, 111);
			this.btnSair.Name = "btnSair";
			this.btnSair.Size = new System.Drawing.Size(75, 23);
			this.btnSair.TabIndex = 16;
			this.btnSair.Text = "Sair";
			this.btnSair.UseVisualStyleBackColor = true;
			this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(347, 316);
			this.Controls.Add(this.btnSair);
			this.Controls.Add(this.btnLimpar);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.textBoxMedia);
			this.Controls.Add(this.textBoxMenor);
			this.Controls.Add(this.textBoxMaior);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBoxNota4);
			this.Controls.Add(this.textBoxNota3);
			this.Controls.Add(this.textBoxNota2);
			this.Controls.Add(this.textBoxNota1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "Atividade 18";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
