using System;

namespace Epam.Talalaykina.Task00._1._1
{
    public class WorkWithConsoleClass
    {
        public int Input()
        {
            int number;
            Console.WriteLine("Please, input a number that is greater than zero");
            if (int.TryParse(Console.ReadLine(), out int num))
            {
                if (num > 0)
                {
                    number = num;
                }
                else
                {
                    throw new ArgumentException("The number must be greater than zero!");
                }
            }
            else
            {
                throw new ArgumentException("It's not an integer value!");
            }
            
            return number;
        }

        public void Output(string result)
        {
            Console.WriteLine("The function's result is: " + result);
            
        }

    }
}