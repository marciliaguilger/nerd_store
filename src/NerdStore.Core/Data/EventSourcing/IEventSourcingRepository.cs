using NerdStore.Core.Messages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NerdStore.Core.Data.EventSourcing
{
    public interface IEventSourcingRepository
    {
        Task SalvarEvent<TEvent>(TEvent evento) where TEvent : Event; //um evento genérico que seja filho de Event
        Task<IEnumerable<StoredEvent>> ObterEventos(Guid aggregateId);

        //por exemplo,  as DomainNotification não serão persistidas pois herdam de Message.
    }
}
