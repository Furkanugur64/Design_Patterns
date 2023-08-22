using CQRS_DesignPattern.CQRSPattern.Quaries;
using CQRS_DesignPattern.CQRSPattern.Results;
using CQRS_DesignPattern.DAL;

namespace CQRS_DesignPattern.CQRSPattern.Handlers
{
    public class GetProductUpdateByIdQueryHandler
    {
        private readonly Context _context;

        public GetProductUpdateByIdQueryHandler(Context context)
        {
            _context = context;
        }

        public GetProductUpdateByIDQueryResult Handle(GetProductUpdateByIDQuery query)
        {
            var value = _context.Products.Find(query.ID);
            return new GetProductUpdateByIDQueryResult
            {
                Brand = value.Brand,
                Category = value.Category,
                ProductName = value.ProductName,
                Price = value.Price,
                ProductID = value.ProductID,
                Stock = value.Stock
            };
        }
    }
}
