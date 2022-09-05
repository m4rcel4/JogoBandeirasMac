namespace JogoBandeiras
{
    partial class jogadorAntigo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeJogadorAntigo = new System.Windows.Forms.TextBox();
            this.btnJogadorReturn = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "JOGADOR ANTIGO";
            // 
            // txtNomeJogadorAntigo
            // 
            this.txtNomeJogadorAntigo.Location = new System.Drawing.Point(135, 150);
            this.txtNomeJogadorAntigo.Name = "txtNomeJogadorAntigo";
            this.txtNomeJogadorAntigo.Size = new System.Drawing.Size(255, 22);
            this.txtNomeJogadorAntigo.TabIndex = 1;
            // 
            // btnJogadorReturn
            // 
            this.btnJogadorReturn.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnJogadorReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJogadorReturn.Location = new System.Drawing.Point(171, 242);
            this.btnJogadorReturn.Name = "btnJogadorReturn";
            this.btnJogadorReturn.Size = new System.Drawing.Size(184, 85);
            this.btnJogadorReturn.TabIndex = 2;
            this.btnJogadorReturn.Text = "Retomar jogador";
            this.btnJogadorReturn.UseVisualStyleBackColor = false;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(1, 0);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 3;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome:";
            // 
            // jogadorAntigo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(523, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnJogadorReturn);
            this.Controls.Add(this.txtNomeJogadorAntigo);
            this.Controls.Add(this.label1);
            this.Name = "jogadorAntigo";
            this.Text = "Jogador antigo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeJogadorAntigo;
        private System.Windows.Forms.Button btnJogadorReturn;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label label2;
    }
}