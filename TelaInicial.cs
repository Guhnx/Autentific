using Autentific.Classes;
using Autentific.DAO;
using Microsoft.VisualBasic.ApplicationServices;

namespace Autentific
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void btnRegristo_Click(object sender, EventArgs e)
        {
            Registro reg = new Registro();
            reg.Show();
        }

        //Botão de login
        private void btnLogar_Click(object sender, EventArgs e)
        {
            UsuarioDAO userDAO = new UsuarioDAO();

            Usuario user = new Usuario
            {
                Email = txtUsuario.Text,
                CPF = txtUsuario.Text,
                Senha = txtSenha.Text
            };

            //Verifica se os dados digitados pertencem à um usuário cadastrado
            string retorno = userDAO.Logar(user);

            if(retorno!="NOT")
            {
                Autenticacao aut = new Autenticacao(retorno);
                aut.Show();
            }
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            //Realiza a validação do código digitado
            UsuarioDAO userDAO = new UsuarioDAO();
            Usuario user = new Usuario
            {
                Codigo = txtCodigo.Text
            };

            string resultado = userDAO.ValidarCodigo(user);

            if (resultado == "0") MessageBox.Show("Código Inválido!");
            else
            {
                //Caso o código seja válido, exibe um relatório com os dados do usuário
                Usuario resposta = new Usuario();

                resposta = userDAO.Relatorio(user).First();

                ResultadoValidacaoCodigo rel = new ResultadoValidacaoCodigo(resposta);
                rel.Show();
            }
        }

        private void logo_Click(object sender, EventArgs e)
        {

        }
    }
}