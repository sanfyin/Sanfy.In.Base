using System;
using MediatR;

namespace Sanfy.In.Base.Core.Interfaces
{
    public interface IDomainEvent : INotification
    {
        Guid Id { get; }

        DateTime OccurredOn { get; }
    }
}

