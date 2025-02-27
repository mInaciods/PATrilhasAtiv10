/*
 * Created by SharpDevelop.
 * User: Matheus
 * Date: 23/02/2025
 * Time: 20:58
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Atividade_01
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnMensagem;
		private System.Windows.Forms.Label lblMensagem;
		
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
			this.btnMensagem = new System.Windows.Forms.Button();
			this.lblMensagem = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnMensagem
			// 
			this.btnMensagem.Location = new System.Drawing.Point(101, 158);
			this.btnMensagem.Name = "btnMensagem";
			this.btnMensagem.Size = new System.Drawing.Size(75, 23);
			this.btnMensagem.TabIndex = 0;
			this.btnMensagem.Text = "Clique Aqui";
			this.btnMensagem.UseVisualStyleBackColor = true;
			this.btnMensagem.Click += new System.EventHandler(this.Button1Click);
			// 
			// lblMensagem
			// 
			this.lblMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMensagem.Location = new System.Drawing.Point(85, 74);
			this.lblMensagem.Name = "lblMensagem";
			this.lblMensagem.Size = new System.Drawing.Size(100, 23);
			this.lblMensagem.TabIndex = 1;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.lblMensagem);
			this.Controls.Add(this.btnMensagem);
			this.Name = "MainForm";
			this.Text = "Atividade 01";
			this.ResumeLayout(false);

		}
	}
}
