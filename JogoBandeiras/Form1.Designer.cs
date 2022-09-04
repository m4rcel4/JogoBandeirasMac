namespace JogoBandeiras
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnDoisJogadores = new System.Windows.Forms.Button();
            this.btnTresJogadores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(456, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "SELECIONE A PARTIDA";
            // 
            // btnDoisJogadores
            // 
            this.btnDoisJogadores.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnDoisJogadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoisJogadores.Location = new System.Drawing.Point(264, 165);
            this.btnDoisJogadores.Name = "btnDoisJogadores";
            this.btnDoisJogadores.Size = new System.Drawing.Size(235, 93);
            this.btnDoisJogadores.TabIndex = 1;
            this.btnDoisJogadores.Text = "2 JOGADORES";
            this.btnDoisJogadores.UseVisualStyleBackColor = false;
            // 
            // btnTresJogadores
            // 
            this.btnTresJogadores.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnTresJogadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTresJogadores.Location = new System.Drawing.Point(264, 330);
            this.btnTresJogadores.Name = "btnTresJogadores";
            this.btnTresJogadores.Size = new System.Drawing.Size(235, 93);
            this.btnTresJogadores.TabIndex = 2;
            this.btnTresJogadores.Text = "3 JOGADORES";
            this.btnTresJogadores.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 497);
            this.Controls.Add(this.btnTresJogadores);
            this.Controls.Add(this.btnDoisJogadores);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Seleção de partidas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDoisJogadores;
        private System.Windows.Forms.Button btnTresJogadores;
    }
}

