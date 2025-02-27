/*
 * Created by SharpDevelop.
 * User: Matheus
 * Date: 23/02/2025
 * Time: 21:58
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Atividade_15
{
    /// <summary>
    /// Description of MainForm.
    /// </summary>
    public partial class MainForm : Form
    {
        // Dicionário para armazenar os votos
        Dictionary<string, int> votos;
        
        // Dicionário para associar códigos às imagens dos candidatos
        Dictionary<string, Image> candidatos;
        
        public MainForm()
        {
            InitializeComponent();
            
            // Inicializa o dicionário de votos
            votos = new Dictionary<string, int>
            {
                { "1", 0 }, // Candidato 1
                { "2", 0 }, // Candidato 2
                { "3", 0 }, // Candidato 3
                { "Branco", 0 },
                { "Nulo", 0 }
            };

            // Inicializa o dicionário de candidatos
            candidatos = new Dictionary<string, Image>();
            
            // Associa o evento Load para carregar as imagens ao iniciar o formulário
            this.Load += new EventHandler(MainForm_Load);
        }
        
        // Evento Load do formulário: carrega as imagens dos candidatos
        void MainForm_Load(object sender, EventArgs e)
        {
            string caminhoImagens = @"C:\Users\Matheus\Documents\SharpDevelop Projects\Atividade 01\Atividade 15\imagens";
            
            try
            {
                // Monta os caminhos completos para cada imagem
                string caminhoCandidato1 = Path.Combine(caminhoImagens, "candidato1.jpg");
                string caminhoCandidato2 = Path.Combine(caminhoImagens, "candidato2.jpg");
                string caminhoCandidato3 = Path.Combine(caminhoImagens, "candidato3.jpg");
                
                // Carrega a imagem do candidato 1, se existir
                if (File.Exists(caminhoCandidato1))
                    candidatos["1"] = Image.FromFile(caminhoCandidato1);
                else
                    MessageBox.Show("Imagem do candidato 1 não encontrada:\n" + caminhoCandidato1);
                
                // Carrega a imagem do candidato 2, se existir
                if (File.Exists(caminhoCandidato2))
                    candidatos["2"] = Image.FromFile(caminhoCandidato2);
                else
                    MessageBox.Show("Imagem do candidato 2 não encontrada:\n" + caminhoCandidato2);
                
                // Carrega a imagem do candidato 3, se existir
                if (File.Exists(caminhoCandidato3))
                    candidatos["3"] = Image.FromFile(caminhoCandidato3);
                else
                    MessageBox.Show("Imagem do candidato 3 não encontrada:\n" + caminhoCandidato3);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar imagens: " + ex.Message);
            }
        }
        
        // Evento para exibir a foto do candidato conforme o código digitado no TextBox
        void TextBox1TextChanged(object sender, EventArgs e)
        {
            string codigo = textBox1.Text.Trim();
            
            // Se o código existir no dicionário, exibe a imagem correspondente
            if (candidatos.ContainsKey(codigo))
            {
                pictureBox1.Image = candidatos[codigo];
            }
            else
            {
                pictureBox1.Image = null; // Remove a imagem se não houver correspondência
            }
        }
        
        // Botão CONFIRMA - Computa o voto
        void ButtonConfirmaClick(object sender, EventArgs e)
        {
            string codigo = textBox1.Text.Trim();
            
            if (candidatos.ContainsKey(codigo))
            {
                votos[codigo]++;
                MessageBox.Show("Voto computado!", "Sucesso");
            }
            else if (string.IsNullOrEmpty(codigo))
            {
                votos["Branco"]++;
                MessageBox.Show("Voto em branco computado!", "Sucesso");
            }
            else
            {
                votos["Nulo"]++;
                MessageBox.Show("Voto nulo computado!", "Sucesso");
            }
            
            // Limpa a entrada e a imagem
            textBox1.Clear();
            pictureBox1.Image = null;
        }
        
        // Botão CANCELAR - Cancela o voto
        void ButtonCancelarClick(object sender, EventArgs e)
        {
            textBox1.Clear();
            pictureBox1.Image = null;
        }
        
        // Opção do menu: Iniciar Eleição - Zera todos os votos
        void MenuIniciarClick(object sender, EventArgs e)
        {
            votos["1"] = 0;
            votos["2"] = 0;
            votos["3"] = 0;
            votos["Branco"] = 0;
            votos["Nulo"] = 0;
            MessageBox.Show("Eleição iniciada! Todos os votos foram zerados.", "Início da Eleição");
        }
        
        // Opção do menu: Encerrar Eleição e mostrar o resultado
        void MenuEncerrarClick(object sender, EventArgs e)
        {
            string resultado = "Resultados:\n" +
                "Candidato 1: " + votos["1"] + " votos\n" +
                "Candidato 2: " + votos["2"] + " votos\n" +
                "Candidato 3: " + votos["3"] + " votos\n" +
                "Votos em Branco: " + votos["Branco"] + "\n" +
                "Votos Nulos: " + votos["Nulo"];
            
            MessageBox.Show(resultado, "Encerramento da Eleição");
        }
    }
}
