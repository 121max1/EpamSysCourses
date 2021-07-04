
using Microsoft.Extensions.DependencyInjection;
using System;
using EPAM.UserAwards.Common.Entities;
using EPAM.UserAwards.BLL.Interfaces;
using EPAM.UserAwards.Common.Dependencies;
using System.Linq;

namespace EPAM.UserAwards.ConsolePL
{
    class Program
    {
        static void Main(string[] args)
        {
            var userService = DependenciesResolver.Kernel.GetService<IUserService>();
            var awardService = DependenciesResolver.Kernel.GetService<IAwardService>();
            var userAwardService = DependenciesResolver.Kernel.GetService<IUserAwardService>();
            //userService.Add(new User("kel", DateTime.Now, 3));
            //awardService.Add(new Award("lel"));
           //userAwardService.Add(Guid.Parse("90c0b51d-bd38-4f87-a602-095518bc80fe"), Guid.Parse("73b0b358-a645-4edc-9e35-05ebf1cc3e21"));
            Award award = awardService.GetAll().First();
            var user = userService.GetAll().First();
          
        }
    }
}
