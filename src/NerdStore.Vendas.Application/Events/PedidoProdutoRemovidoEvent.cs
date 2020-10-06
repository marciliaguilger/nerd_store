using NerdStore.Core.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace NerdStore.Vendas.Application.Events
{
    public class PedidoProdutoRemovidoEvent : Event
    {
        public Guid ClienteId { get; private set; }
        public Guid PedidoId { get; private set; }
        public Guid ProdutoId { get; private set; }
        //public int Quantidade { get; set; }

        public PedidoProdutoRemovidoEvent(Guid clienteId, Guid pedidoId, Guid produtoId)
        {
            AggregateId = pedidoId;
            ClienteId = clienteId;
            PedidoId = pedidoId;
            ProdutoId = produtoId;
            //Quantidade = quantidade;

            //minuto 19:15
        }
    }
}

