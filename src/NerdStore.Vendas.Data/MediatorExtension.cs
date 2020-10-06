using NerdStore.Core.Communication.Mediator;
using NerdStore.Core.DomainObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdStore.Vendas.Data
{
    public static class MediatorExtension
    {
        //minuto 16:54
        public static async Task PublicarEventos(this IMediatorHandler mediator, VendasContext ctx)
        {
            //Procura por todas as entidades que sofreram alterações no EF e possuem notificacao
            var domainEntities = ctx.ChangeTracker
                .Entries<Entity>()
                .Where(x => x.Entity.Notificacoes != null && x.Entity.Notificacoes.Any());
            
            //seleciona todas as notificacoes numa list
            var domainEvents = domainEntities
                .SelectMany(x => x.Entity.Notificacoes)
                .ToList();

            //limpa as notificacoes das entitdades originais  
            domainEntities.ToList()
                .ForEach(entity => entity.Entity.LimparEventos());

            //Faz a publicação de cada evento individualmente da lista
            var tasks = domainEvents
                .Select(async (domainEvent) =>
                {
                    await mediator.PublicarEvento(domainEvent);
                });

            await Task.WhenAll(tasks);
        }
    }
}
