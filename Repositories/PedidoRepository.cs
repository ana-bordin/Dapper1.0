using Dapper;
using Microsoft.Data.SqlClient;
using Models;
using System.Configuration;

namespace Repositories
{
    public class PedidoRepository : IPedidoRepository
    {
        private string _conn { get; set; }

        public PedidoRepository()
        {
            //_conn = "Server=127.0.0.1; Database=Dapper; User Id=sa; Password=SqlServer2019!; TrustServerCertificate=True";
            _conn = ConfigurationManager.ConnectionStrings["StringConnection"].ConnectionString;
        }

        public bool Inserir(Pedido pedido)
        {
            var status = false;

            using (var db = new SqlConnection(_conn))
            {
                db.Open();

                db.Execute("INSERT INTO TB_PEDIDO (Descricao, Mesa, IdItem) values (@Descricao, @Mesa, @IdItem)",
                   new { Descricao = pedido.Descricao, Mesa = pedido.Mesa, IdItem = pedido.Item.Id });
                status = true;
                db.Close();

            }
            return status;
        }

        public List<Pedido> ObterTodos()
        {
            List<Pedido> pedidos = new List<Pedido>();

            using (var db = new SqlConnection(_conn))
            {
                db.Open();

                var list = db.Query<Pedido, Item, Pedido>(Pedido.OBTER, (pedido, item) =>
                {
                    pedido.Item = item;
                    return pedido;
                }, splitOn: "Id");
                return (List<Pedido>)list;
            }
        }
    }
}
