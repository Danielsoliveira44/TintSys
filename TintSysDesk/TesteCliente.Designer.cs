namespace TintSysDesk
{
    partial class TesteCliente
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
            this.BtnInserir = new System.Windows.Forms.Button();
            this.BtnInsere = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pnInserir = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // BtnInserir
            // 
            this.BtnInserir.Location = new System.Drawing.Point(320, 27);
            this.BtnInserir.Name = "BtnInserir";
            this.BtnInserir.Size = new System.Drawing.Size(75, 23);
            this.BtnInserir.TabIndex = 1;
            this.BtnInserir.Text = "button1";
            this.BtnInserir.UseVisualStyleBackColor = true;
            this.BtnInserir.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnInsere
            // 
            this.BtnInsere.Location = new System.Drawing.Point(509, 27);
            this.BtnInsere.Name = "BtnInsere";
            this.BtnInsere.Size = new System.Drawing.Size(75, 23);
            this.BtnInsere.TabIndex = 2;
            this.BtnInsere.Text = "b";
            this.BtnInsere.UseVisualStyleBackColor = true;
            this.BtnInsere.Click += new System.EventHandler(this.BtnInsere_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(697, 27);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // pnInserir
            // 
            this.pnInserir.Location = new System.Drawing.Point(258, 321);
            this.pnInserir.Name = "pnInserir";
            this.pnInserir.Size = new System.Drawing.Size(200, 100);
            this.pnInserir.TabIndex = 4;
            this.pnInserir.Paint += new System.Windows.Forms.PaintEventHandler(this.pnInserir_Paint);
            // 
            // TesteCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 641);
            this.Controls.Add(this.pnInserir);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.BtnInsere);
            this.Controls.Add(this.BtnInserir);
            this.Name = "TesteCliente";
            this.Text = "TesteCliente";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnInserir;
        private System.Windows.Forms.Button BtnInsere;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel pnInserir;
    }
}