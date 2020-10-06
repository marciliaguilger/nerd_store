using NerdStore.Core.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace NerdStore.Core.Messages.CommonMessages.DomainEvents
{
    public class DomainEvent : Event
    {
        public DomainEvent(Guid aggregateId)
        {
            AggregateId = aggregateId;
        }

    }
}
