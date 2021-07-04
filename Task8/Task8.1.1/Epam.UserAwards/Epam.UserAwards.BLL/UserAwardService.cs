using EPAM.UserAwards.BLL.Interfaces;
using EPAM.UserAwards.Common.Entities;
using EPAM.UserAwards.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM.UserAwards.BLL
{
    public class UserAwardService : IUserAwardService
    {
        private readonly IUserAwardDAO _userAwardDAO;

        public UserAwardService(IUserAwardDAO userAwardDAO)
        {
            _userAwardDAO = userAwardDAO;
        }
        public void Add(Guid userID, Guid awardID)
        {
            _userAwardDAO.Add(userID, awardID);
        }

        public void DeleteByAward(Guid awardID)
        {
            _userAwardDAO.DeleteByAward(awardID);
        }

        public void DeleteByUser(Guid userID)
        {
            _userAwardDAO.DeleteByUser(userID);
        }

        public IEnumerable<UserAward> GetAll()
        {
            return _userAwardDAO.GetAll();
            
        }
    }
}
