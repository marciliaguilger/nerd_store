using NerdStore.Core.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace NerdStore.Vendas.Application.Events
{

    public class PedidoRascunhoIniciadoEvent : Event
    {
        public Guid ClienteId { get; private set; }
        public Guid PedidoId { get; private set; }
        

        public PedidoRascunhoIniciadoEvent(Guid clienteId, Guid pedidoId)
        {
            AggregateId = pedidoId; //herança do Event : Message
            ClienteId = clienteId;
            PedidoId = pedidoId;

        }

    }
}
