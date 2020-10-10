using EventStore.ClientAPI;

namespace EventSourcing
{
    //esta classe servirá como meio de comunicação com o bd Event Store
    public interface IEventStoreService
    {
        IEventStoreConnection GetConnection();
    }
}
