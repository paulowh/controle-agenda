using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listaAnimes
{
    public partial class frmTelaUsuario : Form
    {
        public frmTelaUsuario()
        {
            InitializeComponent();
        }

        private void btnAdiconar_Click(object sender, EventArgs e)
        {
            frmCadastroConteudo fCConteudo = new frmCadastroConteudo();
            fCConteudo.ShowDialog();
        }
    }
}
