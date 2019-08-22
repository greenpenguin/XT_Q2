using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Entities;

namespace DAL
{
    public class WorkWithFileClass : IStorable
    {
        private string AllInputInformationFile = Directory.GetCurrentDirectory() + "/Input.txt";
        
        private string UserAndAwardsIndexesFile = Directory.GetCurrentDirectory() + "/Indexes.txt";
        
        private string AllOutputInformationFile = Directory.GetCurrentDirectory() + "/Output.txt";
        
        private MemoryStorageClass MemoryStorage { get; set; }

        private const int constForOutputAllUsersInFunction = 1;
        private const int constForOutputAllAwardsInFunction = 2;
        private const int constForOutputAllAwardsAndUsersInFunction = 3;
        
        public WorkWithFileClass()
        {
            MemoryStorage = new MemoryStorageClass();
        }
        
        private void AllInfoFileReader()
        {
            StreamReader reader = new StreamReader(AllInputInformationFile);
            string[] element;
            string[] strFromFile = reader.ReadToEnd().Split('\n');
            
            foreach (var s in strFromFile)
            {
                element = s.Split(' ');
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

                else if (element.Length == 2)
                {
                    if (int.TryParse(element[0], out var idValue))
                    {
                        AddAward(new Award(idValue, element[1]));
                    }
                    else
                    {
                        throw new ArgumentException("Error in reading award's data.");
                    }
                }
                
                else
                {
                    throw new ArgumentException("Error in reading file.");
                }
            }
            
            reader.Close();
        }

        private void AllIndexesFileReader()
        {
            StreamReader reader = new StreamReader(UserAndAwardsIndexesFile);
            string[] elementsOfStrFromFile;
            string[] strFromFile = reader.ReadToEnd().Split('\n');
            
            foreach (var s in strFromFile)
            {
                elementsOfStrFromFile = s.Split(' ');
                
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
        }

        private void AddInfoToFile(string elementInfo)
        {
            StreamWriter writer = new StreamWriter(AllInputInformationFile);
            writer.WriteLine(elementInfo);
            writer.Close();
        }
        
        private void DeleteInfoFromFile(string elementInfo)
        {
            StreamReader reader = new StreamReader(AllInputInformationFile);
            StreamWriter writer = new StreamWriter(AllInputInformationFile);
            string line = null;
            
            while ((line = reader.ReadLine()) != null) 
            {
                if (String.Compare(line, elementInfo) == 0)
                {
                    continue;
                }

                writer.WriteLine(line);
            }
            
            reader.Close();
            writer.Close();
        }

        public void OutputInformation(int typeOfOutputInformation)
        {
            StreamWriter writer = new StreamWriter(AllOutputInformationFile);
            if (typeOfOutputInformation == 1)
            {
                writer.WriteLine("All users' information:");
                foreach (var user in MemoryStorage.GetAllUsers())
                {
                    writer.WriteLine(user.ToString());
                }
            }
            else if (typeOfOutputInformation == 2)
            {
                writer.WriteLine("All awards' information:");
                foreach (var award in MemoryStorage.GetAllAwards())
                {
                    writer.WriteLine(award.ToString());
                }
            }
            else if (typeOfOutputInformation == 3)
            {
                writer.WriteLine("All information about users and their awards:");
                
                for (int i = 0; i < MemoryStorage.GetAllUsersAndAwards().Count; i++)
                {
                    foreach (var user in MemoryStorage.GetAllUsers())
                    {
                        if (user.Id == MemoryStorage.GetAllUsersAndAwards().ElementAt(i).UserId)
                        {
                            writer.WriteLine("User:");
                            writer.WriteLine(user.ToString());
                            writer.WriteLine("Awards:");
                        }
                    }

                    foreach (var award in MemoryStorage.GetAllAwards())
                    {
                        if (MemoryStorage.GetAllUsersAndAwards().ElementAt(i).ListOfAwards.Contains(award.Id))
                        {
                            writer.WriteLine(award.ToString());
                        }
                    }

                    writer.WriteLine();
                }
            }
            
            writer.Close();
        }
        
        private void AddUserIndexToFile(string userIndex)
        {
            StreamWriter writer = new StreamWriter(UserAndAwardsIndexesFile);
            writer.WriteLine(userIndex);
            writer.Close();
        }

        private void AddAwardIndexToUserToFile(string userIndex, string awardIndex)
        {
            StreamReader reader = new StreamReader(UserAndAwardsIndexesFile);
            StreamWriter writer = new StreamWriter(UserAndAwardsIndexesFile);
            
            string[] element;
            string[] strFromFile = reader.ReadToEnd().Split('\n');
            
            foreach (var s in strFromFile)
            {
                element = s.Split(' ');
                if (element[0] == userIndex)
                {
                    element[0].Insert(element[0].Length, awardIndex + " ");
                }
            }
            
            reader.Close();
            writer.Close();
        }
        
        private void DeleteUserIndexToFile(string userIndex)
        {
            StreamReader reader = new StreamReader(UserAndAwardsIndexesFile);
            StreamWriter writer = new StreamWriter(UserAndAwardsIndexesFile);

            string[] strFromFile = reader.ReadToEnd().Split('\n');
            
            foreach (var s in strFromFile)
            {
                var element = s.Split(' ');
                if (element[0] == userIndex)
                {
                    continue;
                }
                
                writer.WriteLine(s);
            }
            
            reader.Close();
            writer.Close();
        }
        
        private void DeleteAwardIndexToUserToFile(string userIndex, string awardIndex)
        {
            StreamReader reader = new StreamReader(UserAndAwardsIndexesFile);
            StreamWriter writer = new StreamWriter(UserAndAwardsIndexesFile);

            string[] strFromFile = reader.ReadToEnd().Split('\n');
            
            for (int j = 0; j < strFromFile.Length; j++)
            {
                var element = strFromFile[j].Split(' ');
                if (element[0] == userIndex)
                {
                    for (int i = 0; i < element.Length - 1; i++)
                    {
                        if (element[i] == awardIndex)
                        {
                            element[i] = "";
                            element[i + 1] = "";
                        }
                    }
                }
            }
            
            reader.Close();
            writer.Close();
        }

        public bool AddUser(User user)
        {
            MemoryStorage.AddUser(user);
            
            AddInfoToFile(user.ToString());

            return true;
        }

        public bool AddAward(Award award)
        {
            MemoryStorage.AddAward(award);
            
            AddInfoToFile(award.ToString());

            return true;
        }

        public bool AddUsersAwardRecord(int userId)
        {
            MemoryStorage.AddUsersAwardRecord(userId);
            
            AddUserIndexToFile(userId.ToString());

            return true;
        }

        public bool AddAwardToUser(int userId, int awardId)
        {
            MemoryStorage.AddAwardToUser(userId, awardId);
            
            AddAwardIndexToUserToFile(userId.ToString(), awardId.ToString());
            return true;
        }

        public bool DeleteUser(User user)
        {
            MemoryStorage.DeleteUser(user);
            DeleteInfoFromFile(user.ToString());
            
            return true;
        }

        public bool DeleteAward(Award award)
        {
            MemoryStorage.DeleteAward(award);
            
            DeleteInfoFromFile(award.ToString());
            
            return true;
        }

        public bool DeleteUsersAwardRecord(int userId)
        {
            MemoryStorage.DeleteUsersAwardRecord(userId);
            
            DeleteUserIndexToFile(userId.ToString());
            return true;
        }

        public bool DeleteAwardToUser(int userId, int awardId)
        {
            MemoryStorage.DeleteAwardToUser(userId, awardId);
            
            DeleteAwardIndexToUserToFile(userId.ToString(), awardId.ToString());
            return true;
        }

        public ICollection<User> GetAllUsers()
        {
            OutputInformation(constForOutputAllUsersInFunction);
            return MemoryStorage.GetAllUsers();
        }

        public ICollection<Award> GetAllAwards()
        {
            OutputInformation(constForOutputAllAwardsInFunction);
            return MemoryStorage.GetAllAwards();
        }

        public ICollection<UserAndAwards> GetAllUsersAndAwards()
        {
            OutputInformation(constForOutputAllAwardsAndUsersInFunction);
            return MemoryStorage.GetAllUsersAndAwards();
        }
    }
}