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
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(391, 81);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(0);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PlaceholderText = "Email ou CPF";
            this.txtUsuario.Size = new System.Drawing.Size(241, 23);
            this.txtUsuario.TabIndex = 0;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(390, 112);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(0);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.PlaceholderText = "Senha";
            this.txtSenha.Size = new System.Drawing.Size(242, 23);
            this.txtSenha.TabIndex = 1;
            // 
            // logo
            // 
            this.logo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logo.Image = global::Autentific.Properties.Resources.background;
            this.logo.Location = new System.Drawing.Point(0, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(698, 341);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 2;
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.logo_Click);
            // 
            // btnLogar
            // 
            this.btnLogar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLogar.FlatAppearance.BorderSize = 0;
            this.btnLogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogar.Location = new System.Drawing.Point(390, 147);
            this.btnLogar.Name = "btnLogar";
            this.btnLogar.Size = new System.Drawing.Size(242, 22);
            this.btnLogar.TabIndex = 3;
            this.btnLogar.Text = "LOGAR";
            this.btnLogar.UseVisualStyleBackColor = false;
            this.btnLogar.Click += new System.EventHandler(this.btnLogar_Click);
            // 
            // btnRegristo
            // 
            this.btnRegristo.FlatAppearance.BorderSize = 0;
            this.btnRegristo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegristo.Location = new System.Drawing.Point(390, 206);
            this.btnRegristo.Margin = new System.Windows.Forms.Padding(0);
            this.btnRegristo.Name = "btnRegristo";
            this.btnRegristo.Size = new System.Drawing.Size(242, 21);
            this.btnRegristo.TabIndex = 4;
            this.btnRegristo.Text = "CADASTRAR";
            this.btnRegristo.UseVisualStyleBackColor = true;
            this.btnRegristo.Click += new System.EventHandler(this.btnRegristo_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(390, 230);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.PlaceholderText = "Digite o Código";
            this.txtCodigo.Size = new System.Drawing.Size(117, 23);
            this.txtCodigo.TabIndex = 5;
            // 
            // btnValidar
            // 
            this.btnValidar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnValidar.FlatAppearance.BorderSize = 0;
            this.btnValidar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValidar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnValidar.Location = new System.Drawing.Point(527, 230);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(105, 23);
            this.btnValidar.TabIndex = 6;
            this.btnValidar.Text = "VALIDAR";
            this.btnValidar.UseVisualStyleBackColor = false;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
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
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.logo);
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
    }
}