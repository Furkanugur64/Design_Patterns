using Observer_DesignPattern.DAL;

namespace Observer_DesignPattern.ObserverPattern
{
    public interface IObserver
    {
        void CreateNewUser(AppUser appUser);
    }
}
