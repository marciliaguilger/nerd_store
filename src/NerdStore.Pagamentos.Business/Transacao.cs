using NerdStore.Core.DomainObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace NerdStore.Pagamentos.Business
{
    public class Transacao : Entity
    {
        //Objeto devolvido pelo gateway de pagamento (ex: paypal)
        public Guid PedidoId { get; set; }
        public Guid PagamentoId { get; set; }
        public decimal Total { get; set; }
        public StatusTransacao StatusTransacao { get; set; }

        // EF. Rel.
        public Pagamento Pagamento { get; set; }
    }
}
