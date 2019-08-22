using System.Collections.Generic;
using Entities;

namespace DAL.Interface
{
    public interface IUserDao
    {
        bool AddUser(User user);
        bool DeleteUser(User user);
        ICollection<User> GetAllUsers();
    }
}