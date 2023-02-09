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
            comboNivelUSuario.DataSource = Nivel.Listar();
            comboNivelUSuario.DisplayMember = "Nome";
            comboNivelUSuario.ValueMember = "Id";

            AtualizarListBox();
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
                listBox1.Items.Add("ID: " + item.Id + " - NOME: " + item.Nome + " - SIGLA: " + item.Sigla);
            }
            txtIdNivel.Clear();
            txtNomeNivel.Clear();
            txtSiglaNivel.Clear();
            txtNomeNivel.Focus();

            List<Usuario> lista = Usuario.Listar();
            listBox2.Items.Clear();
            foreach (var item in lista)
            {
                listBox2.Items.Add("ID: " + item.Id + " - NOME: " + item.Nome + " - EMAIL: " + item.Email + " - SENHA: " + item.Senha + " - ATIVO: " + item.Ativo);
            }
            txtIdUsuario.Clear();
            txtNomeUsuario.Clear();
            txtEmail.Clear();
            txtSenha.Clear();
            checkAtivo.Checked = true;
            txtNomeUsuario.Focus();
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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtIdNivel.Text != string.Empty)
            {
                Nivel nivel = Nivel.ObterPorId(int.Parse(txtIdNivel.Text));
                if (nivel.Excluir(nivel.Id))
                {
                    MessageBox.Show("Nível " + nivel.Nome + " excluído com sucesso!", "Exclusão de nível");
                    AtualizarListBox();
                }

            }
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {

            // se txtBusca.Text for diferente de vazio
            // e (&&) txtBusca.Text.Length for maior ou igual
            if (txtBusca.Text != string.Empty && txtBusca.Text.Length >= 1)
            {
                listBox1.Items.Clear();
                var niveis = Nivel.BuscarPorNome(txtBusca.Text);
                if (niveis.Count > 0)
                {
                    foreach (var nivel in niveis)
                    {
                        listBox1.Items.Add(nivel.Id + " - " + nivel.Nome + " - " + nivel.Sigla);
                    }
                }
                else
                {

                    listBox1.Items.Add("Não há registros para essa consulta...");
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! Usuários !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! /


        private void btnInsereUsuario_Click(object sender, EventArgs e)
        {

            Usuario usuario = new Usuario(txtNomeUsuario.Text, txtEmail.Text, Nivel.ObterPorId((int)comboNivelUSuario.SelectedValue),txtSenha.Text, checkAtivo.Checked);
            usuario.Inserir();
            txtIdUsuario.Text = usuario.Id.ToString();
            AtualizarListBox();
            MessageBox.Show("Usuário inserido com sucesso! \n ID: " + usuario.Id.ToString());
            txtIdUsuario.Clear();
            txtNomeUsuario.Clear();
            txtEmail.Clear();
            txtSenha.Clear();
            checkAtivo.Checked = true;
            txtNomeUsuario.Focus();
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            if (btnEditarUsuario.Text == "Editar")
            {
                txtIdUsuario.ReadOnly = false;
                txtIdUsuario.Focus();
                btnEditarUsuario.Text = "Gravar";
                btnInsereUsuario.Enabled = false;
            }
            else
            {
                Usuario usuario = new Usuario();
                usuario.Id = int.Parse(txtIdUsuario.Text);
                usuario.Nome = txtNomeUsuario.Text;
                usuario.Email = txtEmail.Text;
                usuario.Senha = txtSenha.Text;
                Usuario.Atualizar(usuario);
                txtIdUsuario.ReadOnly = true;
                txtNomeUsuario.Focus();
                btnEditarUsuario.Text = "Editar";
                AtualizarListBox();
            }
        }

        private void btnExcluirUsuario_Click(object sender, EventArgs e)
        {
            if (txtIdUsuario.Text != string.Empty)
            {
                Usuario usuario = Usuario.ObterPorId(int.Parse(txtIdUsuario.Text));
                if (usuario.Excluir(usuario.Id))
                {
                    MessageBox.Show("Usuário " + usuario.Nome + " excluído com sucesso!", "Exclusão de usuário");
                    AtualizarListBox();
                }
            }
        }

        private void txtBuscaUsuario_TextChanged(object sender, EventArgs e)
        {
            // se txtBuscaUsuario.Text for diferente de vazio
            // e (&&) txtBuscaUsuario.Text.Length for maior ou igual
            if (txtBuscaUsuario.Text != string.Empty && txtBuscaUsuario.Text.Length >= 1)
            {
                listBox2.Items.Clear();
                var usuarios = Usuario.BuscarPorNome(txtBuscaUsuario.Text);
                if (usuarios.Count > 0)
                {
                    foreach (var usuario in usuarios)
                    {
                        listBox2.Items.Add(usuario.Id + " - " + usuario.Nome + " - " + usuario.Email + " - " + usuario.Senha + " - " + usuario.Nivel + " - " + usuario.Ativo);
                    }
                }
                else
                {
                    listBox2.Items.Add("Não há registros para essa consulta...");

                }
            }

        }

        private void txtIdUsuario_TextChanged(object sender, EventArgs e)
        {

            if (txtIdUsuario.Text != string.Empty)
            {
                int id = int.Parse(txtIdUsuario.Text);
                var usuario = Usuario.ObterPorId(id);
                txtNomeUsuario.Text = usuario.Nome;
                txtEmail.Text = usuario.Email;
                txtSenha.Text = usuario.Senha;
                checkAtivo.Checked = usuario.Ativo;
            }
        }
    }   
}


