using EPAM.UserAwards.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM.UserAwards.BLL.Interfaces
{
    public interface IUserService
    {
        void Add(User entity);

        void Delete(User entity);

        IEnumerable<User> GetAll();

        User GetByID(Guid id);

    }
}
