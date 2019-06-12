using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

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
            
            String endereco = "server=AME0556336W10-1\\SQLEXPRESS;database=Projeto_Animes;UID=sa;password=123456";
            SqlDataAdapter da = new SqlDataAdapter("SELECT NOME, CLASSIFICACAO, ANO, GENERO, FROM CONTEUDO WHERE CLASSIFICACAO LIKE '%" + Opcao + "%'", endereco);
            DataSet ds = new DataSet();
            da.Fill(ds, "CONTEUDO");
            dataGridConteudo.DataSource = ds.Tables["CONTEUDO"].DefaultView;

        }

        private void rbnGeral_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
