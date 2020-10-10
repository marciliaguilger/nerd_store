using EventStore.ClientAPI;
using Microsoft.Extensions.Configuration;

namespace EventSourcing
{
    public class EventStoreService : IEventStoreService
    {
        private readonly IEventStoreConnection _connection;
        public EventStoreService(IConfiguration configuration)
        {
            _connection = EventStoreConnection.Create(
                configuration.GetConnectionString("EventStoreConnection"));
            _connection.ConnectAsync(); //uma conexão ativa por instancia da APLICAÇÃO > singleton
        }

        public IEventStoreConnection GetConnection()
        {
            return _connection;
        }
    }
}
