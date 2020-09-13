using NerdStore.Core.Messages;
using System;

namespace NerdStore.Core.Messages.CommomMessages.DomainEvents
{
    public class DomainEvent : Event
    {
        public DomainEvent(Guid aggregateId)
        {
            AggregateId = aggregateId;
        }
    }
}
