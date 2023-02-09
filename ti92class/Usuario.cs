using System;
using System.Collections.Generic;
using System.Data;
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
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert usuarios (nome, email, nivel, senha, ativo) values ('" + Nome + "','" + Email + "','" + Nivel.Id + "','" +Senha+"',"+Ativo+")";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@identity";
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection.Close();
        }
        public static List<Usuario> Listar()
        {
            // entrega uma lista de todos os usuários
            List<Usuario> lista = new List<Usuario>();
            // lógica que recupera todos os usuários da tabela
            // 1 - Abrir conexão com o banco de dados
            var cmd = Banco.Abrir();
            // 2 - Definir tipo de comando SQL(text/store prodedure)
            cmd.CommandType = System.Data.CommandType.Text;
            // 3 - Atribuir comando SQL
            cmd.CommandText = "select * from usuarios order by nome";
            // 4 - Executar o comando sql e armazenar o retorno do banco em um objeto MySqlDataReader
            var dr = cmd.ExecuteReader();
            // 5 - Preencher o objeto List com o retorno do banco, se houver
            while (dr.Read()) // Enquanto houver um próximo registro
            {
                lista.Add(new Usuario(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), Nivel.ObterPorId(dr.GetInt32(4)), dr.GetString(3), dr.GetBoolean(5)));
            }
            // retorna a lista preenchida

            return lista;
        }
        public static Usuario ObterPorId(int _id)
        {
            Usuario usuario = null;
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from usuarios where id = " + _id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                usuario.Id = dr.GetInt32(0);
                usuario.Nome = dr.GetString(1);
                usuario.Email = dr.GetString(2);
                usuario.Nivel = Nivel.ObterPorId(dr.GetInt32(3));
                usuario.Senha = dr.GetString(4);
                usuario.Ativo = dr.GetBoolean(5);

            }
            return usuario;
        }
        public static void Atualizar(Usuario usuario)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update usuarios set " +
                "nome = '"+usuario.Nome +"'," +
                "email = '"+usuario.Email+"'," +
                "nivel = '"+usuario.Nivel+"'," +
                "senha = '"+usuario.Senha+"'," +
                "ativo = '"+usuario.Ativo+"' " +
                "where id = "+usuario.Id;
            cmd.ExecuteReader();
        }
        public bool Excluir(int _id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from usuarios where id = " + _id;
            bool result = cmd.ExecuteNonQuery() == 1 ? true : false;
            return result;
        }
        public static List<Usuario> BuscarPorNome(string _parte)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from usuarios where nome like '%" + _parte + "%' order by nome;";
            var dr = cmd.ExecuteReader();
            List<Usuario> lista = new List<Usuario>();
            while (dr.Read())
            {
                lista.Add(new Usuario(
                        dr.GetInt32(0), dr.GetString(1), dr.GetString(2), Nivel.ObterPorId(dr.GetInt32(3)), dr.GetString(4), dr.GetBoolean(5)
                    )
                );
            }
            return lista;
        }
    }
}
