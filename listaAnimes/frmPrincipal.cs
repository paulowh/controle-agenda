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
        string codigo;
        public int codigoUsuario;

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
            string pesquisa = "";
            CarregarLista(pesquisa);
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            
            //Minimiza o forme "Principal"
            this.Hide();
            //Abrir o forme de login
            frmLogin fLogin = new frmLogin();

            fLogin.ShowDialog();

            //MessageBox.Show(codigoUsuario.ToString() + " -------------  ");

            string pesquisa = "";
            CarregarLista(pesquisa);
            
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            var endereco = "server=remotemysql.com;port=3306;database=0erhhgCzuD;UID=0erhhgCzuD;password=UGVKvEHVqs";
            var conexao = new MySqlConnection(endereco);
            string pesquisa = txtPesquisar.Text;

            MySqlDataAdapter da = new MySqlDataAdapter("SELECT  nome, genero, classificacao, quantidadeEp, categoria, status,  FROM ConteudoGeral WHERE nome LIKE '%" + pesquisa + "%'", endereco);
            DataSet ds = new DataSet();
            da.Fill(ds, "ConteudoGeral");
            dataGridConteudo.DataSource = ds.Tables["ConteudoGeral"].DefaultView;
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

            AtualizarLista(codigo);
            MessageBox.Show(codigo);

        }

        private void dataGridConteudo_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            codigo = dataGridConteudo[0, e.RowIndex].Value.ToString();
            AtualizarLista(codigo);


        }

        private void CarregarLista(string pesquisa)
        {
            var endereco = "server=remotemysql.com;port=3306;database=0erhhgCzuD;UID=0erhhgCzuD;password=UGVKvEHVqs";
            var conexao = new MySqlConnection(endereco);

            MySqlDataAdapter da = new MySqlDataAdapter("SELECT codigo, nome, genero, classificacao, quantidadeEp, categoria, status FROM ConteudoGeral WHERE categoria LIKE '%" + pesquisa + "%'", endereco);
            DataSet ds = new DataSet();
            da.Fill(ds, "ConteudoGeral");
            dataGridConteudo.DataSource = ds.Tables["ConteudoGeral"].DefaultView;
        }

        private void btnMeuConteudo_Click(object sender, EventArgs e)
        {

        }

        private void AtualizarLista(string codigo)
        {
            var endereco = "server=remotemysql.com;port=3306;database=0erhhgCzuD;UID=0erhhgCzuD;password=UGVKvEHVqs";
            var conexao = new MySqlConnection(endereco);
            var comando = conexao.CreateCommand();


            comando.Connection = conexao;
            comando.CommandType = CommandType.Text;
            comando.CommandText = "UPDATE ConteudoGeral SET favorito = 'sim' WHERE codigo= '" + codigo + "'";

            conexao.Open();
            int teste = comando.ExecuteNonQuery();
            conexao.Close();
            if (teste == 0)
            {
                //Not updated.
                MessageBox.Show("Ouve um erro. \npor favor tente novamente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else
            {
                //Updated.
                MessageBox.Show("Adicionado ao favorito com SUCESSO!!!", "Alteração de Senha", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void dataGridConteudo_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            codigo = dataGridConteudo[0, e.RowIndex].Value.ToString();

        }

        private void rdbFavorito_CheckedChanged(object sender, EventArgs e)
        {
            string pesquisa = "sim";
            var endereco = "server=remotemysql.com;port=3306;database=0erhhgCzuD;UID=0erhhgCzuD;password=UGVKvEHVqs";
            var conexao = new MySqlConnection(endereco);

            MySqlDataAdapter da = new MySqlDataAdapter("SELECT codigo, nome, genero, classificacao, quantidadeEp, categoria, status FROM ConteudoGeral WHERE favorito LIKE '%" + pesquisa + "%'", endereco);
            DataSet ds = new DataSet();
            da.Fill(ds, "ConteudoGeral");
            dataGridConteudo.DataSource = ds.Tables["ConteudoGeral"].DefaultView;
        }
    }
 }


