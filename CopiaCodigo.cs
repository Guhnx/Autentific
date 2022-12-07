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
    public partial class CopiaCodigo : Form
    {
        //Tela de exibição do código de usuário para validação posterior
        private string valor;

        public CopiaCodigo(string valor)
        {
            InitializeComponent();
            this.valor = valor;
        }

        private void CopiaCodigo_Load(object sender, EventArgs e)
        {
            txtCodigo.Text = valor;
        }
    }
}
