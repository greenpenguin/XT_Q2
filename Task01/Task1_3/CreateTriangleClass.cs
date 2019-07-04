using System;
using System.Collections.Generic;
using System.Text;

namespace Task1_3
{
    public class CreateTriangleClass
    {
        public List<StringBuilder> TriangleCreating(int n)
        {
            List<StringBuilder> resultList = new List<StringBuilder>();
            
            for (int i = 0; i < n; i++)
            {
                StringBuilder resultString = new StringBuilder(String.Empty);
                for (int j = 0; j < n - i - 1; j++)
                {
                    resultString.Append(" ");
                }
                for (int k = 0; k <= i * 2; k++)
                {
                    resultString.Append("*");
                }
                resultString.Append("\n");
                resultList.Add(resultString);
            }

            return resultList;

        }
        
    }
}