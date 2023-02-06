using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ti92class
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public Nivel Nivel { get; set; }
        public string Senha { get; set; }
        public bool Ativo { get; set; }

        // Métodos construtores

        public Usuario() { }
        public Usuario (string _nome, string _email, Nivel _nivel, string _senha, bool _ativo)
        {
            Nome = _nome;
            Email = _email;
            Nivel = _nivel;
            Senha = _senha;
            Ativo = _ativo;
        }

        public Usuario(int _id, string _nome, string _email, Nivel _nivel, string _senha, bool _ativo)
        {
            Id = _id;
            Nome = _nome;
            Email = _email;
            Nivel= _nivel;
            Senha = _senha;
            Ativo = _ativo;
        }
        // Métodos de classe
        public void Inserir () 
        {
            // gravar um novo usuário na tabela usuários
        }
        public static List<Usuario> Listar()
        {
            // entrega uma lista de todos os usuários
            List<Usuario> lista = new List<Usuario>();
            // lógica que recupera todos os usuários da tabela

            return lista;
        }
        public static Usuario ObterPorId(int _id)
        {
            Usuario usuario = null;
            return usuario;
        }
        public static void Atualizar(Usuario usuario)
        {

        }
        public bool Excluir(int _id)
        {
            return true;
        }
    }
}
