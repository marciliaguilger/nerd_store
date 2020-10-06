using NerdStore.Core.DomainObjects.DTO;
using System;
using System.Threading.Tasks;

namespace NerdStore.Catalogo.Domain
{
    public interface IEstoqueService : IDisposable
    {
        Task<bool> DebitarEstoque(Guid produtoId, int quantidade);
        Task<bool> DebitarListaProdutosPedido(ListaProdutosPedidos lista);
        
        Task<bool> ReporEstoque(Guid produtoId, int quantidade);
        Task<bool> ReporListaProdutosPedido(ListaProdutosPedidos lista);


    }
}
