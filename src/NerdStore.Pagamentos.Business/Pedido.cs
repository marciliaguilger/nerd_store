using System;
using System.Collections.Generic;
using System.Text;

namespace NerdStore.Pagamentos.Business
{
    public class Pedido
    {
        //simulação do pedido para esse contexto de pagamento
        public Guid Id { get; set; }
        public decimal Valor { get; set; }
        public List<Produto> Produtos { get; set; }
    }
}
