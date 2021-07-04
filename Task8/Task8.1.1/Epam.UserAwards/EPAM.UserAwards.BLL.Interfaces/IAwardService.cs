using EPAM.UserAwards.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM.UserAwards.BLL.Interfaces
{
    public interface IAwardService
    {
        void Add(Award entity);

        void Delete(Award id);

        IEnumerable<Award> GetAll();

        Award GetByID(Guid id);
    }
}
