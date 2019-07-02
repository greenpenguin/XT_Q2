using System;
using System.Collections.Generic;
using System.Text;

namespace Epam.Talalaykina.Task00._1._3
{
    public class SquareCreatingClass
    {
        public List<StringBuilder> SquareCreating(int n)
        {
            List<StringBuilder> resultList = new List<StringBuilder>();
            
            for (int i = 0; i < n; i++)
            {
                StringBuilder resultString = new StringBuilder(String.Empty);
                for (int j = 0; j < n; j++)
                {
                    if ((i == n/2) && (j == n/2))
                    {
                        resultString.Append("  ");
                    }
                    else
                    {
                        resultString.Append("* ");
                    }
                }
                resultString.Append("\n");
                resultList.Add(resultString);
            }

            return resultList;
        }
    }
}
