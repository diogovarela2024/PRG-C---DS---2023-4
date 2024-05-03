using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsTrabalhoIndividual.Dao;

namespace WinFormsApp1
{
    public partial class FrmConsultar : Form
    {

        ClienteDAO dao;
        public FrmConsultar(ClienteDAO dao)
        {
            InitializeComponent();
            this.dao = dao;
            consultar.Text = dao.consultarClientesStr(); 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Adicionar_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
