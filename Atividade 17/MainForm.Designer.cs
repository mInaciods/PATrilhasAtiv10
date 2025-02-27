/*
 * Created by SharpDevelop.
 * User: Aluno_Manha
 * Date: 25/02/2025
 * Time: 10:10
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Atividade_17
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.DateTimePicker dateTimePickerAtual;
		private System.Windows.Forms.DateTimePicker dateTimePickerPagamento;
		private System.Windows.Forms.Label lblDataAtual;
		private System.Windows.Forms.TextBox txtDia;
		private System.Windows.Forms.Label lblDataPagto;
		private System.Windows.Forms.Label lblDia;
		private System.Windows.Forms.Label lblMes;
		private System.Windows.Forms.TextBox txtMes;
		private System.Windows.Forms.Label lblAno;
		private System.Windows.Forms.TextBox txtAno;
		private System.Windows.Forms.Label lblAddDias;
		private System.Windows.Forms.TextBox txtAddDias;
		private System.Windows.Forms.TextBox txtNovaData;
		private System.Windows.Forms.Button BtnAdicionarDias;
		private System.Windows.Forms.Label lblDiferencaDias;
		private System.Windows.Forms.TextBox txtDiferencaDias;
		
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
			this.dateTimePickerAtual = new System.Windows.Forms.DateTimePicker();
			this.dateTimePickerPagamento = new System.Windows.Forms.DateTimePicker();
			this.lblDataAtual = new System.Windows.Forms.Label();
			this.txtDia = new System.Windows.Forms.TextBox();
			this.lblDataPagto = new System.Windows.Forms.Label();
			this.lblDia = new System.Windows.Forms.Label();
			this.lblMes = new System.Windows.Forms.Label();
			this.txtMes = new System.Windows.Forms.TextBox();
			this.lblAno = new System.Windows.Forms.Label();
			this.txtAno = new System.Windows.Forms.TextBox();
			this.lblAddDias = new System.Windows.Forms.Label();
			this.txtAddDias = new System.Windows.Forms.TextBox();
			this.txtNovaData = new System.Windows.Forms.TextBox();
			this.BtnAdicionarDias = new System.Windows.Forms.Button();
			this.lblDiferencaDias = new System.Windows.Forms.Label();
			this.txtDiferencaDias = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// dateTimePickerAtual
			// 
			this.dateTimePickerAtual.Location = new System.Drawing.Point(88, 23);
			this.dateTimePickerAtual.Name = "dateTimePickerAtual";
			this.dateTimePickerAtual.Size = new System.Drawing.Size(217, 20);
			this.dateTimePickerAtual.TabIndex = 0;
			this.dateTimePickerAtual.ValueChanged += new System.EventHandler(this.AtualizarDiferencas);
			// 
			// dateTimePickerPagamento
			// 
			this.dateTimePickerPagamento.Location = new System.Drawing.Point(88, 66);
			this.dateTimePickerPagamento.Name = "dateTimePickerPagamento";
			this.dateTimePickerPagamento.Size = new System.Drawing.Size(217, 20);
			this.dateTimePickerPagamento.TabIndex = 1;
			this.dateTimePickerPagamento.ValueChanged += new System.EventHandler(this.AtualizarDiferencas);
			// 
			// lblDataAtual
			// 
			this.lblDataAtual.Location = new System.Drawing.Point(17, 26);
			this.lblDataAtual.Name = "lblDataAtual";
			this.lblDataAtual.Size = new System.Drawing.Size(69, 23);
			this.lblDataAtual.TabIndex = 2;
			this.lblDataAtual.Text = "Data Atual:";
			// 
			// txtDia
			// 
			this.txtDia.Location = new System.Drawing.Point(105, 123);
			this.txtDia.Name = "txtDia";
			this.txtDia.ReadOnly = true;
			this.txtDia.Size = new System.Drawing.Size(100, 20);
			this.txtDia.TabIndex = 3;
			// 
			// lblDataPagto
			// 
			this.lblDataPagto.Location = new System.Drawing.Point(17, 66);
			this.lblDataPagto.Name = "lblDataPagto";
			this.lblDataPagto.Size = new System.Drawing.Size(69, 23);
			this.lblDataPagto.TabIndex = 4;
			this.lblDataPagto.Text = "Data Pagto:";
			// 
			// lblDia
			// 
			this.lblDia.Location = new System.Drawing.Point(17, 123);
			this.lblDia.Name = "lblDia";
			this.lblDia.Size = new System.Drawing.Size(46, 23);
			this.lblDia.TabIndex = 5;
			this.lblDia.Text = "Dia:";
			// 
			// lblMes
			// 
			this.lblMes.Location = new System.Drawing.Point(18, 154);
			this.lblMes.Name = "lblMes";
			this.lblMes.Size = new System.Drawing.Size(100, 23);
			this.lblMes.TabIndex = 6;
			this.lblMes.Text = "Mês:";
			// 
			// txtMes
			// 
			this.txtMes.Location = new System.Drawing.Point(105, 156);
			this.txtMes.Name = "txtMes";
			this.txtMes.ReadOnly = true;
			this.txtMes.Size = new System.Drawing.Size(100, 20);
			this.txtMes.TabIndex = 7;
			// 
			// lblAno
			// 
			this.lblAno.Location = new System.Drawing.Point(19, 190);
			this.lblAno.Name = "lblAno";
			this.lblAno.Size = new System.Drawing.Size(100, 23);
			this.lblAno.TabIndex = 8;
			this.lblAno.Text = "Ano:";
			// 
			// txtAno
			// 
			this.txtAno.Location = new System.Drawing.Point(105, 188);
			this.txtAno.Name = "txtAno";
			this.txtAno.ReadOnly = true;
			this.txtAno.Size = new System.Drawing.Size(100, 20);
			this.txtAno.TabIndex = 9;
			// 
			// lblAddDias
			// 
			this.lblAddDias.Location = new System.Drawing.Point(19, 246);
			this.lblAddDias.Name = "lblAddDias";
			this.lblAddDias.Size = new System.Drawing.Size(100, 23);
			this.lblAddDias.TabIndex = 10;
			this.lblAddDias.Text = "Add. dias:";
			// 
			// txtAddDias
			// 
			this.txtAddDias.Location = new System.Drawing.Point(105, 246);
			this.txtAddDias.Name = "txtAddDias";
			this.txtAddDias.Size = new System.Drawing.Size(100, 20);
			this.txtAddDias.TabIndex = 11;
			// 
			// txtNovaData
			// 
			this.txtNovaData.Location = new System.Drawing.Point(223, 245);
			this.txtNovaData.Name = "txtNovaData";
			this.txtNovaData.Size = new System.Drawing.Size(100, 20);
			this.txtNovaData.TabIndex = 12;
			this.txtNovaData.TextChanged += new System.EventHandler(this.TxtNovaDataTextChanged);
			// 
			// BtnAdicionarDias
			// 
			this.BtnAdicionarDias.Location = new System.Drawing.Point(330, 242);
			this.BtnAdicionarDias.Name = "BtnAdicionarDias";
			this.BtnAdicionarDias.Size = new System.Drawing.Size(88, 23);
			this.BtnAdicionarDias.TabIndex = 13;
			this.BtnAdicionarDias.Text = "Adicionar dias";
			this.BtnAdicionarDias.UseVisualStyleBackColor = true;
			this.BtnAdicionarDias.Click += new System.EventHandler(this.BtnAdicionarDiasClick);
			// 
			// lblDiferencaDias
			// 
			this.lblDiferencaDias.Location = new System.Drawing.Point(19, 217);
			this.lblDiferencaDias.Name = "lblDiferencaDias";
			this.lblDiferencaDias.Size = new System.Drawing.Size(100, 23);
			this.lblDiferencaDias.TabIndex = 14;
			this.lblDiferencaDias.Text = "Dif. de dias:";
			// 
			// txtDiferencaDias
			// 
			this.txtDiferencaDias.Location = new System.Drawing.Point(105, 215);
			this.txtDiferencaDias.Name = "txtDiferencaDias";
			this.txtDiferencaDias.ReadOnly = true;
			this.txtDiferencaDias.Size = new System.Drawing.Size(100, 20);
			this.txtDiferencaDias.TabIndex = 15;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(420, 444);
			this.Controls.Add(this.txtDiferencaDias);
			this.Controls.Add(this.lblDiferencaDias);
			this.Controls.Add(this.BtnAdicionarDias);
			this.Controls.Add(this.txtNovaData);
			this.Controls.Add(this.txtAddDias);
			this.Controls.Add(this.lblAddDias);
			this.Controls.Add(this.txtAno);
			this.Controls.Add(this.lblAno);
			this.Controls.Add(this.txtMes);
			this.Controls.Add(this.lblMes);
			this.Controls.Add(this.lblDia);
			this.Controls.Add(this.lblDataPagto);
			this.Controls.Add(this.txtDia);
			this.Controls.Add(this.lblDataAtual);
			this.Controls.Add(this.dateTimePickerPagamento);
			this.Controls.Add(this.dateTimePickerAtual);
			this.Name = "MainForm";
			this.Text = "Atividade 17";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
