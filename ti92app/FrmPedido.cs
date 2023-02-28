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
    public partial class FrmPedido : Form
    { 
        public FrmPedido()
        {
            InitializeComponent();
        }
      
        private void frmPedido_Load(object sender, EventArgs e)
        {
            cmbCliente.DataSource = Cliente.Listar();
            cmbCliente.DisplayMember = "Nome";
            cmbCliente.ValueMember = "Id";

            cmbUsuario.DataSource = Usuario.Listar();
            cmbUsuario.DisplayMember= "Nome";
            cmbUsuario.ValueMember = "Id";
        }   
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }    

        private void grbProduto_Enter(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido(
                Cliente.ObterPorId((int)cmbCliente.SelectedValue),
                Usuario.ObterPorId((int)cmbUsuario.SelectedValue)
                );
            pedido.Inserir();
            lblStatus.Text = pedido.Status.ToString() + " - " ;
            txtId.Text = pedido.Id.ToString();
        }
    }
}
