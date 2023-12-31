﻿using Observer_DesignPattern.DAL;

namespace Observer_DesignPattern.ObserverPattern
{
    public class CreateWelcomeMessage : IObserver
    {
        private readonly IServiceProvider _serviceProvider;
        Context context = new Context();

        public CreateWelcomeMessage(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void CreateNewUser(AppUser appUser)
        {
            context.WelcomeMessages.Add(new WelcomeMessage
            {
                NameSurname = appUser.Name + " " + appUser.Surname,
                Content = "Dergi bültenimize abone olduğunuz için teşekkür ederiz. Hoş geldiniz."
            });
            context.SaveChanges();
        }
    }
}
