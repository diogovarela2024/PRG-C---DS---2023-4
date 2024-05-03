using WinFormsApp1.Model;
using WinFormsTrabalhoIndividual.Dao;

namespace WinFormsApp1
{
    public partial class FrmInserir : Form
    {

        ClienteDAO dao = new ClienteDAO();

        public FrmInserir()
        {
            InitializeComponent();
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Cliente obj = new Cliente();

            obj.nome = nome.Text;
            obj.nif = nif.Text;
            obj.idade = int.Parse(idade.Text);
            obj.numero = int.Parse(num.Text);


            dao.inserirCliente(obj);

            nome.Text = "";
            nif.Text = "";
            idade.Text = "";
            num.Text = "";

        }

        public ClienteDAO getDAO()
        {
            return dao;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmConsultar frmConsultar = new FrmConsultar(dao);
            frmConsultar.Show();
        }
    }
}
