﻿using Mediator_DesignPattern.DAL;
using Mediator_DesignPattern.MediatorPattern.Commands;
using MediatR;

namespace Mediator_DesignPattern.MediatorPattern.Handlers
{
    public class RemoveProductCommandHandler : IRequestHandler<RemoveProductCommand>
    {
        private readonly Context _context;

        public RemoveProductCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(RemoveProductCommand request, CancellationToken cancellationToken)
        {
            var values=  _context.Products.Find(request.Id);
            _context.Products.Remove(values);
            await _context.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
