using MySql.Data.MySqlClient;
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

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            var endereco = "server=remotemysql.com;port=3306;database=0erhhgCzuD;UID=0erhhgCzuD;password=UGVKvEHVqs";
            var conexao = new MySqlConnection(endereco);

            string pesquisa = "";

            MySqlDataAdapter da = new MySqlDataAdapter("SELECT nome, genero, classificacao, quantidadeEp, categoria, status FROM ConteudoGeral WHERE categoria LIKE '%" + pesquisa + "%'", endereco);
            DataSet ds = new DataSet();
            da.Fill(ds, "ConteudoGeral");
            dataGridConteudo.DataSource = ds.Tables["ConteudoGeral"].DefaultView;
        }
    }
}
