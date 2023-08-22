using CQRS_DesignPattern.CQRSPattern.Commands;
using CQRS_DesignPattern.DAL;

namespace CQRS_DesignPattern.CQRSPattern.Handlers
{
    public class UpdateProductCommandHandler
    {
        private readonly Context _context;

        public UpdateProductCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(UpdateProductCommand command)
        {
            var value = _context.Products.Find(command.ProductID);
            value.ProductName= command.ProductName;
            value.Brand = command.Brand;
            value.Price = command.Price;
            value.Stock = command.Stock;
            value.Category= command.Category;
            _context.SaveChanges();
        }
    }
}
