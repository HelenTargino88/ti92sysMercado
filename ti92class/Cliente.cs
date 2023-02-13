using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ti92class
{
    public class Cliente
    {    

        public int Id { get; set; }
        public string Nome { get; set; }
        public int CPF { get; set; }
        public string Email { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }

        // Métodos construtores
        public Cliente(int id, string nome, int cpf, string email, DateTime dataCadastro, bool ativo)
        {
            Id = id;
            Nome = nome;
            CPF = cpf;
            Email = email;
            DataCadastro = dataCadastro;
            Ativo = ativo;
        }

        public Cliente(string nome, int cPF, string email, DateTime dataCadastro, bool ativo)
        {
            Nome = nome;
            CPF = cPF;
            Email = email;
            DataCadastro = dataCadastro;
            Ativo = ativo;
        }

        // Métodos da Classe
     public void Inserir()
     {
         var cmd = Banco.Abrir();
         cmd.CommandType = CommandType.Text;
         cmd.CommandText = "insert clientes (nome, cpf, email, dataCadastro, Ativo) " +
             "values ('" + Nome + "'," +
             "'" + CPF + "'," +
             "'" + Email + "'," +
             " " + DataCadastro + " ," +
             " " + Ativo + ")";
         cmd.ExecuteNonQuery();
         cmd.CommandText = "select @@identity";
         Id = Convert.ToInt32(cmd.ExecuteScalar());
     }
       public static List<Produto> Listar()
       {
           List<Produto> lista = new List<Produto>();
           var cmd = Banco.Abrir();
           cmd.CommandType = System.Data.CommandType.Text;
           cmd.CommandText = "select * from produtos order by descricao asc";
         var dr = cmd.ExecuteReader();
         while (dr.Read()) // Enquanto houver um próximo registro
         {
             lista.Add(new Produto(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetDouble(4), dr.GetDouble(5), dr.GetBoolean(6)));
         }
         // retorna a lista preenchida
         return lista;
     }
////        public static Cliente ObterPorId(int _id)
//        {

//            Cliente cliente = new Cliente();
//            var cmd = Banco.Abrir();
//            cmd.CommandType = System.Data.CommandType.Text;
//            cmd.CommandText = "select * from clientes where id = " + _id;
//            var dr = cmd.ExecuteReader();
//            while (dr.Read())
//            {
//                cliente.Id = dr.GetInt32(0);
//                cliente.Nome = dr.GetString(1);
//                cliente.CPF = dr.GetInt(2);
//                cliente.Email = dr.GetString(3);
//                cliente.DataCadastro = dr.GetDouble(4);
//                cliente.Ativo = dr.GetDouble(5);
//            }
//            return produto;
//        }
   }
}
