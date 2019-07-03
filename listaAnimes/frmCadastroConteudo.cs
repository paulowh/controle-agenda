using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listaAnimes
{
    public partial class frmCadastroConteudo : Form
    {
        public frmCadastroConteudo()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            var endereco = "server=remotemysql.com;port=3306;database=0erhhgCzuD;UID=0erhhgCzuD;password=UGVKvEHVqs";
            var conexao = new MySqlConnection(endereco);
            var comando = conexao.CreateCommand();

            comando.Connection = conexao;
            comando.CommandType = CommandType.Text;
            comando.CommandText = "INSERT INTO ConteudoGeral(favorito, nome, genero, classificacao, quantidadeEp, categoria, status) VALUES( '', @nome, @genero, @classificacao, @quantidadeEp, @categoria, @status)";
            //INSERT INTO ConteudoGeral(nome, genero, classificacao, quantidadeEp, categoria, status) VALUES( 'Teste', 'Terror', '+18', '150', 'Serie', 'Em andamento')
            comando.Parameters.AddWithValue("@nome", txtNome.Text);
            comando.Parameters.AddWithValue("@genero", txtGenero.Text);
            comando.Parameters.AddWithValue("@classificacao", txtClassificacao.Text);
            comando.Parameters.AddWithValue("@quantidadeEp", txtquantidadeEp.Text);
            comando.Parameters.AddWithValue("@categoria", cbxCategoria.Text);
            comando.Parameters.AddWithValue("@status", cbxStatus.Text);


            conexao.Open();

            int linhaAfetadas = comando.ExecuteNonQuery();
            if (linhaAfetadas > 0)
            {
                MessageBox.Show("Conteudo cadastrado com sucesso!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Ocorreu algum problema no cadastro.");
            }

            conexao.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
