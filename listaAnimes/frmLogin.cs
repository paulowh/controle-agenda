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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

            var endereco = "server=remotemysql.com;port=3306;database=0erhhgCzuD;UID=0erhhgCzuD;password=UGVKvEHVqs";
            var conexao = new MySqlConnection(endereco);
            var comando = conexao.CreateCommand();

            comando.Connection = conexao;
            comando.CommandType = CommandType.Text;
            comando.CommandText = "select * from Usuarios where username = @username and senha = @senha";
            comando.Parameters.AddWithValue("@username", txtLogin.Text);
            comando.Parameters.AddWithValue("@senha", txtSenha.Text);
            conexao.Open();
            MySqlDataReader consulta = comando.ExecuteReader(CommandBehavior.CloseConnection);
            if (consulta.Read() == true)
            {
                int usuario = consulta.GetInt32(0);
                MessageBox.Show(usuario.ToString());

                frmPrincipal frmPrincipal = new frmPrincipal();


                frmPrincipal.codigoUsuario = 10;

                //Se resultado for verdadeiro a conexão sera permitida
                conexao.Close();
                this.Close();
                

            }
            else if (consulta.Read() == false)
            {
                //Tela de Erro de senha
                MessageBox.Show("Usuário ou Senha Invalidos");
                conexao.Close();

            }
            else
            {
                MessageBox.Show("Erro no sistema");
                conexao.Close();
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkCadastrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCadastro fCadastro = new frmCadastro();
            fCadastro.ShowDialog();
        }

        private void linkEsqSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmEsqueciSenha fEsqSenha = new frmEsqueciSenha();
            fEsqSenha.ShowDialog();
        }
    }
}
