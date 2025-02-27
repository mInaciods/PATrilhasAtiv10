namespace Atividade_19
{
    public partial class Form1 : Form
    {
        // Evento do botão Iniciar
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            // Limpa a área de resultados a cada clique
            txtResultados.Clear();

            // Tenta converter o valor digitado em inteiro
            int numero;
            bool sucesso = int.TryParse(txtNumero.Text, out numero);

            if (!sucesso || numero < 1)
            {
                MessageBox.Show("Digite um número inteiro maior ou igual a 1.");
                return;
            }

            int soma = 0;

            // Se a CheckBox estiver marcada, exibe cada soma parcial
            if (chkResultados.Checked)
            {
                for (int i = 1; i <= numero; i++)
                {
                    soma += i;
                    // Exibe uma linha com o valor atual e a soma parcial
                    txtResultados.AppendText($"somando: {i} soma parcial: {soma}\r\n");
                }
                txtResultados.AppendText($"Total: {soma}\r\n");
            }
            else
            {
                for (int i = 1; i <= numero; i++)
                {
                    soma += i;
                }
                txtResultados.AppendText($"Total: {soma}");
            }
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitulo = new Label();
            txtNumero = new TextBox();
            chkResultados = new CheckBox();
            txtResultados = new TextBox();
            btnIniciar = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(14, 29);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(138, 15);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Calcular a soma de 1 até:";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(158, 26);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 1;
            // 
            // chkResultados
            // 
            chkResultados.AutoSize = true;
            chkResultados.Location = new Point(26, 79);
            chkResultados.Name = "chkResultados";
            chkResultados.Size = new Size(83, 19);
            chkResultados.TabIndex = 2;
            chkResultados.Text = "Resultados";
            chkResultados.UseVisualStyleBackColor = true;
            // 
            // txtResultados
            // 
            txtResultados.Location = new Point(26, 145);
            txtResultados.Multiline = true;
            txtResultados.Name = "txtResultados";
            txtResultados.ScrollBars = ScrollBars.Vertical;
            txtResultados.Size = new Size(304, 158);
            txtResultados.TabIndex = 3;
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(128, 318);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(75, 23);
            btnIniciar.TabIndex = 4;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 396);
            Controls.Add(btnIniciar);
            Controls.Add(txtResultados);
            Controls.Add(chkResultados);
            Controls.Add(txtNumero);
            Controls.Add(lblTitulo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private TextBox txtNumero;
        private CheckBox chkResultados;
        private TextBox txtResultados;
        private Button btnIniciar;
    }
}
