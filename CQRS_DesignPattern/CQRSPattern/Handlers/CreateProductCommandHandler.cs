using CQRS_DesignPattern.CQRSPattern.Commands;
using CQRS_DesignPattern.DAL;

namespace CQRS_DesignPattern.CQRSPattern.Handlers
{
    public class CreateProductCommandHandler
    {
        private readonly Context _context;

        public CreateProductCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(CreateProductCommand command)
        {
            _context.Products.Add(new Product
            {
                Brand = command.Brand,
                Category = command.Category,
                ProductName = command.ProductName,
                Price = command.Price,
                Stock = command.Stock,
            });
            _context.SaveChanges();
        }
    }
}
