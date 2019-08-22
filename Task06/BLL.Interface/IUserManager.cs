using System.Collections.Generic;
using Entities;

namespace BLL.Interface
{
    public interface IUserManager
    {
        bool AddUser(User user);
        bool DeleteUser(User user);
        ICollection<User> GetAllUsers();
    }
}