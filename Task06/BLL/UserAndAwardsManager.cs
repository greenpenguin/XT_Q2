using System.Collections.Generic;
using BLL.Interface;
using DAL.Interface;
using Entities;

namespace BLL
{
    public class UserAndAwardsManager : IUserAndAwardsManager
    {
        private readonly IUserAndAwardsDao _userAndAwardsDao;
        
        public UserAndAwardsManager(IUserAndAwardsDao userAndAwardsDao)
        {
            _userAndAwardsDao = userAndAwardsDao;
        }
        
        public bool AddUsersAwardRecord(int userId)
        {
            _userAndAwardsDao.AddUsersAwardRecord(userId);
            return true;
        }

        public bool AddAwardToUser(int userId, int awardId)
        {
            _userAndAwardsDao.AddAwardToUser(userId, awardId);
            return true;
        }

        public bool DeleteUsersAwardRecord(int userId)
        {
            _userAndAwardsDao.DeleteUsersAwardRecord(userId);
            return true;
        }

        public bool DeleteAwardToUser(int userId, int awardId)
        {
            _userAndAwardsDao.DeleteAwardToUser(userId, awardId);
            return true;
        }

        public ICollection<UserAndAwards> GetAllUsersAndAwards()
        {
            return _userAndAwardsDao.GetAllUsersAndAwards();
        }
    }
}