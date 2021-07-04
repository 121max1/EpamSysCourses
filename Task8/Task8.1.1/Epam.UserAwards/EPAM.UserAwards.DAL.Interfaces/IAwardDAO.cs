using EPAM.UserAwards.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM.UserAwards.DAL.Interfaces
{
    public interface IAwardDAO
    {
        void Add(Award entity);
        void Delete(Award id);
        IEnumerable<Award> GetAll();

        Award GetByID(Guid id);
    }
}
