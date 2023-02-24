﻿using System;
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
        public string CPF { get; set; }
        public string Email { get; set; }
        public List<Telefone> Telefones { get; set; }
        public List<Endereco> Enderecos { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }

        // Métodos construtores
        public Cliente(int id, string nome, string cpf, string email, List<Telefone> telefone, List<Endereco> endereco, DateTime datacad, bool ativo)
        {
            Id = id;
            Nome = nome;
            CPF = cpf;
            Email = email;
            Telefones = telefone;
            Enderecos = endereco;
            DataCadastro = datacad;
            Ativo = ativo;
        }

        public Cliente(string nome, string cpf, string email, List<Telefone> telefone, List<Endereco> endereco, DateTime datacad, bool ativo)
        {
            Nome = nome;
            CPF = cpf;
            Email = email;
            Telefones = telefone;
            Enderecos = endereco;
            DataCadastro = datacad;
            Ativo = ativo;
        }

        public Cliente(int id)
        {
           Telefones = ti92class.Telefone.ListarPorCliente(id);
           Enderecos = ti92class.Endereco.ListarPorCliente(id);
        }
        public Cliente() 
        { 

        }


        // Métodos da Classe
        public void Inserir()
     {
         var cmd = Banco.Abrir();
         cmd.CommandType = CommandType.Text;
         cmd.CommandText = "insert clientes (nome, cpf, email, telefone, endereco, datacad, Ativo) " +
             "values ('" + Nome + "'," +
             "'" + CPF + "'," +
             "'" + Email + "'," +
             "'" + Telefones + "',"+
             "'" + Enderecos + "',"+
             " " + DataCadastro + " ," +
             " " + Ativo + ")";
         cmd.ExecuteNonQuery();
         cmd.CommandText = "select @@identity";
         Id = Convert.ToInt32(cmd.ExecuteScalar());
     }
       public static List<Cliente> Listar()
       {
           List<Cliente> lista = new List<Cliente>();
           var cmd = Banco.Abrir();
           cmd.CommandType = System.Data.CommandType.Text;
           cmd.CommandText = "select * from clientes order by nome asc";
         var dr = cmd.ExecuteReader();
         while (dr.Read()) // Enquanto houver um próximo registro
         {
             lista.Add(new Cliente(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), Telefone.ListarPorCliente(dr.GetInt32(4)), Endereco.ListarPorCliente(dr.GetInt32(5)), dr.GetDateTime(6), dr.GetBoolean(7)));
         }
         // retorna a lista preenchida
         return lista;
     }
       public static Cliente ObterPorId(int _id)
     {

         Cliente cliente = new Cliente();
         var cmd = Banco.Abrir();
         cmd.CommandType = System.Data.CommandType.Text;
         cmd.CommandText = "select * from clientes where id = " + _id;
         var dr = cmd.ExecuteReader();
         while (dr.Read())
         {
             cliente.Id = dr.GetInt32(0);
             cliente.Nome = dr.GetString(1);
             cliente.CPF = dr.GetString(2);
             cliente.Email = dr.GetString(3);
             cliente.Telefones = Telefone.ListarPorCliente(dr.GetInt32(4));
             cliente.Enderecos = Endereco.ListarPorCliente(dr.GetInt32(5));
             cliente.DataCadastro = dr.GetDateTime(6);
             cliente.Ativo = dr.GetBoolean(7);
         }
         return cliente;
     }
        public void Editar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText =
                "update clientes set nome = '" + Nome + "'," +
                " cpf = '" + CPF + "', email = '" + Email + "', datacad = " + DataCadastro + ", ativo = " + Ativo + " " +
                "where id = " + Id;
            cmd.ExecuteReader();
        }
        public static bool Arquivar(int id) // Arquivando
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update clientes set descontinuado = 1 where id =" + id;
            return cmd.ExecuteNonQuery() == 1 ? true : false;
        }
        public static bool Restaurar(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update clientes set descontinuado = 0 where id =" + id;
            return cmd.ExecuteNonQuery() == 1 ? true : false;
        }
        public static void Atualizar(Cliente cliente)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update clientes set " +
                "nome = '" + cliente.Nome + "'," +
                "email = '" + cliente.Email + "'," +
                "cpf = '" + cliente.CPF + "'," +
                "telefone = '" + cliente.Telefones + "'," +
                "endereco = '" + cliente.Enderecos + "'," +
                "dataCadastro = '" + cliente.DataCadastro + "'," +
                "ativo = '" + cliente.Ativo + "' " +
                "where id = " + cliente.Id;
            cmd.ExecuteReader();
        }
        public bool Excluir(int _id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from clientes where id = " + _id;
            bool result = cmd.ExecuteNonQuery() == 1 ? true : false;
            return result;
        }
        public static List<Cliente> BuscarPorNome(string _parte)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from clientes where nome like '%" + _parte + "%' order by nome;";
            var dr = cmd.ExecuteReader();
            List<Cliente> lista = new List<Cliente>();
            while (dr.Read())
            {
                lista.Add(new Cliente(
                        dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), Telefone.ListarPorCliente(dr.GetInt32(4)), Endereco.ListarPorCliente(dr.GetInt32(5)), dr.GetDateTime(6), dr.GetBoolean(7)
                    )
                );
            }
            return lista;
        }
    }
}