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
using static System.Net.Mime.MediaTypeNames;

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
            Cliente cliente = new Cliente(
                txtCpf.Text, txtNome.Text, txtEmail.Text);
            cliente.Inserir();
            txtId.Text = cliente.Id.ToString();
        }

        private void GBCliente_Enter(object sender, EventArgs e)
        {

        }
        private void GBEnd_Enter(object sender, EventArgs e)
        {

        }
        private void FrmClientes_Load(object sender, EventArgs e)
        {
            var lista = Cliente.Listar();
            int linha = 0;
            foreach (var item in lista)
            {
                dtgClientes.Rows.Add();
                dtgClientes.Rows[linha].Cells[0].Value = item.Id;
                dtgClientes.Rows[linha].Cells[1].Value = item.Nome;
                dtgClientes.Rows[linha].Cells[2].Value = item.CPF;
                dtgClientes.Rows[linha].Cells[3].Value = item.Email;
                dtgClientes.Rows[linha].Cells[4].Value = item.DataCadastro;
                dtgClientes.Rows[linha].Cells[5].Value = item.Ativo;
                linha++;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente(
            int.Parse(txtId.Text), txtNome.Text, txtCpf.Text, 
            txtEmail.Text, chkAtivo.Checked
               );
            cliente.Editar();
            MessageBox.Show("Cliente atualizado com sucesso!");
        }

        private void dtgClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dtgClientes.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNome.Text = dtgClientes.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtCpf.Text = dtgClientes.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtEmail.Text = dtgClientes.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtDatacad.Text = dtgClientes.Rows[e.RowIndex].Cells[4].Value.ToString();
            chkAtivo.Checked = Convert.ToBoolean(dtgClientes.Rows[e.RowIndex].Cells[5].Value); ;
            chkAtivo.Enabled = true;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
