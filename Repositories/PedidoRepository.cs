using Dapper;
using Microsoft.Data.SqlClient;
using Models;

namespace Repositories
{
    public class PedidoRepository : IPedidoRepository
    {
        private string _conn { get; set; }

        public PedidoRepository()
        {
            _conn = "Server=127.0.0.1; Database=Dapper; User Id=sa; Password=SqlServer2019!; TrustServerCertificate=True";
        }

        public bool Inserir(Pedido pedido)
        {
            var status = false;

            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                var result = db.Execute("INSERT INTO TB_PEDIDO (Descricao, Mesa) values (@Descricao, @Mesa)", pedido);
                status = true;
                db.Close();

            }
            return status;
        }

    }
}
