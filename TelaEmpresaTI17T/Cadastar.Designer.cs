namespace TelaEmpresaTI17T
{
    partial class Cadastar
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.TextBox();
            this.cpf = new System.Windows.Forms.MaskedTextBox();
            this.cidade = new System.Windows.Forms.TextBox();
            this.telefone = new System.Windows.Forms.MaskedTextBox();
            this.uf = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Papyrus", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastrar Pessoa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Papyrus", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "CPF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Papyrus", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Papyrus", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cidade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Papyrus", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(56, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Papyrus", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(56, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "UF";
            // 
            // nome
            // 
            this.nome.Location = new System.Drawing.Point(164, 194);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(300, 20);
            this.nome.TabIndex = 6;
            this.nome.TextChanged += new System.EventHandler(this.nome_TextChanged);
            // 
            // cpf
            // 
            this.cpf.Location = new System.Drawing.Point(164, 152);
            this.cpf.Mask = "99999999999";
            this.cpf.Name = "cpf";
            this.cpf.Size = new System.Drawing.Size(299, 20);
            this.cpf.TabIndex = 7;
            this.cpf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.cpf_MaskInputRejected);
            // 
            // cidade
            // 
            this.cidade.Location = new System.Drawing.Point(163, 270);
            this.cidade.Name = "cidade";
            this.cidade.Size = new System.Drawing.Size(300, 20);
            this.cidade.TabIndex = 8;
            this.cidade.TextChanged += new System.EventHandler(this.cidade_TextChanged);
            // 
            // telefone
            // 
            this.telefone.Location = new System.Drawing.Point(164, 232);
            this.telefone.Mask = "(99)9999-9999";
            this.telefone.Name = "telefone";
            this.telefone.Size = new System.Drawing.Size(299, 20);
            this.telefone.TabIndex = 9;
            this.telefone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.telefone_MaskInputRejected);
            // 
            // uf
            // 
            this.uf.Location = new System.Drawing.Point(163, 314);
            this.uf.Mask = "AA";
            this.uf.Name = "uf";
            this.uf.Size = new System.Drawing.Size(299, 20);
            this.uf.TabIndex = 10;
            this.uf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.uf_MaskInputRejected);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Papyrus", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(164, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(297, 42);
            this.button1.TabIndex = 11;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cadastar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 461);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.uf);
            this.Controls.Add(this.telefone);
            this.Controls.Add(this.cidade);
            this.Controls.Add(this.cpf);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(650, 500);
            this.MinimumSize = new System.Drawing.Size(650, 500);
            this.Name = "Cadastar";
            this.Text = "Cadastar";
            this.Load += new System.EventHandler(this.Cadastar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.MaskedTextBox cpf;
        private System.Windows.Forms.TextBox cidade;
        private System.Windows.Forms.MaskedTextBox telefone;
        private System.Windows.Forms.MaskedTextBox uf;
        private System.Windows.Forms.Button button1;
    }
}