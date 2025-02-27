/*
 * Created by SharpDevelop.
 * User: Matheus
 * Date: 23/02/2025
 * Time: 21:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Atividade_09
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
    {
        Timer timerCountdown;
        int segundosRestantes = 10; // Contagem regressiva de 10 segundos

        public MainForm()
        {
            InitializeComponent();
            
            // Configura o ProgressBar
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 10; // 10 segundos
            progressBar1.Value = 0;
            
            // Cria e configura o Timer
            timerCountdown = new Timer();
            timerCountdown.Interval = 1000; // 1000 milissegundos = 1 segundo
            timerCountdown.Tick += TimerCountdown_Tick;
        }
        
        // Evento associado ao clique do botão para iniciar a contagem regressiva
        void Button1Click(object sender, EventArgs e)
        {
            // Reinicia a contagem e o ProgressBar
            segundosRestantes = 10;
            progressBar1.Value = 0;
            
            // Inicia o Timer
            timerCountdown.Start();
        }
        
        // Evento que é chamado a cada segundo pelo Timer
        void TimerCountdown_Tick(object sender, EventArgs e)
        {
            if(segundosRestantes > 0)
            {
                segundosRestantes--;
                // Atualiza o ProgressBar conforme o tempo decorrido
                progressBar1.Value = progressBar1.Maximum - segundosRestantes;
            }
            else
            {
                // Para o Timer quando a contagem chega a zero
                timerCountdown.Stop();
                MessageBox.Show("Contagem regressiva finalizada!", "Fim");
            }
        }
    }
}