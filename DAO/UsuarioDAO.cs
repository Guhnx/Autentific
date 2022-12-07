using Autentific.Classes;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Autentific.DAO
{
    public class UsuarioDAO
    {        
        //Inicializa a conexao com o BD padrão
        private static DbCommand IniciaDao()
        {
            DbConnection conexao = DAOUtils.GetConexao();
            DbCommand comando = DAOUtils.GetComando(conexao);
            comando.CommandType = CommandType.Text;

            return comando;
        }

        //Obtém lista completa de usuários do BD
        public DataSet GetUsuarios()
        {
            DbCommand comando = IniciaDao();
            comando.CommandText = "SELECT * FROM usuario";

            DbDataAdapter adapter = new SqlDataAdapter((SqlCommand)comando);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "usuario");

            return ds;
           
        }

        //Gera uma lista com os dados do usuário validado
        public List<Usuario> Relatorio (Usuario user)
        {
            DbCommand comando = IniciaDao();
            comando.CommandText = "SELECT * FROM usuario WHERE cod_autentic_us=@codigo_us";
            comando.Parameters.Add(new SqlParameter("@codigo_us", user.Codigo));
            DbDataReader resultado = comando.ExecuteReader();

            var list = new List<Usuario>();

            while (resultado.Read())
            {
                //Console.WriteLine(String.Format("{0}", reader[0]));
                list.Add(new Usuario
                {                   
                    Nome = resultado.GetString(1),
                    Email= resultado.GetString(2),
                    CPF= resultado.GetString(3),
                    Celular = resultado.GetString(4),
                    Curso= resultado.GetString(5),
                    Codigo= resultado.GetString(7),
                    Periodo = resultado.GetString(8),
                }
                );
            }

            return list;
        }

       
        public void Inserir(Usuario user)
        {
            //Insere no BD o usuário do formulário de cadastro
            DbCommand comando = IniciaDao();            
            comando.CommandText = "INSERT INTO usuario (nome_us, email_us, cpf_us, cel_us, curso_us, periodo_us, senha_us) VALUES (@nome_us, @email_us, @cpf_us, @cel_us, @curso_us, @periodo_us, @senha_us)";
            comando.Parameters.Add(new SqlParameter("@nome_us", user.Nome));
            comando.Parameters.Add(new SqlParameter("@email_us", user.Email));
            comando.Parameters.Add(new SqlParameter("@cpf_us", user.CPF));
            comando.Parameters.Add(new SqlParameter("@cel_us", user.Celular));
            comando.Parameters.Add(new SqlParameter("@curso_us", user.Curso));
            comando.Parameters.Add(new SqlParameter("@periodo_us", user.Periodo));
            comando.Parameters.Add(new SqlParameter("@senha_us", user.Senha));

            comando.ExecuteNonQuery();
        }
        public void Atualizar(Usuario user)
        {
            //Atualiza o usuário no BD com o novo código de autenticação
            DbCommand comando = IniciaDao();
            comando.CommandText = "UPDATE usuario SET cod_autentic_us=@codigo_us WHERE cpf_us=@cpf_us";
            comando.Parameters.Add(new SqlParameter("@codigo_us", user.Codigo));
            comando.Parameters.Add(new SqlParameter("@cpf_us", user.CPF));

            comando.ExecuteNonQuery();
        }

        public string Validar(Usuario user)
        {
            //Valida os dados digitados para erar o código de autenticação
            DbCommand comando = IniciaDao();
            comando.CommandText = "SELECT COUNT (*) FROM usuario WHERE cpf_us=@cpf_us AND curso_us=@curso_us";
            comando.Parameters.Add(new SqlParameter("@cpf_us", user.CPF));
            comando.Parameters.Add(new SqlParameter("@curso_us", user.Curso));
            return comando.ExecuteScalar().ToString();
        }

        public string ValidarCodigo(Usuario user)
        {
            //Confere se o código digtado existe no BD
            DbCommand comando = IniciaDao();
            comando.CommandText = "SELECT COUNT (*) FROM usuario WHERE cod_autentic_us=@codigo_us";
            comando.Parameters.Add(new SqlParameter("@codigo_us", user.Codigo));

            if (comando.ExecuteScalar() == null)
            {
                MessageBox.Show("Usuário inválido, tente novamente!");
                return "NOT";
            }
            else
            {
                return comando.ExecuteScalar().ToString();
            }
        }

        public string Logar(Usuario user)
        {
            //Confere se os dados do usuário estão corretos ao realizar o login
            DbCommand comando = IniciaDao();
            comando.CommandText = "SELECT * FROM usuario WHERE (email_us=@email_us OR cpf_us=@cpf_us) AND senha_us=@senha_us";
            comando.Parameters.Add(new SqlParameter("@email_us", user.Email));
            comando.Parameters.Add(new SqlParameter("@cpf_us", user.CPF));
            comando.Parameters.Add(new SqlParameter("@senha_us", user.Senha));

            string resultado;

            if (comando.ExecuteScalar() == null)
            {
                MessageBox.Show("Usuário inválido, tente novamente!");
                return "NOT";
            }
            else
            {
                //Se tudo estiver correto
                resultado = comando.ExecuteScalar().ToString();
                return resultado;
            }
        }
    }
}
