using EPAM.UserAwards.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM.UserAwards.DAL.Interfaces
{
    public interface IUserDAO
    {
        void Add(User entity);
        void Delete(User id);
        IEnumerable<User> GetAll();

        User GetByID(Guid id);
    }
}
