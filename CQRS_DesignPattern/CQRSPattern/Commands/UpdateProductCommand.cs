namespace CQRS_DesignPattern.CQRSPattern.Commands
{
    public class UpdateProductCommand
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string Brand { get; set; }
        public int Category { get; set; }
        public int Stock { get; set; }
    }
}
