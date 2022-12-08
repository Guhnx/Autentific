namespace Autentific
{
    partial class Autenticacao
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.btnValida = new System.Windows.Forms.Button();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(275, 29);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(242, 21);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "FAÇA A VALIDAÇÃO DOS DADOS";
            // 
            // txtCurso
            // 
            this.txtCurso.Location = new System.Drawing.Point(262, 68);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.PlaceholderText = "Curso";
            this.txtCurso.Size = new System.Drawing.Size(267, 23);
            this.txtCurso.TabIndex = 1;
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(302, 97);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.PlaceholderText = "CPF";
            this.txtCpf.Size = new System.Drawing.Size(178, 23);
            this.txtCpf.TabIndex = 2;
            // 
            // btnValida
            // 
            this.btnValida.Location = new System.Drawing.Point(348, 138);
            this.btnValida.Name = "btnValida";
            this.btnValida.Size = new System.Drawing.Size(93, 42);
            this.btnValida.TabIndex = 4;
            this.btnValida.Text = "VALIDAR";
            this.btnValida.UseVisualStyleBackColor = true;
            this.btnValida.Click += new System.EventHandler(this.btnValida_Click);
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.Location = new System.Drawing.Point(534, 199);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(119, 40);
            this.btnRelatorio.TabIndex = 5;
            this.btnRelatorio.Text = "Gerar Relatório";
            this.btnRelatorio.UseVisualStyleBackColor = true;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(669, 199);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(119, 40);
            this.btnFechar.TabIndex = 6;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Autentific.Properties.Resources.Dark_Grey_and_White_Minimalist_Website_Register_Desktop_Prototype_1__copiar;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 251);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // Autenticacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 251);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnRelatorio);
            this.Controls.Add(this.btnValida);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtCurso);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Autenticacao";
            this.Text = "Autenticacao";
            this.Load += new System.EventHandler(this.Autenticacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitulo;
        private TextBox txtCurso;
        private TextBox txtCpf;
        private Button btnValida;
        private Button btnRelatorio;
        private Button btnFechar;
        private PictureBox pictureBox1;
    }
}