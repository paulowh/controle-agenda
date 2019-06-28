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
            comando.CommandText = "UPDATE Usuarios SET senha= '" + txtNovaSenha.Text +"' WHERE email= '" + txtemail.Text + "'";
            //UPDATE `Usuarios` SET `nome`=[value - 1],`username`=[value - 2],`email`=[value - 3],`senha`=[value - 4],`data_nasc`=[value - 5],`sexo`=[value - 6] WHERE 1
            //comando.Parameters.AddWithValue("@email", txtemail.Text);

            conexao.Open();
            int teste = comando.ExecuteNonQuery();
            conexao.Close();
            if (teste == 0) {
                //Not updated.
                MessageBox.Show("Ouve um erro. \npor favor tente novamente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else {
                //Updated.
                MessageBox.Show("Senha Salva com sucesso", "Alteração de Senha", MessageBoxButtons.OK, MessageBoxIcon.Information);

                var email = "ph.henriq31@gmail.com";
                var nome = "Agenda Anime";
                MailAddress remente = new MailAddress(email, nome);
                MailAddress destino = new MailAddress(txtemail.Text, txtemail.Text);

                //Conteudo do email           
                MailMessage msg = new MailMessage(remente, destino);
                //Assunto
                msg.Subject = "Recuperação da Senha";

                //Campo do Texto (Colocar a senha aqui)
                msg.Body = "confirmação de alteração de senha\n\nSua senha foi alterada com sucesso para: " + txtNovaSenha.Text;


                //Fazer conexão com o email para o envio
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                //credenciais, Senha 
                smtp.Credentials = new NetworkCredential(remente.Address, "timelord");
                //envio da mensagem
                smtp.Send(msg);
                this.Close();
            }
          

            /*MySqlDataReader consulta = comando.ExecuteReader(CommandBehavior.CloseConnection);
            if (consulta.Read() == true)
            {

                conexao.Close();

                MessageBox.Show("Senha Salva com sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else if (consulta.Read() == false)
            {

                MessageBox.Show("Ouve um erro, por favor tente novamente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conexao.Close();

            }*/

            //senha nova = 123456
            //update na tabela de usuários usando como where email e passando para a senha uma senha nova
           

        }
    }
}
