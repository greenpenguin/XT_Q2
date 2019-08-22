using System.Collections.Generic;
using Entities;

namespace DAL.Interface
{
    public interface IUserAndAwardsDao
    {
        bool AddUsersAwardRecord(int userId);
        bool AddAwardToUser(int userId, int awardId);
        
        bool DeleteUsersAwardRecord(int userId);
        bool DeleteAwardToUser(int userId, int awardId);
        
        ICollection<UserAndAwards> GetAllUsersAndAwards();
    }
}