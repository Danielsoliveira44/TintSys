namespace TintSysDesk
{
    partial class FrmTeste
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpgDados = new System.Windows.Forms.TabPage();
            this.tgpEnderecos = new System.Windows.Forms.TabPage();
            this.tgpTelefones = new System.Windows.Forms.TabPage();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.Ativo = new System.Windows.Forms.CheckBox();
            this.Cadastro = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.Cpf = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.Label();
            this.mktCpf = new System.Windows.Forms.MaskedTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tabControl1.SuspendLayout();
            this.tpgDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpgDados);
            this.tabControl1.Controls.Add(this.tgpEnderecos);
            this.tabControl1.Controls.Add(this.tgpTelefones);
            this.tabControl1.Location = new System.Drawing.Point(232, 48);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(498, 335);
            this.tabControl1.TabIndex = 0;
            // 
            // tpgDados
            // 
            this.tpgDados.Controls.Add(this.dateTimePicker1);
            this.tpgDados.Controls.Add(this.mktCpf);
            this.tpgDados.Controls.Add(this.txtId);
            this.tpgDados.Controls.Add(this.txtEmail);
            this.tpgDados.Controls.Add(this.Id);
            this.tpgDados.Controls.Add(this.Nome);
            this.tpgDados.Controls.Add(this.txtNome);
            this.tpgDados.Controls.Add(this.Cpf);
            this.tpgDados.Controls.Add(this.Email);
            this.tpgDados.Controls.Add(this.Ativo);
            this.tpgDados.Controls.Add(this.Cadastro);
            this.tpgDados.Location = new System.Drawing.Point(4, 22);
            this.tpgDados.Name = "tpgDados";
            this.tpgDados.Padding = new System.Windows.Forms.Padding(3);
            this.tpgDados.Size = new System.Drawing.Size(490, 309);
            this.tpgDados.TabIndex = 0;
            this.tpgDados.Text = "Dados Pessoais";
            this.tpgDados.UseVisualStyleBackColor = true;
            this.tpgDados.Click += new System.EventHandler(this.tpgDados_Click);
            // 
            // tgpEnderecos
            // 
            this.tgpEnderecos.Location = new System.Drawing.Point(4, 22);
            this.tgpEnderecos.Name = "tgpEnderecos";
            this.tgpEnderecos.Padding = new System.Windows.Forms.Padding(3);
            this.tgpEnderecos.Size = new System.Drawing.Size(490, 309);
            this.tgpEnderecos.TabIndex = 1;
            this.tgpEnderecos.Text = "Endereços";
            this.tgpEnderecos.UseVisualStyleBackColor = true;
            // 
            // tgpTelefones
            // 
            this.tgpTelefones.Location = new System.Drawing.Point(4, 22);
            this.tgpTelefones.Name = "tgpTelefones";
            this.tgpTelefones.Padding = new System.Windows.Forms.Padding(3);
            this.tgpTelefones.Size = new System.Drawing.Size(490, 309);
            this.tgpTelefones.TabIndex = 2;
            this.tgpTelefones.Text = "Telefones";
            this.tgpTelefones.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(163, 182);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(211, 20);
            this.txtEmail.TabIndex = 20;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(163, 96);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(211, 20);
            this.txtNome.TabIndex = 18;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(163, 51);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(40, 20);
            this.txtId.TabIndex = 17;
            // 
            // Ativo
            // 
            this.Ativo.AutoSize = true;
            this.Ativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ativo.Location = new System.Drawing.Point(314, 47);
            this.Ativo.Name = "Ativo";
            this.Ativo.Size = new System.Drawing.Size(56, 20);
            this.Ativo.TabIndex = 16;
            this.Ativo.Text = "Ativo";
            this.Ativo.UseVisualStyleBackColor = true;
            // 
            // Cadastro
            // 
            this.Cadastro.AutoSize = true;
            this.Cadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cadastro.Location = new System.Drawing.Point(73, 232);
            this.Cadastro.Name = "Cadastro";
            this.Cadastro.Size = new System.Drawing.Size(81, 16);
            this.Cadastro.TabIndex = 15;
            this.Cadastro.Text = "Cadastrado ";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(93, 186);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(41, 16);
            this.Email.TabIndex = 14;
            this.Email.Text = "Email";
            // 
            // Cpf
            // 
            this.Cpf.AutoSize = true;
            this.Cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cpf.Location = new System.Drawing.Point(97, 138);
            this.Cpf.Name = "Cpf";
            this.Cpf.Size = new System.Drawing.Size(33, 16);
            this.Cpf.TabIndex = 13;
            this.Cpf.Text = "CPF";
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome.Location = new System.Drawing.Point(91, 97);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(44, 16);
            this.Nome.TabIndex = 12;
            this.Nome.Text = "Nome";
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id.Location = new System.Drawing.Point(104, 51);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(18, 16);
            this.Id.TabIndex = 11;
            this.Id.Text = "Id";
            // 
            // mktCpf
            // 
            this.mktCpf.Location = new System.Drawing.Point(163, 138);
            this.mktCpf.Mask = "000.000.000-00";
            this.mktCpf.Name = "mktCpf";
            this.mktCpf.Size = new System.Drawing.Size(97, 20);
            this.mktCpf.TabIndex = 22;
            this.mktCpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(163, 232);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(97, 20);
            this.dateTimePicker1.TabIndex = 23;
            this.dateTimePicker1.Value = new System.DateTime(2023, 4, 3, 16, 37, 32, 0);
            // 
            // FrmTeste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 649);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmTeste";
            this.Text = "FrmTeste";
            this.tabControl1.ResumeLayout(false);
            this.tpgDados.ResumeLayout(false);
            this.tpgDados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpgDados;
        private System.Windows.Forms.TabPage tgpEnderecos;
        private System.Windows.Forms.TabPage tgpTelefones;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.MaskedTextBox mktCpf;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label Cpf;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.CheckBox Ativo;
        private System.Windows.Forms.Label Cadastro;
    }
}