using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ti92class
{
    public class Pedido
    {
       

        public int Id { get; set; }
        public DateTime Data { get; set; }
        public string Status { get; set;}
        public double Desconto { get; set;}
        public Cliente Cliente { get; set; }
        public Usuario Usuario { get; set; }
        public DateTime Arquivadoem { get; set; }
        public List<Itempedido> Itens { get; set; }

    public Pedido(int id, DateTime data, string status, double desconto, Cliente cliente, Usuario usuario, List<Itempedido> itens = null)
        {
            Id = id;
            Data = data;
            Status = status;
            Desconto = desconto;
            Cliente = cliente;
            Usuario = usuario;
            Itens = itens;
        }

        public Pedido(DateTime data, string status, double desconto, Cliente cliente, Usuario usuario, List<Itempedido> itens = null)
        {
            Data = data;
            Status = status;
            Desconto = desconto;
            Cliente = cliente;
            Usuario = usuario;
            Itens = itens;

        }
        public Pedido()
        { 
            Usuario = new Usuario();
            Cliente = new Cliente();
        }

        public void Inserir()
        {

        }

        public static List<Pedido> Listar()
        {
            List<Pedido> list = new List<Pedido>();

            return list;
        }
        public static Pedido ObterPorId(int id)
        {
            Pedido pedido = new Pedido();

            return pedido;
        }

        public bool Atualizar()
        {
            return false;
        }
        public void Arquivar(int id)
        {
            
        }
        public void Restaurar(int id)
        {

        }
    }
}
