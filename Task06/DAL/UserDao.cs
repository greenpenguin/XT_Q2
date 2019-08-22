using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using DAL.Interface;
using Entities;

namespace DAL
{
    public class UserDao : IUserDao
    {
        private static List<User> Users = new List<User>();
        private readonly string entitiesInformationFile = Directory.GetCurrentDirectory() + "/EntitiesInformation.txt";
        
        public bool AddUser(User user)
        {
            if (Users.Any(n => n.Id == user.Id))
                return false;

            Users.Add(user);
            
            StreamWriter writer = new StreamWriter(entitiesInformationFile);
            writer.WriteLine(user.ToString());
            writer.Close();

            return true;
        }

        public bool DeleteUser(User user)
        {
            if (Users.Any(n => n.Id != user.Id))
                return false;

            Users.Remove(user);
            
            StreamReader reader = new StreamReader(entitiesInformationFile);
            StreamWriter writer = new StreamWriter(entitiesInformationFile);
            string line = null;
            
            while ((line = reader.ReadLine()) != null) 
            {
                if (String.Compare(line, user.ToString()) == 0)
                {
                    continue;
                }

                writer.WriteLine(line);
            }
            
            reader.Close();
            writer.Close();
            
            return true;
        }

        public ICollection<User> GetAllUsers()
        {
            Users.Clear();
            
            StreamReader reader = new StreamReader(entitiesInformationFile);
            string[] strFromFile = reader.ReadToEnd().Split('\n');

            foreach (var s in strFromFile)
            {
                var element = s.Split(' ');
                if ((element.Length == 4) || (element.Length == 3))
                {
                    if (int.TryParse(element[0], out var idValue) &&
                        DateTime.TryParse(element[2], out var dateTimeValue))
                    {
                        AddUser(new User(idValue, element[1], dateTimeValue));
                    }
                    else
                    {
                        throw new ArgumentException("Error in reading user's data.");
                    }
                }
            }
            
            reader.Close();

            return Users;
        }
    }
}