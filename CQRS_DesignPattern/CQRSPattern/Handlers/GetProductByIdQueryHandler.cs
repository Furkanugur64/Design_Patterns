using CQRS_DesignPattern.CQRSPattern.Quaries;
using CQRS_DesignPattern.CQRSPattern.Results;
using CQRS_DesignPattern.DAL;

namespace CQRS_DesignPattern.CQRSPattern.Handlers
{
    public class GetProductByIdQueryHandler
    {
        private readonly Context _context;

        public GetProductByIdQueryHandler(Context context)
        {
            _context = context;
        }

        public GetProductByIdQueryResult Handle(GetProductByIdQuery getProductByIdQuery)
        {
            var values = _context.Products.Find(getProductByIdQuery.Id);
            return new GetProductByIdQueryResult
            {
                ProductID = values.ProductID,
                ProductName = values.ProductName,
                Brand = values.Brand,
            };
        }
    }
}
