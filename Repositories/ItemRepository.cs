using Dapper;
using Microsoft.Data.SqlClient;
using Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class ItemRepository : IItemRepository
    {
        private string _conn { get; set; }

        public ItemRepository()
        {
            _conn = ConfigurationManager.ConnectionStrings["StringConnection"].ConnectionString;
        }

        public int Inserir(Item item)
        {
            int idItem = 0;

            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                idItem = db.ExecuteScalar<int>(Item.INSERT, item);   
                db.Close();

            }
            return idItem;
        }
    }
}
