using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ti92class
{
    public class Itempedido
    {
        public int Id { get; set; }
        public Produto Produto { get; }
        public double Preco { get; set; }
        public double Quantidade { get; set; }
        public double Desconto { get; set; }

        public Itempedido(int id, Produto produto, double preco, double quantidade, double desconto)
        {
            Id = id;
            Produto = produto;
            Preco = preco;
            Quantidade = quantidade;
            Desconto = desconto;
        }
        public Itempedido(Produto produto, double preco, double quantidade, double desconto)
        {
            Produto = produto;
            Preco = preco;
            Quantidade = quantidade;
            Desconto = desconto;
        }       
        public Itempedido()
        { 
        
        }

        public static List<Itempedido> Listar(int pedido_id)
        {
            List<Itempedido> itens = new List<Itempedido>();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from itempedido where pedido_id = " + pedido_id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                itens.Add(new Itempedido(
                    dr.GetInt32(0),
                    Produto.ObterPorId(dr.GetInt32(2)),
                    dr.GetDouble(3),
                    dr.GetDouble(4),
                    dr.GetDouble(5)
                    ));
            }
            return itens;
        }
        public static Itempedido BuscarPorProdutoPedido(int pedido_id, int produto_id)
        {
            Itempedido iten = new Itempedido();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from itempedido where pedido_id = " + pedido_id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                    iten.Id = dr.GetInt32(0);
                    iten.Produto = Produto.ObterPorId(dr.GetInt32(2));
                    iten.Preco = dr.GetDouble(3);
                    iten.Quantidade = dr.GetDouble(4);
                    iten.Desconto = dr.GetDouble(5);                   

                return iten;
        }
        public void Adicionar(int pedido_id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "insert itempedido (pedido_id, produto_id,preco,quantidade,desconto)" +
                "values(@pedido_id, @produto_id, @preco, @quantidade, @desconto)";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@pedido_id", MySqlDbType.Int32).Value = pedido_id;
            cmd.Parameters.Add("@produto_id", MySqlDbType.Int32).Value = Produto.Id;
            cmd.Parameters.Add("@preco", MySqlDbType.Decimal).Value = Produto.Preco;
            cmd.Parameters.Add("@quantidade", MySqlDbType.Decimal).Value = Quantidade;
            cmd.Parameters.Add("@desconto", MySqlDbType.Decimal).Value = Desconto;
            cmd.ExecuteNonQuery();
        }

        public void Atualizar(int pedido_id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "update itempedido set quantidade = @quantidade, desconto = @desconto" +
                " where id = @id and pedido_id = @pedido_id";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = Id;
            cmd.Parameters.Add("@pedido_id", MySqlDbType.Int32).Value = pedido_id;
            cmd.Parameters.Add("@quantidade", MySqlDbType.Decimal).Value = Quantidade;
            cmd.Parameters.Add("@desconto", MySqlDbType.Decimal).Value = Desconto;
            cmd.ExecuteNonQuery();
        }

        public void Excluir(int id, int pedido_id )
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "delete from itempedido where id = @id and pedido_id = @pedido_id";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            cmd.Parameters.Add("@pedido_id", MySqlDbType.Int32).Value = pedido_id;
           
        }

    }
}
