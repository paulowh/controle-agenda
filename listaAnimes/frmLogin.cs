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
            string endereco = "server=Paulo-Not\\SQLEXPRESS;database=Projeto_Animes;UID=sa;password=123456";
            SqlConnection conexao = new SqlConnection(endereco);
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandType = CommandType.Text;
            comando.CommandText = "select * from Usuario where username = @username and senha = @senha";
            comando.Parameters.AddWithValue("@username", txtLogin.Text);
            comando.Parameters.AddWithValue("@senha", txtSenha.Text);
            conexao.Open();
            SqlDataReader consulta = comando.ExecuteReader(CommandBehavior.CloseConnection);
            if (consulta.Read() == true)
            {
                conexao.Close();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário ou Senha Invalidos");
                conexao.Close();

            }



        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkCadastrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCadastro fCadastro = new frmCadastro();
            fCadastro.ShowDialog();
        }
    }
}
