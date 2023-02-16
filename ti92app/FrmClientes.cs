using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ti92class;

namespace ti92app
{
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            //Cliente cliente = new Cliente(
            //    txtCpf.Text, txtDatacad.Text, txtNome.Text, txtEmail.Text);
            //cliente.Inserir();
            //txtId.Text = cliente.Id.ToString();
        }

        private void GBCliente_Enter(object sender, EventArgs e)
        {

        }
        private void GBEnd_Enter(object sender, EventArgs e)
        {

        }
        private void FrmClientes_Load(object sender, EventArgs e)
        {

        }
    }
}
