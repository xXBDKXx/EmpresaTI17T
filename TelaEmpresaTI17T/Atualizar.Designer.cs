namespace TelaEmpresaTI17T
{
    partial class Atualizar
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
            this.button1 = new System.Windows.Forms.Button();
            this.UF = new System.Windows.Forms.MaskedTextBox();
            this.Telefone = new System.Windows.Forms.MaskedTextBox();
            this.Cidade = new System.Windows.Forms.TextBox();
            this.CPF = new System.Windows.Forms.MaskedTextBox();
            this.Nome = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Papyrus", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(184, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(297, 42);
            this.button1.TabIndex = 23;
            this.button1.Text = "Atualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UF
            // 
            this.UF.Location = new System.Drawing.Point(183, 299);
            this.UF.Mask = "AA";
            this.UF.Name = "UF";
            this.UF.Size = new System.Drawing.Size(299, 20);
            this.UF.TabIndex = 22;
            this.UF.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.UF_MaskInputRejected);
            // 
            // Telefone
            // 
            this.Telefone.Location = new System.Drawing.Point(184, 217);
            this.Telefone.Mask = "(99)9999-9999";
            this.Telefone.Name = "Telefone";
            this.Telefone.Size = new System.Drawing.Size(299, 20);
            this.Telefone.TabIndex = 21;
            this.Telefone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Telefone_MaskInputRejected);
            // 
            // Cidade
            // 
            this.Cidade.Location = new System.Drawing.Point(183, 255);
            this.Cidade.Name = "Cidade";
            this.Cidade.Size = new System.Drawing.Size(300, 20);
            this.Cidade.TabIndex = 20;
            this.Cidade.TextChanged += new System.EventHandler(this.Cidade_TextChanged);
            // 
            // CPF
            // 
            this.CPF.Location = new System.Drawing.Point(184, 137);
            this.CPF.Mask = "99999999999";
            this.CPF.Name = "CPF";
            this.CPF.Size = new System.Drawing.Size(299, 20);
            this.CPF.TabIndex = 19;
            this.CPF.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.CPF_MaskInputRejected);
            // 
            // Nome
            // 
            this.Nome.Location = new System.Drawing.Point(184, 179);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(300, 20);
            this.Nome.TabIndex = 18;
            this.Nome.TextChanged += new System.EventHandler(this.Nome_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Papyrus", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(76, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "UF";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Papyrus", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(76, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Telefone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Papyrus", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(76, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Cidade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Papyrus", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(76, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Papyrus", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "CPF";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Papyrus", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(215, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 42);
            this.label1.TabIndex = 12;
            this.label1.Text = "Atualizar Pessoa";
            // 
            // Atualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 461);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.UF);
            this.Controls.Add(this.Telefone);
            this.Controls.Add(this.Cidade);
            this.Controls.Add(this.CPF);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(650, 500);
            this.MinimumSize = new System.Drawing.Size(650, 500);
            this.Name = "Atualizar";
            this.Text = "Atualizar";
            this.Load += new System.EventHandler(this.Atualizar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox UF;
        private System.Windows.Forms.MaskedTextBox Telefone;
        private System.Windows.Forms.TextBox Cidade;
        private System.Windows.Forms.MaskedTextBox CPF;
        private System.Windows.Forms.TextBox Nome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}