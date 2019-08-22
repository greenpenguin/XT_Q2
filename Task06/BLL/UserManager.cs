using System;
using System.Collections.Generic;
using Common;
using Entities;

namespace BLL
{
    public class UserManager
    {
        private static IStorable MemoryStorage => DependensiesClass.Storage;
        
        public static void AddUser(User user)
        {
            MemoryStorage.AddUser(user);
        }
        
        public static void AddUser(int id, string name, DateTime dateOfBirth)
        {
            MemoryStorage.AddUser(new User(id, name, dateOfBirth));
        }
        
        public static void DeleteUser(User user)
        {
            MemoryStorage.DeleteUser(user);
        }
        
        public static void DeleteUser(int id, string name, DateTime dateOfBirth)
        {
            MemoryStorage.DeleteUser(new User(id, name, dateOfBirth));
        }
        
        public static ICollection<User> GetAllUsers()
        {
            return MemoryStorage.GetAllUsers();
        }
    }
}