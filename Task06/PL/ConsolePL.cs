using System;
using System.Collections.Generic;
using System.Linq;
using BLL;
using BLL.Interface;
using Common;
using Entities;
using Microsoft.Win32;

namespace PL
{
    public class ConsolePL
    {
        private const int constForOutputAllUsersInFunction = 1;
        private const int constForOutputAllAwardsInFunction = 2;
        private const int constForOutputAllAwardsAndUsersInFunction = 3;
        
        public void ShowConsoleMenu()
        {
            var userManager = DependensiesClass.UserManager; 
            var awardManager = DependensiesClass.AwardManager; 
            var userAndAwardsManager = DependensiesClass.UserAndAwardsManager; 
            
        
            bool isInput = true;

            while (isInput)
            {
                Console.WriteLine("What to do?" + Environment.NewLine + "\t 1: add user" + Environment.NewLine +
                                  "\t 2: add award"
                                  + Environment.NewLine + "\t 3: add award to user" + Environment.NewLine +
                                  "\t 4: delete user"
                                  + Environment.NewLine + "\t 5: delete award" + Environment.NewLine +
                                  "\t 6: delete award from user"
                                  + Environment.NewLine + "\t 7: show all users" + Environment.NewLine +
                                  "\t 8: show all awards"
                                  + Environment.NewLine + "\t 9: show all users with awards" + Environment.NewLine +
                                  "\t 10: exit");

                if (int.TryParse(Console.ReadLine(), out int result))
                {
                    switch (result)
                    {
                        case 1:
                        {
                            AddUserConsole(userManager, CreateUserConsole());
                            
                            break;
                        }

                        case 2:
                        {
                            AddAwardConsole(awardManager, CreateAwardConsole());
                            
                            break;
                        }

                        case 3:
                        {
                            List<int> infoList = TakeUserAndAwardInformation();
                            
                            AddAwardToUserConsole(userAndAwardsManager, infoList[0], infoList[1]);
                            
                            break;
                        }

                        case 4:
                        {
                            DeleteUserConcole(userManager, CreateUserConsole());
                            
                            break;
                        }

                        case 5:
                        {
                            DeleteAwardConcole(awardManager, CreateAwardConsole());
                            
                            break;
                        }

                        case 6:
                        {
                            List<int> infoList = TakeUserAndAwardInformation();
                            
                            DeleteAwardToUserConsole(userAndAwardsManager, infoList[0], infoList[1]);
                            
                            break;
                        }

                        case 7:
                        {
                            GetAllUsers(userManager);
                            OutputInformation(userManager, awardManager, userAndAwardsManager, constForOutputAllUsersInFunction);
                            
                            break;
                        }

                        case 8:
                        {
                            GetAllAwards(awardManager);
                            OutputInformation(userManager, awardManager, userAndAwardsManager, constForOutputAllAwardsInFunction);
                            
                            break;
                        }

                        case 9:
                        {
                            GetAllUsersAndAwards(userAndAwardsManager);
                            OutputInformation(userManager, awardManager, userAndAwardsManager, constForOutputAllAwardsAndUsersInFunction);
                            
                            break;
                        }

                        case 10:
                        {
                            isInput = false;
                            break;
                        }

                        default:
                        {
                            Console.WriteLine("Unknown command!");
                            break;
                        }
                    }
                }
                else
                {
                    throw new ArgumentException("Wrong input data format!");
                }
            }
        }

        private static void AddUserConsole(IUserManager userManager, User user)
        {
            userManager.AddUser(user);
        }

        private void AddAwardConsole(IAwardManager awardManager, Award award)
        {
            awardManager.AddAward(award);
        }

        private void AddAwardToUserConsole(IUserAndAwardsManager userAndAwardsManager, int userId, int awardId)
        {
            userAndAwardsManager.AddAwardToUser(userId, awardId);
        }

        private void DeleteUserConcole(IUserManager userManager, User user)
        {
            userManager.DeleteUser(user);
        }
        
        private void DeleteAwardConcole(IAwardManager awardManager, Award award)
        {
            awardManager.DeleteAward(award);
        }

        private void DeleteAwardToUserConsole(IUserAndAwardsManager userAndAwardsManager, int userId, int awardId)
        {
            userAndAwardsManager.DeleteAwardToUser(userId, awardId);
        }

        private void GetAllUsers(IUserManager userManager)
        {
            userManager.GetAllUsers();
        }

        private void GetAllAwards(IAwardManager awardManager)
        {
            awardManager.GetAllAwards();
        }

        private void GetAllUsersAndAwards(IUserAndAwardsManager userAndAwardsManager)
        {
            userAndAwardsManager.GetAllUsersAndAwards();
        }

        private User CreateUserConsole()
        {
            int userId;
            DateTime userDateOfBirth;
                            
            Console.WriteLine("Please, input user's ID:");
            if (int.TryParse(Console.ReadLine(), out int inputUserId))
            {
                userId = inputUserId;
            }
            else
            {
                throw new ArgumentException("It's not an integer value!");
            }
                            
            Console.WriteLine("Please, input user's name:");
            var userName = Console.ReadLine();
            foreach (var charElement in userName)
            {
                if (charElement == ' ')
                {
                    throw new ArgumentException("Spaces are not allowed!");
                }
            }
                            
            Console.WriteLine("Please, input user's date of birth:");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime inputUserDateOfBirth))
            {
                userDateOfBirth = inputUserDateOfBirth;
            }
            else
            {
                throw new ArgumentException("It's not right date value!");
            }

            return new User(userId, userName, userDateOfBirth);
        }

        private Award CreateAwardConsole()
        {
            int awardId;

            Console.WriteLine("Please, input award's ID:");
            if (int.TryParse(Console.ReadLine(), out int inputAwardId))
            {
                awardId = inputAwardId;
            }
            else
            {
                throw new ArgumentException("It's not an integer value!");
            }
                            
            Console.WriteLine("Please, input award's title:");
            var awardTitle = Console.ReadLine();
            foreach (var charElement in awardTitle)
            {
                if (charElement == ' ')
                {
                    throw new ArgumentException("Spaces are not allowed!");
                }
            }

            return new Award(awardId, awardTitle);
        }

        private List<int> TakeUserAndAwardInformation()
        {
            List<int> outputList = new List<int>();                
            Console.WriteLine("Please, input user's ID:");
            if (int.TryParse(Console.ReadLine(), out int inputUserId))
            {
                outputList.Add(inputUserId);
            }
            else
            {
                throw new ArgumentException("It's not an integer value!");
            }
                            
            Console.WriteLine("Please, input award's ID:");
            if (int.TryParse(Console.ReadLine(), out int inputAwardId))
            {
                outputList.Add(inputAwardId);
            }
            else
            {
                throw new ArgumentException("It's not an integer value!");
            }

            return outputList;
        }
        
        public void OutputInformation(IUserManager userManager, IAwardManager awardManager,
            IUserAndAwardsManager userAndAwardsManager, int typeOfOutputInformation)
        {
            if (typeOfOutputInformation == 1)
            {
                Console.WriteLine("All users' information:");
                foreach (var user in userManager.GetAllUsers())
                {
                    Console.WriteLine(user.ToString());
                }
            }
            else if (typeOfOutputInformation == 2)
            {
                Console.WriteLine("All awards' information:");
                foreach (var award in awardManager.GetAllAwards())
                {
                    Console.WriteLine(award.ToString());
                }
            }
            else if (typeOfOutputInformation == 3)
            {
                Console.WriteLine("All information about users and their awards:");
                
                for (int i = 0; i < userAndAwardsManager.GetAllUsersAndAwards().Count; i++)
                {
                    foreach (var user in userManager.GetAllUsers())
                    {
                        if (user.Id == userAndAwardsManager.GetAllUsersAndAwards().ElementAt(i).UserId)
                        {
                            Console.WriteLine("User:");
                            Console.WriteLine(user.ToString());
                            Console.WriteLine("Awards:");
                        }
                    }

                    foreach (var award in awardManager.GetAllAwards())
                    {
                        if (userAndAwardsManager.GetAllUsersAndAwards().ElementAt(i).ListOfAwards.Contains(award.Id))
                        {
                            Console.WriteLine(award.ToString());
                        }
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}