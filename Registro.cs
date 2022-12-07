using Autentific.Classes;
using Autentific.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autentific
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            UsuarioDAO userDao = new UsuarioDAO();

            //Pega dados digitados e coloca no Objeto Usuario
            Usuario user = new Usuario
            {
                Nome = txtNome.Text,
                Email = txtEmail.Text,
                Celular = txtCel.Text,
                CPF = txtCpf.Text,
                Curso = txtCurso.Text,
                Senha = txtSenha.Text,
                Periodo = txtPeriodo.Text
            };

            //Insere usuário no BD
            userDao.Inserir(user);                       

            this.Close();
        }

       
    }
}
