using Mediator_DesignPattern.DAL;
using Mediator_DesignPattern.MediatorPattern.Commands;
using MediatR;
using NuGet.Protocol.Plugins;

namespace Mediator_DesignPattern.MediatorPattern.Handlers
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand>
    {
        private readonly Context _context;

        public CreateProductCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            _context.Products.Add(new Product
            {
                Name = request.Name,
                Stock = request.Stock,
                Brand = "Bilinmiyor",
                Price = 0,
                Category="deneme"
                
            });
            await _context.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
