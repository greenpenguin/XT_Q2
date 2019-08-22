using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using DAL.Interface;
using Entities;

namespace DAL
{
    public class UserAndAwardsDao : IUserAndAwardsDao
    {
        private static List<UserAndAwards> UserAndAwards = new List<UserAndAwards>();
        private readonly string entitiesConnectionsInformationFile = Directory.GetCurrentDirectory() + "/EntitiesConnectionsInformation.txt";
        
        public bool AddUsersAwardRecord(int userId)
        {
            if (UserAndAwards.Any(n => n.UserId == userId))
                return false;

            UserAndAwards userAndAwards = new UserAndAwards(userId);
            UserAndAwards.Add(userAndAwards);
            
            StreamWriter writer = new StreamWriter(entitiesConnectionsInformationFile);
            writer.WriteLine(userId);
            writer.Close();
            
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
            
            StreamReader reader = new StreamReader(entitiesConnectionsInformationFile);
            StreamWriter writer = new StreamWriter(entitiesConnectionsInformationFile);
            
            string[] element;
            string[] strFromFile = reader.ReadToEnd().Split('\n');
            
            foreach (var s in strFromFile)
            {
                element = s.Split(' ');
                if (element[0] == userId.ToString())
                {
                    element[0].Insert(element[0].Length, awardId + " ");
                }
            }
            
            reader.Close();
            writer.Close();
            
            return true;
        }

        public bool DeleteUsersAwardRecord(int userId)
        {
            if (UserAndAwards.Any(n => n.UserId != userId))
                return false;

            UserAndAwards userAndAwards = new UserAndAwards(userId);
            UserAndAwards.Remove(userAndAwards);
            
            StreamReader reader = new StreamReader(entitiesConnectionsInformationFile);
            StreamWriter writer = new StreamWriter(entitiesConnectionsInformationFile);

            string[] strFromFile = reader.ReadToEnd().Split('\n');
            
            foreach (var s in strFromFile)
            {
                var element = s.Split(' ');
                if (element[0] == userId.ToString())
                {
                    continue;
                }
                
                writer.WriteLine(s);
            }
            
            reader.Close();
            writer.Close();
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
            
            StreamReader reader = new StreamReader(entitiesConnectionsInformationFile);
            StreamWriter writer = new StreamWriter(entitiesConnectionsInformationFile);

            string[] strFromFile = reader.ReadToEnd().Split('\n');
            
            for (int j = 0; j < strFromFile.Length; j++)
            {
                var element = strFromFile[j].Split(' ');
                if (element[0] == userId.ToString())
                {
                    for (int i = 0; i < element.Length - 1; i++)
                    {
                        if (element[i] == awardId.ToString())
                        {
                            element[i] = "";
                            element[i + 1] = "";
                        }
                    }
                }
            }
            
            reader.Close();
            writer.Close();
            return true;
        }

        public ICollection<UserAndAwards> GetAllUsersAndAwards()
        {
            UserAndAwards.Clear();
            StreamReader reader = new StreamReader(entitiesConnectionsInformationFile);
            string[] strFromFile = reader.ReadToEnd().Split('\n');
            
            foreach (var s in strFromFile)
            {
                var elementsOfStrFromFile = s.Split(' ');
                
                foreach (var element in elementsOfStrFromFile)
                {
                    if (!int.TryParse(element, out var value))
                    {
                        throw new ArgumentException("Error in reading file.");
                    }
                }
                
                AddUsersAwardRecord(int.Parse(elementsOfStrFromFile[0]));
                
                for (int i = 1; i < elementsOfStrFromFile.Length; i++)
                {
                    AddAwardToUser(int.Parse(elementsOfStrFromFile[0]), int.Parse(elementsOfStrFromFile[i]));
                }
            }
            
            reader.Close();
            return UserAndAwards;
        }
    }
}