using System;
using System.Collections.Generic;
using BLL.Interface;
using DAL.Interface;
using Entities;

namespace BLL
{
    public class UserManager : IUserManager
    {
        private readonly IUserDao _userDao;

        public UserManager(IUserDao userDao)
        {
            _userDao = userDao;
        }
        
        public bool AddUser(User user)
        {
            _userDao.AddUser(user);
            return true;
        }
        
        public bool DeleteUser(User user)
        {
            _userDao.DeleteUser(user);
            return true;
        }
        
        public ICollection<User> GetAllUsers()
        {
            return _userDao.GetAllUsers();
        }
    }
}