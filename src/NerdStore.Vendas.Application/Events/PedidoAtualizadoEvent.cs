using NerdStore.Core.Messages;
using System;

namespace NerdStore.Vendas.Application.Events
{
    public class PedidoAtualizadoEvent : Event
    {

        public Guid ClienteId { get; private set; }
        public Guid PedidoId { get; private set; }
        public decimal ValorTotal { get; set; }

        public PedidoAtualizadoEvent(Guid clienteId, Guid pedidoId, decimal valorTotal)
        {
            AggregateId = pedidoId;
            ClienteId = clienteId;
            PedidoId = pedidoId;
            ValorTotal = valorTotal;
        }
               

    }
}
