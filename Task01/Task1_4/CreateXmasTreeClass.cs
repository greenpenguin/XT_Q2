using System;
using System.Collections.Generic;
using System.Text;

namespace Task1_4
{
    public class CreateXmasTreeClass
    {
            List<StringBuilder> TriangleCreating(int n, int padding)
            {
                List<StringBuilder> resultList = new List<StringBuilder>();
            
                for (int i = 0; i < n; i++)
                {
                    StringBuilder resultString = new StringBuilder(String.Empty);
                    
                    for (int j = 0; j < padding - i - 1; j++)
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
        
            public List<StringBuilder> XmasTreeCreating(int n)
            {
                List<StringBuilder> resultList = new List<StringBuilder>();

                for (int i = 1; i <= n; i++)
                {
                    resultList.AddRange(TriangleCreating(i, n));
                    
                }
                
                return resultList;
            }
        }
}