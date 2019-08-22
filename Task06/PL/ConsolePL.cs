using System;
using System.Collections.Generic;
using BLL;
using Entities;
using Microsoft.Win32;

namespace PL
{
    public class ConsolePL
    {
        public void ShowConsoleMenu()
        {
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
                            AddUserConsole(CreateUserConsole());
                            
                            break;
                        }

                        case 2:
                        {
                            AddAwardConsole(CreateAwardConsole());
                            
                            break;
                        }

                        case 3:
                        {
                            List<int> infoList = TakeUserAndAwardInformation();
                            
                            AddAwardToUserConsole(infoList[0], infoList[1]);
                            
                            break;
                        }

                        case 4:
                        {
                            DeleteUserConcole(CreateUserConsole());
                            
                            break;
                        }

                        case 5:
                        {
                            DeleteAwardConcole(CreateAwardConsole());
                            
                            break;
                        }

                        case 6:
                        {
                            List<int> infoList = TakeUserAndAwardInformation();
                            
                            DeleteAwardToUserConsole(infoList[0], infoList[1]);
                            
                            break;
                        }

                        case 7:
                        {
                            GetAllUsers();
                            break;
                        }

                        case 8:
                        {
                            GetAllAwards();
                            break;
                        }

                        case 9:
                        {
                            GetAllUsersAndAwards();
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

        private void AddUserConsole(User user)
        {
            UserManager.AddUser(user);
        }

        private void AddAwardConsole(Award award)
        {
            AwardManager.AddAward(award);
        }

        private void AddAwardToUserConsole(int userId, int awardId)
        {
            UserAndAwardsManager.AddAwardToUser(userId, awardId);
        }

        private void DeleteUserConcole(User user)
        {
            UserManager.DeleteUser(user);
        }
        
        private void DeleteAwardConcole(Award award)
        {
            AwardManager.DeleteAward(award);
        }

        private void DeleteAwardToUserConsole(int userId, int awardId)
        {
            UserAndAwardsManager.DeleteAwardToUser(userId, awardId);
        }

        private void GetAllUsers()
        {
            UserManager.GetAllUsers();
        }

        private void GetAllAwards()
        {
            AwardManager.GetAllAwards();
        }

        private void GetAllUsersAndAwards()
        {
            UserAndAwardsManager.GetAllUsersAndAwards();
        }

        private User CreateUserConsole()
        {
            int userId;
            string userName;
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
            userName = Console.ReadLine();
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
            string awardTitle;
                            
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
            awardTitle = Console.ReadLine();
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
    }
}