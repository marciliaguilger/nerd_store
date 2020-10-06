using NerdStore.Core.DomainObjects.DTO;
using NerdStore.Core.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace NerdStore.Core.Messages.CommonMessages.IntegrationEvents
{
    public class PedidoIniciadoEvent : IntegrationEvent
    {
        // EVENTO QUE IRÁ DISPARAR UM PROCESSO
        // PRECISARÁ CARREGAR UMA CERTA QUANTIDADE DE INFORMAÇÕES
        // CADA CONTEXTO LE APENAS SUA PROPRIA TABELA E NADA MAIS
        // RESPEITANDO A LÓGICA DE MICROSERVIÇOS

        public Guid PedidoId { get; private set; }
        public Guid ClienteId { get; private set; }
        public decimal Total { get; private set; }
        public ListaProdutosPedidos ProdutosPedido { get; private set; }
        public string NomeCartao { get; private set; }
        public string NumeroCartao { get; private set; }
        public string ExpiracaoCartao { get; private set; }
        public string CvvCartao { get; private set; }

        public PedidoIniciadoEvent(Guid pedidoId, Guid clienteId, decimal total, ListaProdutosPedidos produtosPedido, string nomeCartao, string numeroCartao, string expiracaoCartao, string cvvCartao)
        {
            PedidoId = pedidoId;
            ClienteId = clienteId;
            Total = total;
            ProdutosPedido = produtosPedido;
            NomeCartao = nomeCartao;
            NumeroCartao = numeroCartao;
            ExpiracaoCartao = expiracaoCartao;
            CvvCartao = cvvCartao;
        }

    }

}
