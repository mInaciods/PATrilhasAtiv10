/*
 * Created by SharpDevelop.
 * User: Matheus
 * Date: 23/02/2025
 * Time: 21:58
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Atividade_15
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox textBox1;
		public System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button buttonConfirma;
		private System.Windows.Forms.Button buttonCancelar;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem iniciarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem encerrarEleiçãoToolStripMenuItem;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.buttonConfirma = new System.Windows.Forms.Button();
			this.buttonCancelar = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.iniciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.encerrarEleiçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(216, 117);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 0;
			this.textBox1.Click += new System.EventHandler(this.TextBox1TextChanged);
			this.textBox1.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
			// 
			// pictureBox1
			// 
			this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
			this.pictureBox1.ImageLocation = "C:\\Users\\Matheus\\Documents\\SharpDevelop Projects\\Atividade 01\\Atividade 15\\imagen" +
	"s";
			this.pictureBox1.InitialImage = null;
			this.pictureBox1.Location = new System.Drawing.Point(178, 238);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(193, 158);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// buttonConfirma
			// 
			this.buttonConfirma.Location = new System.Drawing.Point(154, 164);
			this.buttonConfirma.Name = "buttonConfirma";
			this.buttonConfirma.Size = new System.Drawing.Size(75, 23);
			this.buttonConfirma.TabIndex = 2;
			this.buttonConfirma.Text = "CONFIRMA";
			this.buttonConfirma.UseVisualStyleBackColor = true;
			this.buttonConfirma.Click += new System.EventHandler(this.ButtonConfirmaClick);
			// 
			// buttonCancelar
			// 
			this.buttonCancelar.Location = new System.Drawing.Point(296, 164);
			this.buttonCancelar.Name = "buttonCancelar";
			this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
			this.buttonCancelar.TabIndex = 3;
			this.buttonCancelar.Text = "CANCELA";
			this.buttonCancelar.UseVisualStyleBackColor = true;
			this.buttonCancelar.Click += new System.EventHandler(this.ButtonCancelarClick);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.iniciarToolStripMenuItem,
			this.encerrarEleiçãoToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(524, 24);
			this.menuStrip1.TabIndex = 4;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// iniciarToolStripMenuItem
			// 
			this.iniciarToolStripMenuItem.Name = "iniciarToolStripMenuItem";
			this.iniciarToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
			this.iniciarToolStripMenuItem.Text = " Iniciar Eleição";
			this.iniciarToolStripMenuItem.Click += new System.EventHandler(this.MenuIniciarClick);
			// 
			// encerrarEleiçãoToolStripMenuItem
			// 
			this.encerrarEleiçãoToolStripMenuItem.Name = "encerrarEleiçãoToolStripMenuItem";
			this.encerrarEleiçãoToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
			this.encerrarEleiçãoToolStripMenuItem.Text = "Encerrar Eleição";
			this.encerrarEleiçãoToolStripMenuItem.Click += new System.EventHandler(this.MenuEncerrarClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(524, 494);
			this.Controls.Add(this.buttonCancelar);
			this.Controls.Add(this.buttonConfirma);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.menuStrip1);
			this.Name = "MainForm";
			this.Text = "Atividade 15";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
