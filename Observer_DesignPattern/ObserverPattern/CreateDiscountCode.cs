using Observer_DesignPattern.DAL;

namespace Observer_DesignPattern.ObserverPattern
{
    public class CreateDiscountCode : IObserver
    {
        private readonly IServiceProvider _serviceProvider;

        public CreateDiscountCode(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        Context context = new Context();

        public void CreateNewUser(AppUser appUser)
        {
            context.Discounts.Add(new Discount
            {
                DiscountCode="DERGIAGUSTOS",
                DiscountAmount=25,
                DiscountStatus=true,
            });
            context.SaveChanges();
        }
    }
}
