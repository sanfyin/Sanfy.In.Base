﻿using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace Sanfy.In.Base.Infra.DomainEventsDispatching
{
    public class UnitOfWorkCommandHandlerDecorator<T> : IRequestHandler<T, Unit>
        where T : IRequest<Unit>
    {
        private readonly IRequestHandler<T, Unit> _decorated;
        private readonly IUnitOfWork _unitOfWork;

        public UnitOfWorkCommandHandlerDecorator(
            IRequestHandler<T, Unit> decorated,
            IUnitOfWork unitOfWork)
        {
            _decorated = decorated;
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(T command, CancellationToken cancellationToken)
        {
            await this._decorated.Handle(command, cancellationToken);

            await this._unitOfWork.CommitAsync(cancellationToken);

            return Unit.Value;
        }
    }
}