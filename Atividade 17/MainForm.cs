/*
 * Created by SharpDevelop.
 * User: Aluno_Manha
 * Date: 25/02/2025
 * Time: 10:10
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers. 1
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Atividade_17
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            
            // Vincula os eventos ao carregar o formulário
            dateTimePickerAtual.ValueChanged += AtualizarDiferencas;
            dateTimePickerPagamento.ValueChanged += AtualizarDiferencas;
            BtnAdicionarDias.Click += BtnAdicionarDias_Click;
        }

        private void AtualizarDiferencas(object sender, EventArgs e)
        {
            DateTime dataAtual = dateTimePickerAtual.Value.Date;
            DateTime dataPagto = dateTimePickerPagamento.Value.Date;
            
            TimeSpan diferenca = dataPagto - dataAtual;
            txtDiferencaDias.Text = diferenca.Days.ToString();

            // Calcula a diferença em anos, meses e dias
            int anos = dataPagto.Year - dataAtual.Year;
            int meses = dataPagto.Month - dataAtual.Month;
            int dias = dataPagto.Day - dataAtual.Day;

            if (dias < 0)
            {
                meses--;
                dias += DateTime.DaysInMonth(dataAtual.Year, dataAtual.Month);
            }

            if (meses < 0)
            {
                anos--;
                meses += 12;
            }

            txtAno.Text = anos.ToString();
            txtMes.Text = meses.ToString();
            txtDia.Text = dias.ToString();
        }

        private void BtnAdicionarDias_Click(object sender, EventArgs e)
        {
            int qtdDias;
            bool sucesso = int.TryParse(txtAddDias.Text, out qtdDias);

            if (sucesso)
            {
                DateTime dataAtual = dateTimePickerAtual.Value.Date;
                DateTime novaData = dataAtual.AddDays(qtdDias);
                txtNovaData.Text = novaData.ToString("dd/MM/yyyy");
            }
            else
            {
                MessageBox.Show("Digite um número válido.");
            }
        }
		void BtnAdicionarDiasClick(object sender, EventArgs e)
		{
	
		}
		void TxtNovaDataTextChanged(object sender, EventArgs e)
		{
	
		}
    }
}