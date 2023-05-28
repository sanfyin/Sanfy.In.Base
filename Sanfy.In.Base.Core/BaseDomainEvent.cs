using System;
using Sanfy.In.Base.Core.Interfaces;

namespace Sanfy.In.Base.Core
{
	public class BaseDomainEvent : IDomainEvent
    {
        public Guid Id { get; }

        public DateTime OccurredOn { get; }

        public BaseDomainEvent()
        {
            this.Id = Guid.NewGuid();
            this.OccurredOn = DateTime.UtcNow;
        }
    }
}