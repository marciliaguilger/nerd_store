using MediatR;
using NerdStore.Core.DomainObjects.DTO;
using NerdStore.Core.Messages.CommonMessages.IntegrationEvents;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NerdStore.Pagamentos.Business.Events
{
    public class PagamentoEventHandler : INotificationHandler<PedidoEstoqueConfirmadoEvent>
    {
        private readonly IPagamentoService _pagamentoService;

        public PagamentoEventHandler(IPagamentoService pagamentoService)
        {
            _pagamentoService = pagamentoService;
        }

        //extrair os dados de pagamento do evento de estoque confirmado
        public async Task Handle(PedidoEstoqueConfirmadoEvent message, CancellationToken cancellationToken)
        {
            var pagamentoPedido = new PagamentoPedido
            {
                PedidoId = message.PedidoId,
                ClienteId = message.ClienteId,
                Total = message.Total,
                NomeCartao = message.NomeCartao,
                NumeroCartao = message.NumeroCartao,
                ExpiracaoCartao = message.ExpiracaoCartao,
                CvvCartao = message.CvvCartao
            };

            // a transação nao é utilizada por que o serviço irá gerar os eventos dentro do método

            await _pagamentoService.RealizarPagamentoPedido(pagamentoPedido);
        }
    }
}
