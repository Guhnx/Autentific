namespace Autentific
{
    partial class Registro
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txtCel = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.txtPeriodo = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(61, 45);
            this.txtNome.Name = "txtNome";
            this.txtNome.PlaceholderText = "Nome Completo";
            this.txtNome.Size = new System.Drawing.Size(361, 23);
            this.txtNome.TabIndex = 0;
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(61, 93);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.PlaceholderText = "000.000.000-00";
            this.txtCpf.Size = new System.Drawing.Size(163, 23);
            this.txtCpf.TabIndex = 1;
            // 
            // txtCel
            // 
            this.txtCel.Location = new System.Drawing.Point(259, 93);
            this.txtCel.Name = "txtCel";
            this.txtCel.PlaceholderText = "(xx) xxxxxxxxx";
            this.txtCel.Size = new System.Drawing.Size(163, 23);
            this.txtCel.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(61, 144);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderText = "Seu e-mail";
            this.txtEmail.Size = new System.Drawing.Size(361, 23);
            this.txtEmail.TabIndex = 3;
            // 
            // txtCurso
            // 
            this.txtCurso.Location = new System.Drawing.Point(61, 200);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.PlaceholderText = "Curso";
            this.txtCurso.Size = new System.Drawing.Size(249, 23);
            this.txtCurso.TabIndex = 4;
            // 
            // txtPeriodo
            // 
            this.txtPeriodo.Location = new System.Drawing.Point(331, 200);
            this.txtPeriodo.Name = "txtPeriodo";
            this.txtPeriodo.PlaceholderText = "Período";
            this.txtPeriodo.Size = new System.Drawing.Size(91, 23);
            this.txtPeriodo.TabIndex = 5;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(61, 254);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.PlaceholderText = "Senha";
            this.txtSenha.Size = new System.Drawing.Size(163, 23);
            this.txtSenha.TabIndex = 6;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(137, 319);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(87, 33);
            this.btnCadastrar.TabIndex = 7;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(242, 319);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(87, 33);
            this.btnVoltar.TabIndex = 8;
            this.btnVoltar.Text = "Cancelar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 400);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtPeriodo);
            this.Controls.Add(this.txtCurso);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtCel);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtNome);
            this.Name = "Registro";
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Registro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtNome;
        private TextBox txtCpf;
        private TextBox txtCel;
        private TextBox txtEmail;
        private TextBox txtCurso;
        private TextBox txtPeriodo;
        private TextBox txtSenha;
        private Button btnCadastrar;
        private Button btnVoltar;
    }
}