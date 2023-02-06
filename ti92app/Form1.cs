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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           //  Nivel.Atualizar(new Nivel(5, "Coordenador", "cdd"));          

           var nivel = Nivel.ObterPorId(2);
           label1.Text = nivel.Id + " - " + nivel.Nome + " - " + nivel.Sigla;

            AtualizarListBox();                      
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnInsereNivel_Click(object sender, EventArgs e)
        {
            Nivel nivel = new Nivel(txtNomeNivel.Text, txtSiglaNivel.Text);
            nivel.Inserir();
            txtIdNivel.Text = nivel.Id.ToString();
            AtualizarListBox();
            MessageBox.Show("Nível inserido com sucesso! \n ID: " + nivel.Id.ToString());
            txtIdNivel.Clear();
            txtNomeNivel.Clear();
            txtSiglaNivel.Clear();
            txtNomeNivel.Focus();
        }

        

        private void txtIdNivel_TextChanged(object sender, EventArgs e)
        {
            if (txtIdNivel.Text != string.Empty)
            {
                int id = int.Parse(txtIdNivel.Text);
                var nivel = Nivel.ObterPorId(id);
                txtNomeNivel.Text = nivel.Nome;
                txtSiglaNivel.Text = nivel.Sigla;
            }
        }
        private void AtualizarListBox()
        {
            List<Nivel> list = Nivel.Listar();
            listBox1.Items.Clear();
            foreach (var item in list)
            {
                listBox1.Items.Add("ID: " +item.Id + " - NOME: " + item.Nome + " - SIGLA: " +item.Sigla);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (btnEditar.Text == "Editar")
            {
                txtIdNivel.ReadOnly = false;
                txtIdNivel.Focus();
                btnEditar.Text = "Gravar";
                btnInsereNivel.Enabled = false;
            }
            else
            {
                Nivel nivel = new Nivel();
                nivel.Id = int.Parse(txtIdNivel.Text);
                nivel.Nome = txtNomeNivel.Text;
                nivel.Sigla = txtSiglaNivel.Text;
                Nivel.Atualizar(nivel);
                txtIdNivel.ReadOnly = true;
                txtNomeNivel.Focus();
                btnEditar.Text = "Editar";
                AtualizarListBox();
            }
        }
    }    
}
