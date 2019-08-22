using System.Collections.Generic;
using Common;
using Entities;

namespace BLL
{
    public class AwardManager
    {
        private static IStorable MemoryStorage => DependensiesClass.Storage;
        
        public static void AddAward(Award award)
        {
            MemoryStorage.AddAward(award);
        }
        
        public static void AddAward(int id, string title)
        {
            MemoryStorage.AddAward(new Award(id, title));
        }
        
        public static void DeleteAward(Award award)
        {
            MemoryStorage.DeleteAward(award);
        }
        
        public static void DeleteAward(int id, string title)
        {
            MemoryStorage.DeleteAward(new Award(id, title));
        }
        
        public static ICollection<Award> GetAllAwards()
        {
            return MemoryStorage.GetAllAwards();
        }
        
    }
}