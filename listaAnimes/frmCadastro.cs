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
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            String endereco = "server=Paulo-Not\\SQLEXPRESS;database=Projeto_Animes;UID=sa;password=123456";
            SqlConnection conexao = new SqlConnection(endereco);
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = "INSERT INTO USUARIOS(NOME, USERNAME, EMAIL, SENHA, DATA_NASC, SEXO) VALUES( @nome, @username, @email, @senha, @data_nasc, @Sexo)";
            comando.Parameters.AddWithValue("@nome", txtNome.Text);
            comando.Parameters.AddWithValue("@username", txtUsername.Text);
            comando.Parameters.AddWithValue("@email", txtEmail.Text);
            comando.Parameters.AddWithValue("@senha", txtSenha.Text);
            comando.Parameters.AddWithValue("@data_nasc", datNascimento.Value);
            if (rdbMasculino.Checked == true)
            {
                comando.Parameters.AddWithValue("@sexo", "M");
            }
            else if (rdbFeminino.Checked == true)
            {
                comando.Parameters.AddWithValue("@sexo", "F");
            }
            else
            {
                comando.Parameters.AddWithValue("@sexo", "");
            }


            conexao.Open();
            int linhaAfetadas = comando.ExecuteNonQuery();
            if (linhaAfetadas > 0)
            {
                MessageBox.Show("Usuário cadastrado com sucesso!");
            }
            else
            {
                MessageBox.Show("Ocorreu algum problema no cadastro.");
            }
            conexao.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
