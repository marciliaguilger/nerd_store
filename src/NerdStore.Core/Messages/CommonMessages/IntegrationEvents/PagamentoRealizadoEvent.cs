using System;
using System.Collections.Generic;
using System.Text;

namespace NerdStore.Core.Messages.CommonMessages.IntegrationEvents
{
    public class PagamentoRealizadoEvent : IntegrationEvent
    {
        //ids dos dados que foram gerados e utilizados na transação
        //se estivesse utilizando o banco de leitura eu precisaria gravar essas informações lá
        public Guid PedidoId { get; private set; }
        public Guid ClienteId { get; private set; }
        public Guid PagamentoId { get; private set; }
        public Guid TransacaoId { get; private set; }
        public decimal Total { get; private set; }

        public PagamentoRealizadoEvent(Guid pedidoId, Guid clienteId, Guid pagamentoId, Guid transacaoId, decimal total)
        {
            AggregateId = pagamentoId;
            PedidoId = pedidoId;
            ClienteId = clienteId;
            PagamentoId = pagamentoId;
            TransacaoId = transacaoId;
            Total = total;
        }
    }
}
