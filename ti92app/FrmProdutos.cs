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
    public partial class FrmProdutos : Form
    {
        public FrmProdutos()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FrmProdutos_Load(object sender, EventArgs e)
        {
            var lista = Produto.Listar();
            int linha = 0;
            foreach (var item in lista)
            {
                dtgProdutos.Rows.Add();
                dtgProdutos.Rows[linha].Cells[0].Value = item.Id;
                dtgProdutos.Rows[linha].Cells[1].Value = item.CodBar;
                dtgProdutos.Rows[linha].Cells[2].Value = item.Descricao;
                dtgProdutos.Rows[linha].Cells[3].Value = item.Unidade;
                dtgProdutos.Rows[linha].Cells[4].Value = item.Preco;
                dtgProdutos.Rows[linha].Cells[5].Value = item.Desconto;
                dtgProdutos.Rows[linha].Cells[6].Value = item.Descontinuado;
                linha++;
            }
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto(
                    TEXTCODBAR.Text, TEXTDESCRICAO.Text, CMBUNIDADE.Text,  double.Parse(MSKPRECO.Text), double.Parse(MASKDESCONTO.Text));
            produto.Inserir();
            textId.Text = produto.Id.ToString();
        }

        private void dtgProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textId.Text = dtgProdutos.Rows[e.RowIndex].Cells[0].Value.ToString();
            TEXTCODBAR.Text = dtgProdutos.Rows[e.RowIndex].Cells[1].Value.ToString();
            TEXTDESCRICAO.Text = dtgProdutos.Rows[e.RowIndex].Cells[2].Value.ToString();
            CMBUNIDADE.Text = dtgProdutos.Rows[e.RowIndex].Cells[3].Value.ToString();
            MSKPRECO.Text = dtgProdutos.Rows[e.RowIndex].Cells[4].Value.ToString();
            MASKDESCONTO.Text = dtgProdutos.Rows[e.RowIndex].Cells[5].Value.ToString();
            chkDescontinuado.Checked = Convert.ToBoolean(dtgProdutos.Rows[e.RowIndex].Cells[6].Value); ;
            chkDescontinuado.Enabled = true;

        }

        private void Editar_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto(
            int.Parse(textId.Text),                
                TEXTDESCRICAO.Text,                
                CMBUNIDADE.Text,
                TEXTCODBAR.Text,
                double.Parse(MSKPRECO.Text),
                double.Parse(MASKDESCONTO.Text),
                chkDescontinuado.Checked);
            produto.Editar();
            MessageBox.Show("Produto atualizado com sucesso!");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void dtgProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgProdutos_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            int id = (int)dtgProdutos.Rows[dtgProdutos.CurrentRow.Index].Cells[0].Value;
            Produto.Arquivar(id);
            FrmProdutos_Load(sender, e);
        }
    }
}
