using CQRS_DesignPattern.CQRSPattern.Results;
using CQRS_DesignPattern.DAL;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CQRS_DesignPattern.CQRSPattern.Handlers
{
    public class GetProductQueryHandler
    {
        private readonly Context _context;

        public GetProductQueryHandler(Context context)
        {
            _context = context;
        }

        public List<GetProductQueryResult> Handle()
        {
            var values = _context.Products.Select(x => new GetProductQueryResult
            {
                Price = x.Price,
                ProductName = x.ProductName,
                Brand = x.Brand,
                Category = x.Category,
                ProductID = x.ProductID,
                Stock = x.Stock,
            }).ToList();
            return values;
        }
    }
}
