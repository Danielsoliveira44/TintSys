namespace TintSysDesk
{
    partial class FrmCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCliente));
            this.Id = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.Label();
            this.Cpf = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.Cadastro = new System.Windows.Forms.Label();
            this.Ativo = new System.Windows.Forms.CheckBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCadastro = new System.Windows.Forms.TextBox();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.Id_Cli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome_Cli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cpf_Cli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email_Cli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datacad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id.Location = new System.Drawing.Point(72, 69);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(18, 16);
            this.Id.TabIndex = 0;
            this.Id.Text = "Id";
            this.Id.Click += new System.EventHandler(this.label1_Click);
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome.Location = new System.Drawing.Point(59, 115);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(44, 16);
            this.Nome.TabIndex = 1;
            this.Nome.Text = "Nome";
            this.Nome.Click += new System.EventHandler(this.Nome_Click);
            // 
            // Cpf
            // 
            this.Cpf.AutoSize = true;
            this.Cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cpf.Location = new System.Drawing.Point(65, 156);
            this.Cpf.Name = "Cpf";
            this.Cpf.Size = new System.Drawing.Size(33, 16);
            this.Cpf.TabIndex = 2;
            this.Cpf.Text = "CPF";
            this.Cpf.Click += new System.EventHandler(this.Cpf_Click);
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(61, 204);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(41, 16);
            this.Email.TabIndex = 3;
            this.Email.Text = "Email";
            this.Email.Click += new System.EventHandler(this.Email_Click);
            // 
            // Cadastro
            // 
            this.Cadastro.AutoSize = true;
            this.Cadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cadastro.Location = new System.Drawing.Point(41, 250);
            this.Cadastro.Name = "Cadastro";
            this.Cadastro.Size = new System.Drawing.Size(81, 16);
            this.Cadastro.TabIndex = 4;
            this.Cadastro.Text = "Cadastrado ";
            this.Cadastro.Click += new System.EventHandler(this.Cadastro_Click);
            // 
            // Ativo
            // 
            this.Ativo.AutoSize = true;
            this.Ativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ativo.Location = new System.Drawing.Point(282, 65);
            this.Ativo.Name = "Ativo";
            this.Ativo.Size = new System.Drawing.Size(56, 20);
            this.Ativo.TabIndex = 5;
            this.Ativo.Text = "Ativo";
            this.Ativo.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(131, 69);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(40, 20);
            this.txtId.TabIndex = 6;
            this.txtId.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(131, 114);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(211, 20);
            this.txtNome.TabIndex = 7;
            this.txtNome.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(131, 152);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(211, 20);
            this.txtCpf.TabIndex = 8;
            this.txtCpf.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(131, 200);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(211, 20);
            this.txtEmail.TabIndex = 9;
            // 
            // txtCadastro
            // 
            this.txtCadastro.Location = new System.Drawing.Point(131, 246);
            this.txtCadastro.Name = "txtCadastro";
            this.txtCadastro.Size = new System.Drawing.Size(159, 20);
            this.txtCadastro.TabIndex = 10;
            // 
            // dgvCliente
            // 
            this.dgvCliente.AllowUserToAddRows = false;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Cli,
            this.Nome_Cli,
            this.Cpf_Cli,
            this.Email_Cli,
            this.Datacad});
            this.dgvCliente.Location = new System.Drawing.Point(44, 398);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.RowHeadersVisible = false;
            this.dgvCliente.Size = new System.Drawing.Size(656, 156);
            this.dgvCliente.TabIndex = 14;
            this.dgvCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Id_Cli
            // 
            this.Id_Cli.Frozen = true;
            this.Id_Cli.HeaderText = "ID";
            this.Id_Cli.Name = "Id_Cli";
            this.Id_Cli.ReadOnly = true;
            // 
            // Nome_Cli
            // 
            this.Nome_Cli.Frozen = true;
            this.Nome_Cli.HeaderText = "Nome";
            this.Nome_Cli.Name = "Nome_Cli";
            this.Nome_Cli.Width = 150;
            // 
            // Cpf_Cli
            // 
            this.Cpf_Cli.Frozen = true;
            this.Cpf_Cli.HeaderText = "CPF";
            this.Cpf_Cli.Name = "Cpf_Cli";
            this.Cpf_Cli.Width = 130;
            // 
            // Email_Cli
            // 
            this.Email_Cli.Frozen = true;
            this.Email_Cli.HeaderText = "Email";
            this.Email_Cli.Name = "Email_Cli";
            this.Email_Cli.Width = 150;
            // 
            // Datacad
            // 
            this.Datacad.Frozen = true;
            this.Datacad.HeaderText = "Data de cadastro";
            this.Datacad.Name = "Datacad";
            this.Datacad.Width = 120;
            // 
            // button3
            // 
            this.button3.Image = global::TintSysDesk.Properties.Resources.rec;
            this.button3.Location = new System.Drawing.Point(325, 321);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 54);
            this.button3.TabIndex = 13;
            this.button3.Text = "Excluir";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Image = global::TintSysDesk.Properties.Resources.Edit;
            this.button2.Location = new System.Drawing.Point(213, 321);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 54);
            this.button2.TabIndex = 12;
            this.button2.Text = "alterar";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = global::TintSysDesk.Properties.Resources.Add;
            this.button1.Location = new System.Drawing.Point(106, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 54);
            this.button1.TabIndex = 11;
            this.button1.Text = "Adicionar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(516, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 37);
            this.label1.TabIndex = 15;
            this.label1.Text = "Usuarios";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Residencial",
            "Comercial",
            "Entrega"});
            this.comboBox1.Location = new System.Drawing.Point(593, 156);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(235, 21);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1266, 643);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCliente);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCadastro);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.Ativo);
            this.Controls.Add(this.Cadastro);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Cpf);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.Id);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCliente";
            this.Text = "FrmCliente";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label Cpf;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Cadastro;
        private System.Windows.Forms.CheckBox Ativo;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCadastro;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Cli;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome_Cli;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cpf_Cli;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email_Cli;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datacad;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}