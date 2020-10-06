using NerdStore.Core.Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NerdStore.Vendas.Domain
{
    public interface IPedidoRepository : IRepository<Pedido>
    {
        //um repositorio por agregação
        //Pedido
        Task<Pedido> ObterPorId(Guid Id);
        Task<IEnumerable<Pedido>> ObterListaPorClienteId(Guid clienteId);
        Task<Pedido> ObterPedidoRascunhoPorClienteId(Guid clienteId);
        void Adicionar(Pedido pedido);
        void Atualizar(Pedido pedido);
        
        //PedidoItem
        Task<PedidoItem> ObterItemPorId(Guid id);
        Task<PedidoItem> ObterItemPorPedido(Guid pedidoId, Guid produtoId);
        void AdicionarItem(PedidoItem pedidoItem);
        void AtualizarItem(PedidoItem pedidoItem);
        void RemoverItem(PedidoItem pedidoItem);
        //Voucher
        Task<Voucher> ObterVoucherPorCodigo(string codigo);

    }



}
