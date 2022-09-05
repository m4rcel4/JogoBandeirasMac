namespace JogoBandeiras
{
    partial class cadastroTresNomes
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnJogar3 = new System.Windows.Forms.Button();
            this.txtJog1 = new System.Windows.Forms.TextBox();
            this.txtJog2 = new System.Windows.Forms.TextBox();
            this.txtJog3 = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(495, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "CADASTRO DE JOGADORES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jogador 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Jogador 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(538, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Jogador 3";
            // 
            // btnJogar3
            // 
            this.btnJogar3.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnJogar3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJogar3.Location = new System.Drawing.Point(276, 312);
            this.btnJogar3.Name = "btnJogar3";
            this.btnJogar3.Size = new System.Drawing.Size(216, 92);
            this.btnJogar3.TabIndex = 4;
            this.btnJogar3.Text = "JOGAR";
            this.btnJogar3.UseVisualStyleBackColor = false;
            this.btnJogar3.Click += new System.EventHandler(this.btnJogar3_Click);
            // 
            // txtJog1
            // 
            this.txtJog1.Location = new System.Drawing.Point(20, 185);
            this.txtJog1.Name = "txtJog1";
            this.txtJog1.Size = new System.Drawing.Size(128, 22);
            this.txtJog1.TabIndex = 5;
            this.txtJog1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtJog2
            // 
            this.txtJog2.Location = new System.Drawing.Point(276, 185);
            this.txtJog2.Name = "txtJog2";
            this.txtJog2.Size = new System.Drawing.Size(145, 22);
            this.txtJog2.TabIndex = 6;
            this.txtJog2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtJog3
            // 
            this.txtJog3.Location = new System.Drawing.Point(541, 185);
            this.txtJog3.Name = "txtJog3";
            this.txtJog3.Size = new System.Drawing.Size(126, 22);
            this.txtJog3.TabIndex = 7;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(4, 3);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 8;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // cadastroTresNomes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.txtJog3);
            this.Controls.Add(this.txtJog2);
            this.Controls.Add(this.txtJog1);
            this.Controls.Add(this.btnJogar3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "cadastroTresNomes";
            this.Text = "Três novos jogadores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnJogar3;
        private System.Windows.Forms.TextBox txtJog1;
        private System.Windows.Forms.TextBox txtJog2;
        private System.Windows.Forms.TextBox txtJog3;
        private System.Windows.Forms.Button btnVoltar;
    }
}