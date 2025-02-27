/*
 * Created by SharpDevelop.
 * User: Matheus
 * Date: 25/02/2025
 * Time: 21:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Atividade_20
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblPeso;
		private System.Windows.Forms.Label lblAltura;
		private System.Windows.Forms.Label lblIMC;
		private System.Windows.Forms.Label lblStatus;
		private System.Windows.Forms.TextBox txtPeso;
		private System.Windows.Forms.TextBox txtAltura;
		private System.Windows.Forms.TextBox txtIMC;
		private System.Windows.Forms.TextBox txtStatus;
		private System.Windows.Forms.Button btnCalcular;
		
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
			this.lblPeso = new System.Windows.Forms.Label();
			this.lblAltura = new System.Windows.Forms.Label();
			this.lblIMC = new System.Windows.Forms.Label();
			this.lblStatus = new System.Windows.Forms.Label();
			this.txtPeso = new System.Windows.Forms.TextBox();
			this.txtAltura = new System.Windows.Forms.TextBox();
			this.txtIMC = new System.Windows.Forms.TextBox();
			this.txtStatus = new System.Windows.Forms.TextBox();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(33, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(159, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Calcule seu IMC";
			// 
			// lblPeso
			// 
			this.lblPeso.Location = new System.Drawing.Point(31, 84);
			this.lblPeso.Name = "lblPeso";
			this.lblPeso.Size = new System.Drawing.Size(56, 23);
			this.lblPeso.TabIndex = 1;
			this.lblPeso.Text = "Peso:";
			// 
			// lblAltura
			// 
			this.lblAltura.Location = new System.Drawing.Point(32, 111);
			this.lblAltura.Name = "lblAltura";
			this.lblAltura.Size = new System.Drawing.Size(55, 23);
			this.lblAltura.TabIndex = 2;
			this.lblAltura.Text = "Altura:";
			// 
			// lblIMC
			// 
			this.lblIMC.Location = new System.Drawing.Point(32, 138);
			this.lblIMC.Name = "lblIMC";
			this.lblIMC.Size = new System.Drawing.Size(55, 23);
			this.lblIMC.TabIndex = 3;
			this.lblIMC.Text = "IMC:";
			// 
			// lblStatus
			// 
			this.lblStatus.Location = new System.Drawing.Point(32, 165);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(55, 23);
			this.lblStatus.TabIndex = 4;
			this.lblStatus.Text = "Status:";
			// 
			// txtPeso
			// 
			this.txtPeso.Location = new System.Drawing.Point(76, 82);
			this.txtPeso.Name = "txtPeso";
			this.txtPeso.Size = new System.Drawing.Size(100, 20);
			this.txtPeso.TabIndex = 5;
			// 
			// txtAltura
			// 
			this.txtAltura.Location = new System.Drawing.Point(76, 109);
			this.txtAltura.Name = "txtAltura";
			this.txtAltura.Size = new System.Drawing.Size(100, 20);
			this.txtAltura.TabIndex = 6;
			// 
			// txtIMC
			// 
			this.txtIMC.Location = new System.Drawing.Point(76, 135);
			this.txtIMC.Name = "txtIMC";
			this.txtIMC.ReadOnly = true;
			this.txtIMC.Size = new System.Drawing.Size(100, 20);
			this.txtIMC.TabIndex = 7;
			// 
			// txtStatus
			// 
			this.txtStatus.Location = new System.Drawing.Point(76, 162);
			this.txtStatus.Name = "txtStatus";
			this.txtStatus.ReadOnly = true;
			this.txtStatus.Size = new System.Drawing.Size(100, 20);
			this.txtStatus.TabIndex = 8;
			// 
			// btnCalcular
			// 
			this.btnCalcular.Location = new System.Drawing.Point(87, 203);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(75, 23);
			this.btnCalcular.TabIndex = 9;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(239, 261);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.txtStatus);
			this.Controls.Add(this.txtIMC);
			this.Controls.Add(this.txtAltura);
			this.Controls.Add(this.txtPeso);
			this.Controls.Add(this.lblStatus);
			this.Controls.Add(this.lblIMC);
			this.Controls.Add(this.lblAltura);
			this.Controls.Add(this.lblPeso);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "Atividade 20";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
