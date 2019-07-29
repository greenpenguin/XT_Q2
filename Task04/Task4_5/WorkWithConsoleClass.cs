using System;

namespace Task4_5
{
    public class WorkWithConsoleClass
    {
        public string Input()
        {
            Console.WriteLine("Please, input the string");
            string str = Console.ReadLine();
            
            return str;
        }

        public void Output(bool result)
        {
            if (result)
            {
                Console.WriteLine("It's positive integer value");
            }
            else
            {
                Console.WriteLine("It's not positive integer value");
            }
        }
    }
}