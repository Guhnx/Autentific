namespace Autentific
{
    partial class TelaInicial
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.btnLogar = new System.Windows.Forms.Button();
            this.btnRegristo = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnValidar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(413, 84);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PlaceholderText = "Email ou CPF";
            this.txtUsuario.Size = new System.Drawing.Size(201, 23);
            this.txtUsuario.TabIndex = 0;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(413, 113);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.PlaceholderText = "Senha";
            this.txtSenha.Size = new System.Drawing.Size(201, 23);
            this.txtSenha.TabIndex = 1;
            // 
            // logo
            // 
            this.logo.Image = global::Autentific.Properties.Resources.dildo_icon;
            this.logo.Location = new System.Drawing.Point(31, 32);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(309, 267);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 2;
            this.logo.TabStop = false;
            // 
            // btnLogar
            // 
            this.btnLogar.Location = new System.Drawing.Point(539, 165);
            this.btnLogar.Name = "btnLogar";
            this.btnLogar.Size = new System.Drawing.Size(75, 23);
            this.btnLogar.TabIndex = 3;
            this.btnLogar.Text = "LOGAR";
            this.btnLogar.UseVisualStyleBackColor = true;
            this.btnLogar.Click += new System.EventHandler(this.btnLogar_Click);
            // 
            // btnRegristo
            // 
            this.btnRegristo.Location = new System.Drawing.Point(413, 165);
            this.btnRegristo.Name = "btnRegristo";
            this.btnRegristo.Size = new System.Drawing.Size(112, 23);
            this.btnRegristo.TabIndex = 4;
            this.btnRegristo.Text = "CADASTRAR";
            this.btnRegristo.UseVisualStyleBackColor = true;
            this.btnRegristo.Click += new System.EventHandler(this.btnRegristo_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(413, 251);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.PlaceholderText = "Digite o Código";
            this.txtCodigo.Size = new System.Drawing.Size(112, 23);
            this.txtCodigo.TabIndex = 5;
            // 
            // btnValidar
            // 
            this.btnValidar.Location = new System.Drawing.Point(539, 251);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(75, 23);
            this.btnValidar.TabIndex = 6;
            this.btnValidar.Text = "VALIDAR";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Location = new System.Drawing.Point(371, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 267);
            this.panel1.TabIndex = 7;
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 341);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.btnRegristo);
            this.Controls.Add(this.btnLogar);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.panel1);
            this.Name = "TelaInicial";
            this.Text = "Tela Inicial";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtUsuario;
        private TextBox txtSenha;
        private PictureBox logo;
        private Button btnLogar;
        private Button btnRegristo;
        private TextBox txtCodigo;
        private Button btnValidar;
        private Panel panel1;
    }
}