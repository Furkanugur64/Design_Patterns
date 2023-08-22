using Mediator_DesignPattern.DAL;
using Mediator_DesignPattern.MediatorPattern.Queries;
using Mediator_DesignPattern.MediatorPattern.Results;
using MediatR;

namespace Mediator_DesignPattern.MediatorPattern.Handlers
{
    public class GetPruductUpdateByIdQueryHandler : IRequestHandler<GetProductUpdateByIdQuery, GetProductUpdateByIdQueryResult>
    {
        private readonly Context _context;
        public GetPruductUpdateByIdQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<GetProductUpdateByIdQueryResult> Handle(GetProductUpdateByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Products.FindAsync(request.Id);
            return new GetProductUpdateByIdQueryResult
            {
                Brand = values.Brand,
                Category = values.Category,
                Name = values.Name,
                Price = values.Price,
                ProductID = values.ProductID,
                Stock = values.Stock
            };
        }
    }
}
