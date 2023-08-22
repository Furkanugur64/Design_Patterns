using Mediator_DesignPattern.DAL;
using Mediator_DesignPattern.MediatorPattern.Commands;
using MediatR;

namespace Mediator_DesignPattern.MediatorPattern.Handlers
{
    public class UpdaterProductCommandHandler : IRequestHandler<UpdateProductCommand>
    {
        private readonly Context _context;

        public UpdaterProductCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
           var value= _context.Products.Find(request.ProductID);
           value.Brand=request.Brand;
           value.Price=request.Price;
           value.Name=request.Name;
           value.Stock=request.Stock;
           value.Category=request.Category;
           await _context.SaveChangesAsync();
           return Unit.Value;         
        }
    }
}
