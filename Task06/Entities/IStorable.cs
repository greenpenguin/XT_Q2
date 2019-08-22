using System.Collections.Generic;

namespace Entities
{
    public interface IStorable
    {
        bool AddUser(User user);
        bool AddAward(Award award);
        bool AddUsersAwardRecord(int userId);
        bool AddAwardToUser(int userId, int awardId);
        
        bool DeleteUser(User user);
        bool DeleteAward(Award award);
        bool DeleteUsersAwardRecord(int userId);
        bool DeleteAwardToUser(int userId, int awardId);
        
        ICollection<User> GetAllUsers();
        ICollection<Award> GetAllAwards();
        ICollection<UserAndAwards> GetAllUsersAndAwards();
    }
}