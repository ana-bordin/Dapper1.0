using Models;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ItemService
    {
            IItemRepository _itemRepository;

            public ItemService()
            {
                _itemRepository = new ItemRepository();
            }

            public int Inserir(Item item)
            {
                return _itemRepository.Inserir(item);
            }
        }
}
