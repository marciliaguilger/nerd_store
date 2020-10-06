using System;
using System.Collections.Generic;
using System.Text;

namespace NerdStore.Pagamentos.Business
{
    public interface IPagamentoCartaoCreditoFacade
    {
        //implementada na camada anti corrupção
        Transacao RealizarPagamento(Pedido pedido, Pagamento pagamento);
    }
}
