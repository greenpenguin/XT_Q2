using System;
using System.Collections.Generic;

namespace Epam.Talalaykina.Task00._1._1
{
    public class FunctionClass
    {
        public string StringCreation(int n)
        {
            string resultString = String.Empty;
            List<int> numbers = new List<int>();
            
            for (int i = 1; i <= n; i++)
            {
                numbers.Add(i);
            }
            
            resultString = String.Join(", ", numbers);
            
            return resultString;
        }
    }
}
