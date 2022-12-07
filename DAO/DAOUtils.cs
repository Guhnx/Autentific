using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autentific.DAO
{
    public class DAOUtils
    {
        public static DbConnection GetConexao()
        {   
            //Inicializa Conexão com o BD
            DbConnection conexao = new SqlConnection(@"Server=.\SQLEXPRESS;Database=Autentific;User Id=sa;Password=life123;");
            conexao.Open();
            return conexao;
        }

        public static DbCommand GetComando(DbConnection conexao)
        {
            DbCommand comando = conexao.CreateCommand();
            return comando;
        }

        public static DbDataReader GetDataReader(DbCommand comando)
        {
            return comando.ExecuteReader();
        }
    }
}
