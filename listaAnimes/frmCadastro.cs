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
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            var endereco = "server=remotemysql.com;port=3306;database=0erhhgCzuD;UID=0erhhgCzuD;password=UGVKvEHVqs";
            var conexao = new MySqlConnection(endereco);
            var comando = conexao.CreateCommand();

            comando.Connection = conexao;
            comando.CommandType = CommandType.Text;
            comando.CommandText = "INSERT INTO Usuarios(NOME, USERNAME, EMAIL, SENHA, DATA_NASC, SEXO) VALUES( @nome, @username, @email, @senha, @data_nasc, @Sexo)";
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

            try
            {
                conexao.Open();
                int linhaAfetadas = comando.ExecuteNonQuery();
                if (linhaAfetadas > 0)
                {
                    MessageBox.Show("Usuário cadastrado com sucesso!");
                    this.Close();


                }
                else
                {
                    MessageBox.Show("Ocorreu algum problema no cadastro.");
                }
                conexao.Close();
            }
            catch
            {
                MessageBox.Show("Ocorreu um erro! \nPor favor preencher todos os campos", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
