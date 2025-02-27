/*
 * Created by SharpDevelop.
 * User: Matheus
 * Date: 23/02/2025
 * Time: 21:09
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Atividade_02
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnVermelho;
		private System.Windows.Forms.Button btnAzul;
		
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
			this.btnVermelho = new System.Windows.Forms.Button();
			this.btnAzul = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnVermelho
			// 
			this.btnVermelho.Location = new System.Drawing.Point(27, 121);
			this.btnVermelho.Name = "btnVermelho";
			this.btnVermelho.Size = new System.Drawing.Size(75, 23);
			this.btnVermelho.TabIndex = 0;
			this.btnVermelho.Text = "Vermelho";
			this.btnVermelho.UseVisualStyleBackColor = true;
			this.btnVermelho.Click += new System.EventHandler(this.Button1Click);
			// 
			// btnAzul
			// 
			this.btnAzul.Location = new System.Drawing.Point(177, 120);
			this.btnAzul.Name = "btnAzul";
			this.btnAzul.Size = new System.Drawing.Size(75, 23);
			this.btnAzul.TabIndex = 1;
			this.btnAzul.Text = "Azul";
			this.btnAzul.UseVisualStyleBackColor = true;
			this.btnAzul.Click += new System.EventHandler(this.BtnAzulClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.btnAzul);
			this.Controls.Add(this.btnVermelho);
			this.Name = "MainForm";
			this.Text = "Atividade 02";
			this.ResumeLayout(false);

		}
	}
}
