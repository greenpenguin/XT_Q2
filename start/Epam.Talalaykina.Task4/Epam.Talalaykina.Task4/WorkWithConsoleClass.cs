using System;

namespace Epam.Talalaykina.Task4
{
    public class WorkWithConsoleClass
    {
        public int Input()
        {
            int number;
            Console.WriteLine("Please, input a number");
            if (int.TryParse(Console.ReadLine(), out int num))
            {
                if (num >= 0)
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

        public void Output(int result)
        {
            Console.WriteLine("The factorial of this number is " + result);
            
        }

    }
}