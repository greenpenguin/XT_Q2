using System;

namespace Task1_8
{
    public class WorkWithConsoleClass
    {
        public void ArrayOutput(int[,,] array, bool isChanged)
        {
            if (isChanged)
            {
                Console.WriteLine("The array after changing:");
            }
            else
            {
                Console.WriteLine("The array before changing:");
            }
            
            foreach (var element in array)
            {
                Console.Write(element + " ");
            }
            
            Console.WriteLine();
        }
    }
}