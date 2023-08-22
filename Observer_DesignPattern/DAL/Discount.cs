namespace Observer_DesignPattern.DAL
{
    public class Discount
    {
        public int DiscountID { get; set; }
        public string DiscountCode { get; set; }
        public decimal DiscountAmount { get; set; }
        public bool DiscountStatus { get; set; }
    }
}
