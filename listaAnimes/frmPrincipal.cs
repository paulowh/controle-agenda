using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace listaAnimes
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmCadastroConteudo fCContudo = new frmCadastroConteudo();
            fCContudo.ShowDialog();
        }

        private void dataGridConteudo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void rbnGeral_CheckedChanged(object sender, EventArgs e)
        {
            string pesquisa = txtPesquisar.Text;
            CarregarLista(pesquisa);
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            //Minimiza o forme "Principal"
            this.Hide();
            //Abrir o forme de login
            frmLogin fLogin = new frmLogin();
            fLogin.ShowDialog();

            string pesquisa = "";
            CarregarLista(pesquisa);

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            
        }

        private void rbnAnime_CheckedChanged(object sender, EventArgs e)
        {
            string pesquisa = "anime";
            CarregarLista(pesquisa);
        }

        private void rbnFilmes_CheckedChanged(object sender, EventArgs e)
        {
            string pesquisa = "filme";
            CarregarLista(pesquisa);
        }

        private void rbnSeries_CheckedChanged(object sender, EventArgs e)
        {
            string pesquisa = "serie";
            CarregarLista(pesquisa);
        }

        private void btnAdcionarMinhaLista_Click(object sender, EventArgs e)
        {

            Form1 fform = new Form1("guto");
            fform.Show();
        }

        private void dataGridConteudo_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void CarregarLista(string pesquisa)
        {
            var endereco = "server=remotemysql.com;port=3306;database=0erhhgCzuD;UID=0erhhgCzuD;password=UGVKvEHVqs";
            var conexao = new MySqlConnection(endereco);
                        
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT nome, genero, classificacao, quantidadeEp, categoria, status FROM ConteudoGeral WHERE categoria LIKE '%" + pesquisa + "%'", endereco);
            DataSet ds = new DataSet();
            da.Fill(ds, "ConteudoGeral");
            dataGridConteudo.DataSource = ds.Tables["ConteudoGeral"].DefaultView;
        }
    }
}

