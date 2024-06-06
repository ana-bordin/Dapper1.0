using Models;
using Repositories;

namespace Services
{
    public class PedidoService
    {
        IPedidoRepository _pedidoRepository;
        IItemRepository _itemRepository;

        public PedidoService()
        {
            _pedidoRepository = new PedidoRepository();
            _itemRepository = new ItemRepository();
        }

        public bool Inserir(Pedido pedido)
        {
            int idItem = _itemRepository.Inserir(pedido.Item);
            pedido.Item.Id = idItem;
            return _pedidoRepository.Inserir(pedido);
        }
        public List<Pedido> ObterTodos()
        {
            return _pedidoRepository.ObterTodos();
        }
    }
}
