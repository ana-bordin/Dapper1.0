using Models;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class ItemController
    {
        private ItemService _itemService;

        public ItemController()
        {
            _itemService = new ItemService();
        }

        public int Inserir(Item item)
        {
            return _itemService.Inserir(item);
        }
    }
}
