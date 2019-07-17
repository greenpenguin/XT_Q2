using System;
using System.Collections.Generic;

namespace Task2_3
{
    public class WorkWithConsoleClass
    {
        public List<string> InputUserData()
        {
            List<string> userData = new List<string>();
            
            Console.WriteLine("Please, input second name of the user");
            userData.Add(Console.ReadLine());
            
            Console.WriteLine("Please, input name of the user");
            userData.Add(Console.ReadLine());
            
            Console.WriteLine("Please, input patronymic of the user");
            userData.Add(Console.ReadLine());
            
            Console.WriteLine("Please, input date of birth of the user");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime dateOfBirth))
            {
                userData.Add(dateOfBirth.ToString());
            }
            else
            {
                throw new ArgumentException("Wrong date or time format!");
            }
            
            Console.WriteLine("Please, input age of the user");
            if (int.TryParse(Console.ReadLine(), out int age))
            {
                userData.Add(age.ToString());
            }
            else
            {
                throw new ArgumentException("Wrong age format!");
            }

            return userData;
        }

        public void Output(string userData)
        {
            Console.WriteLine("The user data: " + userData);
        }
        
    }
}