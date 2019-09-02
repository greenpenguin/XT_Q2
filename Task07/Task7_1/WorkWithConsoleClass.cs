using System;
using System.Collections.Generic;

namespace Task7_1
{
    public class WorkWithConsoleClass
    {
        private string _str;
        public string Input()
        {
            Console.WriteLine("Please, input the string");
            _str = Console.ReadLine();
        
            return _str;
        }

        public void Output(bool result)
        {
            if (result)
            {
                Console.WriteLine("The string ' " + _str + " ' contains date.");
            }
            else
            {
                Console.WriteLine("The string '" + _str + "' doesn't contain date.");
            }
            
        }
    }
}