using Autentific.Classes;
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
    public partial class ResultadoValidacaoCodigo : Form
    {
        //Exibe informaçoes do usuário caso a validação esteja correta
        private Usuario user;

        public ResultadoValidacaoCodigo(Usuario user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void ResultadoValidacaoCodigo_Load(object sender, EventArgs e)
        {
            txtCel.Text = user.Celular.Trim();
            txtCpf.Text = user.CPF.Trim();
            txtCurso.Text = user.Curso.Trim();
            txtEmail.Text = user.Email.Trim();
            txtNome.Text = user.Nome.Trim();
            txtPeriodo.Text = user.Periodo.Trim();
        }
    }
}
