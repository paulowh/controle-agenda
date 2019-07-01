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
            var endereco = "server=remotemysql.com;port=3306;database=0erhhgCzuD;UID=0erhhgCzuD;password=UGVKvEHVqs";
            var conexao = new MySqlConnection(endereco);

            string pesquisa = "";

            MySqlDataAdapter da = new MySqlDataAdapter("SELECT nome, genero, classificacao, quantidadeEp, categoria, status FROM ConteudoGeral WHERE categoria LIKE '%" + pesquisa + "%'", endereco);
            DataSet ds = new DataSet();
            da.Fill(ds, "ConteudoGeral");
            dataGridConteudo.DataSource = ds.Tables["ConteudoGeral"].DefaultView;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            //Minimiza o forme "Principal"
            this.Hide();
            //Abrir o forme de login
            frmLogin fLogin = new frmLogin();
            fLogin.ShowDialog();


        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {


            var endereco = "server=remotemysql.com;port=3306;database=0erhhgCzuD;UID=0erhhgCzuD;password=UGVKvEHVqs";
            var conexao = new MySqlConnection(endereco);

            string pesquisa = txtPesquisar.Text;

            MySqlDataAdapter da = new MySqlDataAdapter("SELECT nome, genero, classificacao, quantidadeEp, categoria, status FROM ConteudoGeral WHERE nome LIKE '%"+ pesquisa + "%'", endereco);
            DataSet ds = new DataSet();
            da.Fill(ds, "ConteudoGeral");
            dataGridConteudo.DataSource = ds.Tables["ConteudoGeral"].DefaultView;
        }

        private void rbnAnime_CheckedChanged(object sender, EventArgs e)
        {
            var endereco = "server=remotemysql.com;port=3306;database=0erhhgCzuD;UID=0erhhgCzuD;password=UGVKvEHVqs";
            var conexao = new MySqlConnection(endereco);

            string pesquisa = "Anime";

            MySqlDataAdapter da = new MySqlDataAdapter("SELECT nome, genero, classificacao, quantidadeEp, categoria, status FROM ConteudoGeral WHERE categoria LIKE '%" + pesquisa + "%'", endereco);
            DataSet ds = new DataSet();
            da.Fill(ds, "ConteudoGeral");
            dataGridConteudo.DataSource = ds.Tables["ConteudoGeral"].DefaultView;
        }

        private void rbnFilmes_CheckedChanged(object sender, EventArgs e)
        {
            var endereco = "server=remotemysql.com;port=3306;database=0erhhgCzuD;UID=0erhhgCzuD;password=UGVKvEHVqs";
            var conexao = new MySqlConnection(endereco);

            string pesquisa = "Filme";

            MySqlDataAdapter da = new MySqlDataAdapter("SELECT nome, genero, classificacao, quantidadeEp, categoria, status FROM ConteudoGeral WHERE categoria LIKE '%" + pesquisa + "%'", endereco);
            DataSet ds = new DataSet();
            da.Fill(ds, "ConteudoGeral");
            dataGridConteudo.DataSource = ds.Tables["ConteudoGeral"].DefaultView;
        }

        private void rbnSeries_CheckedChanged(object sender, EventArgs e)
        {
            var endereco = "server=remotemysql.com;port=3306;database=0erhhgCzuD;UID=0erhhgCzuD;password=UGVKvEHVqs";
            var conexao = new MySqlConnection(endereco);

            string pesquisa = "Serie";

            MySqlDataAdapter da = new MySqlDataAdapter("SELECT nome, genero, classificacao, quantidadeEp, categoria, status FROM ConteudoGeral WHERE categoria LIKE '%" + pesquisa + "%'", endereco);
            DataSet ds = new DataSet();
            da.Fill(ds, "ConteudoGeral");
            dataGridConteudo.DataSource = ds.Tables["ConteudoGeral"].DefaultView;
        }

        private void btnAdcionarMinhaLista_Click(object sender, EventArgs e)
        {

            Form1 fform = new Form1("guto");
            fform.Show();
        }
    }
}

