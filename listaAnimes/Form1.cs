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
    public partial class Form1 : Form
    {
        string meuNome;
        public Form1(string nome)
        {
            InitializeComponent();
            meuNome = nome;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show(meuNome);
        }
    }
}
