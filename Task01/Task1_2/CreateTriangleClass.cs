using System;
using System.Collections.Generic;
using System.Text;

namespace Task1_2
{
    public class CreateTriangleClass
    {
        public List<StringBuilder> TriangleCreating(int n)
        {
            List<StringBuilder> resultList = new List<StringBuilder>();
            
            for (int i = 0; i < n; i++)
            {
                StringBuilder resultString = new StringBuilder(String.Empty);
                for (int j = 0; j <= i; j++)
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