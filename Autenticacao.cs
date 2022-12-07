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
    public partial class Autenticacao : Form
    {
        private Usuario user;
        private string retorno;

        public Autenticacao(string retorno)
        {
            InitializeComponent();
            this.retorno = retorno;
        }

        private void Autenticacao_Load(object sender, EventArgs e)
        {

        }

        //Realiza validação dos dados para gerar código
        private void btnValida_Click(object sender, EventArgs e)
        {
            if (txtCpf.Text == "" || txtCpf.Text.Length < 11) MessageBox.Show("CPF Inválido");
            else if (txtCurso.Text == "" || txtCurso.Text.Length < 3) MessageBox.Show("Curso Inválido");
            else
            {
                //Gera ódigo de autenticação aleatório
                Random codigo = new Random();
                string valor = codigo.Next().ToString();

                UsuarioDAO userDAO = new UsuarioDAO();

                Usuario user1 = new Usuario
                {
                    CPF = txtCpf.Text,
                    Curso = txtCurso.Text
                };

                //Verifica se os dados informados são de um usuário válido
                string retornmo = userDAO.Validar(user1);

                if (retornmo == "0") MessageBox.Show("Dados Inválidos. Tente novamente...");
                else
                {
                    Usuario user = new Usuario
                    {
                        Codigo = valor,
                        CPF = txtCpf.Text
                    };

                    //Atualiza usuário com o código gerado
                    userDAO.Atualizar(user);

                    CopiaCodigo copia = new CopiaCodigo(valor);
                    copia.Show();
                }

            }
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            Relatorio rel = new Relatorio();
            rel.Show();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
