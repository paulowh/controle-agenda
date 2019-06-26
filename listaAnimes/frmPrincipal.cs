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

        }

        private void dataGridConteudo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string Opcao = "";
            if (rbnAnime.Checked == true)
            {
                Opcao = "Anime";
            }
            else if (rbnFilmes.Checked == true)
            {
                Opcao = "Filmes";
            }
            else if (rbnSeries.Checked == true)
            {
                Opcao = "Series";
            }
            else if (rbnGeral.Checked == true)
            {
                Opcao = "%%";
            }

            var endereco = "server=remotemysql.com;port=3306;database=0erhhgCzuD;UID=0erhhgCzuD;password=UGVKvEHVqs";
            var conexao = new MySqlConnection(endereco);
            var comando = conexao.CreateCommand();

            MySqlDataAdapter da = new MySqlDataAdapter("SELECT NOME, CLASSIFICACAO, ANO, GENERO, FROM CONTEUDO WHERE CLASSIFICACAO LIKE '%" + Opcao + "%'", endereco);
            DataSet ds = new DataSet();
            da.Fill(ds, "CONTEUDO");
            dataGridConteudo.DataSource = ds.Tables["CONTEUDO"].DefaultView;

        }

        private void rbnGeral_CheckedChanged(object sender, EventArgs e)
        {

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

        }
    }
}
