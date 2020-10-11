using EventStore.ClientAPI;
using NerdStore.Core.Data.EventSourcing;
using NerdStore.Core.Messages;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EventSourcing
{
    public class EventSourcingRepository : IEventSourcingRepository
    {
        private readonly IEventStoreService _eventStoreService;

        //um evento é salvo em um stream
        //o StreamId é o Id da agregação
        //O evento Id é unico e aleatório
        //quando geramos um stream de entidade estamos pegando todos os eventos daquele stream e reproduzindo em formato cronológico 
        public EventSourcingRepository(IEventStoreService eventStoreService)
        {
            _eventStoreService = eventStoreService;
        }

        public async Task<IEnumerable<StoredEvent>> ObterEventos(Guid aggregateId)
        {
            //retorna uma 'fatia' do stream de eventos
            var eventos = await _eventStoreService.GetConnection()
                .ReadStreamEventsBackwardAsync(aggregateId.ToString(), 0, 500, false);
            //explicação: pegar todos os eventos do aggregateId informado, iniciando do evento 0 até o 500 -poderia ser mais)

            //realizar conversão
            var listaEventos = new List<StoredEvent>();
            return null;
        }

        public async Task SalvarEvent<TEvent>(TEvent evento) where TEvent : Event
        {
            await _eventStoreService.GetConnection().AppendToStreamAsync(
                evento.AggregateId.ToString(),
                ExpectedVersion.Any, 
                FormatarEvento(evento)); //adiciona mais uma informação ao stream
        }

        private static IEnumerable<EventData> FormatarEvento<TEvent>(TEvent evento) where TEvent : Event
        {
            yield return new EventData(
                Guid.NewGuid(),
                evento.MessageType,
                true,
                Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(evento)),
                null);
        }

        //não será implementado o Dispose por que a forma adequada de implementar não deve ter a conexão encerrada.
    }
}
