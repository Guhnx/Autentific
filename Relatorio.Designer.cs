namespace Autentific
{
    partial class Relatorio
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
            this.dvgUsuarios = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autenticação = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Senha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFechar = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Período = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAtualiza = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvgUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgUsuarios
            // 
            this.dvgUsuarios.AllowUserToAddRows = false;
            this.dvgUsuarios.AllowUserToDeleteRows = false;
            this.dvgUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvgUsuarios.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dvgUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dvgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.Autenticação,
            this.Senha});
            this.dvgUsuarios.Location = new System.Drawing.Point(12, 40);
            this.dvgUsuarios.MultiSelect = false;
            this.dvgUsuarios.Name = "dvgUsuarios";
            this.dvgUsuarios.ReadOnly = true;
            this.dvgUsuarios.RowTemplate.Height = 25;
            this.dvgUsuarios.Size = new System.Drawing.Size(576, 324);
            this.dvgUsuarios.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_us";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 43;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nome_us";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 65;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "cpf_us";
            this.dataGridViewTextBoxColumn3.HeaderText = "CPF";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 53;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "email_us";
            this.dataGridViewTextBoxColumn4.HeaderText = "Email";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 61;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "cel_us";
            this.dataGridViewTextBoxColumn5.HeaderText = "Celular";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 69;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "curso_us";
            this.dataGridViewTextBoxColumn6.HeaderText = "Curso";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 63;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "periodo_us";
            this.dataGridViewTextBoxColumn7.HeaderText = "Período";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 73;
            // 
            // Autenticação
            // 
            this.Autenticação.DataPropertyName = "cod_autentic_us";
            this.Autenticação.HeaderText = "Autenticação";
            this.Autenticação.Name = "Autenticação";
            this.Autenticação.ReadOnly = true;
            this.Autenticação.Width = 102;
            // 
            // Senha
            // 
            this.Senha.DataPropertyName = "senha_us";
            this.Senha.HeaderText = "Senha";
            this.Senha.Name = "Senha";
            this.Senha.ReadOnly = true;
            this.Senha.Visible = false;
            this.Senha.Width = 64;
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(295, 370);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(114, 43);
            this.btnFechar.TabIndex = 2;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id_us";
            this.ID.HeaderText = "Id";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            this.ID.Width = 42;
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Nome.DataPropertyName = "nome_us";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // CPF
            // 
            this.CPF.DataPropertyName = "cpf_us";
            this.CPF.HeaderText = "CPF";
            this.CPF.Name = "CPF";
            this.CPF.Width = 53;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Email.DataPropertyName = "email_us";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // Celular
            // 
            this.Celular.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Celular.DataPropertyName = "cel_us";
            this.Celular.HeaderText = "Celular";
            this.Celular.Name = "Celular";
            // 
            // Curso
            // 
            this.Curso.DataPropertyName = "curso_us";
            this.Curso.HeaderText = "Curso";
            this.Curso.Name = "Curso";
            this.Curso.Width = 63;
            // 
            // Período
            // 
            this.Período.DataPropertyName = "periodo_us";
            this.Período.HeaderText = "Período";
            this.Período.Name = "Período";
            this.Período.Width = 73;
            // 
            // btnAtualiza
            // 
            this.btnAtualiza.Location = new System.Drawing.Point(175, 370);
            this.btnAtualiza.Name = "btnAtualiza";
            this.btnAtualiza.Size = new System.Drawing.Size(114, 43);
            this.btnAtualiza.TabIndex = 3;
            this.btnAtualiza.Text = "Atualizar";
            this.btnAtualiza.UseVisualStyleBackColor = true;
            this.btnAtualiza.Click += new System.EventHandler(this.btnAtualiza_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Autentific.Properties.Resources.Dark_Grey_and_White_Minimalist_Website_Register_Desktop_Prototype_1__copiar;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(592, 437);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // Relatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 437);
            this.Controls.Add(this.btnAtualiza);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.dvgUsuarios);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Relatorio";
            this.Text = "Relatorio";
            this.Load += new System.EventHandler(this.Relatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dvgUsuarios;
        private Button btnFechar;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn CPF;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Celular;
        private DataGridViewTextBoxColumn Curso;
        private DataGridViewTextBoxColumn Período;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn Autenticação;
        private DataGridViewTextBoxColumn Senha;
        private Button btnAtualiza;
        private PictureBox pictureBox1;
    }
}