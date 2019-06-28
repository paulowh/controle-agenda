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
using System.Net.Mail;
using System.Net;


namespace listaAnimes
{
    public partial class frmEsqueciSenha : Form
    {
        public frmEsqueciSenha()
        {
            InitializeComponent();
        }

        private void frmEsqueciSenha_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            var endereco = "server=remotemysql.com;port=3306;database=0erhhgCzuD;UID=0erhhgCzuD;password=UGVKvEHVqs";
            var conexao = new MySqlConnection(endereco);
            var comando = conexao.CreateCommand();

            comando.Connection = conexao;
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT senha FROM Usuarios WHERE username LIKE @username";
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT senha FROM Usuarios WHERE username @usurname", endereco);
            DataSet ds = new DataSet();
            
            //MySqlDataAdapter da = new MySqlDataAdapter("SELECT nome, genero, classificacao, quantidadeEp, categoria, status FROM ConteudoGeral WHERE categoria LIKE '%" + pesquisa + "%'", endereco);
            comando.Parameters.AddWithValue("@username", txtUsernameES.Text);
            conexao.Open();
            MySqlDataReader consulta = comando.ExecuteReader(CommandBehavior.CloseConnection);
            if (consulta.Read() == true)
            {
                //Se resultado for verdadeiro a conexão sera permitida
                conexao.Close();

                MessageBox.Show("OK"+ da, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else if (consulta.Read() == false)
            {
                //Tela de Erro de senha
                MessageBox.Show("Não foi encontrado nenhum Usuario correspondente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conexao.Close();

            }
            else
            {
                MessageBox.Show("Erro no sistema");
                conexao.Close();
            }
            /*
            var email = "ph.henriq31@gmail.com";
            var nome = "Agenda Anime";
            MailAddress remente = new MailAddress(email, nome);
            MailAddress destino = new MailAddress(txtemail.Text, txtemail.Text);

            //Conteudo do email           
            MailMessage msg = new MailMessage(remente, destino);
            //Assunto
            msg.Subject = "Recuperação da Senha";



            //Campo do Texto (Colocar a senha aqui)
            msg.Body = "Aqui esta sua senha de acesso";

            //Fazer conexão com o email para o envio
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            //credenciais, Senha 
            smtp.Credentials = new NetworkCredential(remente.Address, "timelord");
            //envio da mensagem
            smtp.Send(msg);
            */
        }
    }
}
