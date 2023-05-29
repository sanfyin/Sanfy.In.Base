using System;
using Sanfy.In.Base.Core.Interfaces;

namespace Sanfy.In.Base.Infra.DomainEventsDispatching
{
    public interface IDomainEventsAccessor
    {
        IReadOnlyCollection<IDomainEvent> GetAllDomainEvents();

        void ClearAllDomainEvents();
    }
}