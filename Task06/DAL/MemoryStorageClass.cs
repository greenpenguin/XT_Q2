using System.Collections.Generic;
using System.Linq;
using Entities;

namespace DAL
{
    public class MemoryStorageClass : IStorable
    {
        private static List<User> Users { get; set; }
        private static List<Award> Awards { get; set; }
        private static List<UserAndAwards> UserAndAwards { get; set; }

        public MemoryStorageClass()
        {
            Users = new List<User>();
            Awards = new List<Award>();
            UserAndAwards = new List<UserAndAwards>();
        }
        public bool AddUser(User user)
        {
            if (Users.Any(n => n.Id == user.Id))
                return false;

            Users.Add(user);

            return true;
        }

        public bool AddAward(Award award)
        {
            if (Awards.Any(n => n.Id == award.Id))
               return false;

           Awards.Add(award);

            return true;
        }

        public bool AddUsersAwardRecord(int userId)
        {
            if (UserAndAwards.Any(n => n.UserId == userId))
                return false;

            UserAndAwards userAndAwards = new UserAndAwards(userId);
            UserAndAwards.Add(userAndAwards);

            return true;
        }

        public bool AddAwardToUser(int userId, int awardId)
        {
            if (UserAndAwards.Where(n => n.UserId == userId).Any(n => n.ListOfAwards.Contains(awardId)))
                return false;

            if (UserAndAwards.Any(n => n.UserId != userId))
            {
                AddUsersAwardRecord(userId);
            }
            
            foreach (var s in UserAndAwards)
            {
                if (s.UserId == userId)
                {
                    s.ListOfAwards.Add(awardId);
                }
            }
            
            return true;
        }

        public bool DeleteUser(User user)
        {
            if (Users.Any(n => n.Id != user.Id))
                return false;

            Users.Remove(user);

            return true;
        }

        public bool DeleteAward(Award award)
        {
            if (Awards.Any(n => n.Id != award.Id))
                return false;

            Awards.Remove(award);

            return true;
        }

        public bool DeleteUsersAwardRecord(int userId)
        {
            if (UserAndAwards.Any(n => n.UserId != userId))
                return false;

            UserAndAwards userAndAwards = new UserAndAwards(userId);
            UserAndAwards.Remove(userAndAwards);
            
            return true;
        }

        public bool DeleteAwardToUser(int userId, int awardId)
        {
            if (UserAndAwards.Where(n => n.UserId == userId).Any(n => !n.ListOfAwards.Contains(awardId)))
                return false;

            foreach (var s in UserAndAwards)
            {
                if (s.UserId == userId)
                {
                    s.ListOfAwards.Remove(awardId);
                }
            }
            
            return true;
        }

        public ICollection<User> GetAllUsers()
        {
            return Users;
        }

        public ICollection<Award> GetAllAwards()
        {
            return Awards;
        }

        public ICollection<UserAndAwards> GetAllUsersAndAwards()
        {
            return UserAndAwards;
        }
    }
}