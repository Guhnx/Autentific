using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autentific.DAO;

namespace Autentific
{
    public partial class Relatorio : Form
    {
        public Relatorio()
        {
            InitializeComponent();
        }

        private void Relatorio_Load(object sender, EventArgs e)
        {
            this.CarregaDataGridView();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CarregaDataGridView()
        { 
            //Cria um DataGridView para listar usuários
            UsuarioDAO usuarioDao = new UsuarioDAO();
            DataSet ds = usuarioDao.GetUsuarios();
            dvgUsuarios.DataSource = ds.Tables["usuario"];
            dvgUsuarios.Refresh();
        }

        private void btnAtualiza_Click(object sender, EventArgs e)
        {
            this.CarregaDataGridView();
        }
    }
}
