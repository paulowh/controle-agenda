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
    public partial class TelaUsuario : Form
    {
        public TelaUsuario()
        {
            InitializeComponent();
        }
        public class Usuario
        {
            public string nome { get; set; }
            public string genero { get; set; }
            public string quantEp { get; set; }
            public string status { get; set; }
        }

        private void TelaUsuario_Load(object sender, EventArgs e)
        {
            CarregarListBox();
        }

        private void CarregarListBox()
        {
            //conexão com MySql
            var conexao = new MySqlConnection("server=remotemysql.com;port=3306;database=0erhhgCzuD;UID=0erhhgCzuD;password=UGVKvEHVqs");

            string comando = "SELECT nome from ConteudoGeral";

            MySqlCommand cmd = new MySqlCommand(comando, conexao);

            conexao.Open();

            MySqlDataReader leitor = cmd.ExecuteReader();

            while (leitor.Read())
            {
                listBox1.Items.Add(leitor["nome"].ToString());

            }

            conexao.Close();

        }

        private Usuario ObterAnimePorCodigo(string nome)
        {
            Usuario cmdUsuario = new Usuario();
            //conexão com MySql
            var conexao = new MySqlConnection("server=remotemysql.com;port=3306;database=0erhhgCzuD;UID=0erhhgCzuD;password=UGVKvEHVqs");

            string comando = "SELECT * from ConteudoGeral WHERE nome=@nome";

            MySqlCommand cmd = new MySqlCommand(comando, conexao);

            cmd.Parameters.AddWithValue("@nome", nome);

            conexao.Open();

            MySqlDataReader leitor = cmd.ExecuteReader();

            while (leitor.Read())
            {
                cmdUsuario.nome = leitor["nome"].ToString();
                cmdUsuario.genero = leitor["genero"].ToString();
                cmdUsuario.quantEp = leitor["quantidadeEp"].ToString();
                cmdUsuario.status = leitor["status"].ToString();
            }

            conexao.Close();

            return cmdUsuario;

     
        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Usuario usuario = ObterAnimePorCodigo(listBox1.SelectedItem.ToString());

            textBox1.Text = usuario.nome.ToString();
            textBox2.Text = usuario.genero.ToString();
            textBox3.Text = usuario.quantEp.ToString();
            textBox4.Text = usuario.status.ToString();
            label1.Text = usuario.nome.ToString();
            
        }
    }
}
