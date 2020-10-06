using NerdStore.Core.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace NerdStore.Vendas.Application.Commands
{
    public class FinalizarPedidoCommand : Command
    {
        public Guid PedidoId { get; private set; }
        public Guid ClienteId { get; private set; }
        
        public FinalizarPedidoCommand(Guid pedidoId, Guid clienteId)
        {
            AggregateId = PedidoId;
            PedidoId = pedidoId;
            ClienteId = clienteId;
        }
    }
}
