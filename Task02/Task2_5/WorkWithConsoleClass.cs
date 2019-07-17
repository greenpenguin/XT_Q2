using System;
using System.Collections.Generic;
using System.Linq;

namespace Task2_5
{
    public class WorkWithConsoleClass
    {
        public User InputUserData()
        {
            List<string> dataList = new List<string>();

            User user;
            
            Console.WriteLine("Please, input second name, name, patronymic, date of birth and age of the user in one string. " +
                                          "Also you can input work experience and position of the user.");
            string[] inputString = Console.ReadLine().Split(new[] { ' ', '\r', '\n', ';' },
                    StringSplitOptions.RemoveEmptyEntries)
                .Select(item => item.Trim())
                .Where(item => !string.IsNullOrEmpty(item)).ToArray();
            
            foreach (var t in inputString)
            {
                dataList.Add(t);
            }

            if ((dataList.Count == 5) || (dataList.Count == 7))
            {
                if ((DateTime.TryParse(dataList[3], out DateTime dateOfBirth)) &&
                    (int.TryParse(dataList[4], out int age)))
                {
                    if (dataList.Count() == 5)
                    {
                        user = new User(dataList[0], dataList[1], dataList[2], dateOfBirth, age);
                    }
                    else
                    {
                        if (int.TryParse(dataList[5], out int workExperience))
                        {
                            user = new Employee(dataList[0], dataList[1], dataList[2], dateOfBirth, age, workExperience,
                                dataList[6]);
                        }
                        else
                        {
                            throw new ArgumentException("Wrong work experience format!");
                        }
                    }
                }
                else
                {
                    throw new ArgumentException("Wrong date or time or age format!");
                }
            }
            else
            {
                throw new ArgumentException("You have to fill all fields!");
            }

            return user;
        }
        
        public void Output(string userData)
        {
            Console.WriteLine("The user data: " + userData);
        }
    }
}