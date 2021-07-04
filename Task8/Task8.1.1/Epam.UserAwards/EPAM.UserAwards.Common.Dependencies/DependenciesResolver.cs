using System;
using EPAM.UserAwards.BLL;
using EPAM.UserAwards.BLL.Interfaces;
using Epam.UserAwards.Json.DAL;
using EPAM.UserAwards.DAL.Interfaces;
using Microsoft.Extensions.DependencyInjection;


namespace EPAM.UserAwards.Common.Dependencies
{
    public static class DependenciesResolver
    {
        public static IServiceProvider Kernel { get; private set; }
        private static IServiceCollection _services { get; set; }

        static DependenciesResolver()
        {
            _services = new ServiceCollection();
            Kernel = Configurates();
        }

        private static IServiceProvider Configurates()
        {

            _services.AddTransient<IUserDAO, UserDAO>();
            _services.AddTransient<IAwardDAO, AwardDAO>();
            _services.AddTransient<IUserAwardDAO, UserAwardDAO>();

            _services.AddTransient<IUserService, UserService>();
            _services.AddTransient<IAwardService, AwardService>();
            _services.AddTransient<IUserAwardService, UserAwardService>();
            


            return _services.BuildServiceProvider();
        }
    }
}
