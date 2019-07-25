using System.Collections.Generic;

namespace Task3_1
{
    public class WorkWithListClass
    {
        public List<string> CreateList(int n)
        {
            List<string> peopleList = new List<string>();

            for (int i = 0; i < n; i++)
            {
                peopleList.Add("Person" + (i+1));
            }

            return peopleList;
        }

        public void RemoveFromList(List<string> peopleList)
        {
            WorkWithConsoleClass workWithConsoleClass = new WorkWithConsoleClass();

            int i = 1;
            while (peopleList.Count != 1)
            {
                //workWithConsoleClass.Output(peopleList);
                
                peopleList.RemoveAt(i);
                
                if (i == peopleList.Count)
                {
                    i = 1;
                    continue;
                }
                if (i == peopleList.Count - 1)
                {
                    i = 0;
                    continue;
                }
                i++;
            }
            
            workWithConsoleClass.Output(peopleList);
        }
    }
}