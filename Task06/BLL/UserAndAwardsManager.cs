using System.Collections.Generic;
using Common;
using Entities;

namespace BLL
{
    public class UserAndAwardsManager
    {
        private static IStorable MemoryStorage => DependensiesClass.Storage;
        
        public static void AddUsersAwardRecord(int userId)
        {
            MemoryStorage.AddUsersAwardRecord(userId);
        }
        
        public static void AddAwardToUser(int userId, int awardId)
        {
            MemoryStorage.AddAwardToUser(userId, awardId);
        }
        
        public static void DeleteUsersAwardRecord(int userId)
        {
            MemoryStorage.DeleteUsersAwardRecord(userId);
        }
        
        public static void DeleteAwardToUser(int userId, int awardId)
        {
            MemoryStorage.DeleteAwardToUser(userId, awardId);
        }
        
        public static ICollection<UserAndAwards> GetAllUsersAndAwards()
        {
            return MemoryStorage.GetAllUsersAndAwards();
        }
    }
}