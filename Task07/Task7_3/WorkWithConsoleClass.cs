using System;

namespace Task7_3
{
    public class WorkWithConsoleClass
    {
        public string Input()
        {
            Console.WriteLine("Please, input the string");
            string str = Console.ReadLine();
        
            return str;
        }

        public void Output(string result)
        {
            Console.WriteLine(result);
        }
    }
}