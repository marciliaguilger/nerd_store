using System;
using System.Collections.Generic;
using System.Text;

namespace NerdStore.Core.DomainObjects.DTO
{
    public class ListaProdutosPedidos
    {
        public Guid PedidoId { get; set; }
        public ICollection<Item> Itens { get; set; }
    }

    public class Item
    {
        public Guid Id { get; set; }
        public int Quantidade { get; set; }
    }
}
