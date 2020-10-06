using System;
using System.Collections.Generic;
using System.Text;

namespace NerdStore.Pagamentos.Business
{
    public class Produto
    {
        //representação da entidade produto no contexto de pagamento
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public decimal Valor { get; set; }
    }
}
