using Observer_DesignPattern.DAL;

namespace Observer_DesignPattern.ObserverPattern
{
    public class CreateMagazineAnnouncement : IObserver
    {
        private readonly IServiceProvider _serviceProvider;
        Context context = new Context();

        public CreateMagazineAnnouncement(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void CreateNewUser(AppUser appUser)
        {
            context.UserProcesses.Add(new UserProcess
            {
                NameSurname = appUser.Name + " " + appUser.Surname,
                Magazine = "Spor Dergisi",
                Content = "Spor Dergimizin ağustos 2023 sayısı bayimize geldi"
            });
            context.SaveChanges();
        }
    }
}
