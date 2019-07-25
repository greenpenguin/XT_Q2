using System.Collections.Generic;

namespace Task3_2
{
    public class WorkWithStringClass
    {
        public Dictionary<string, int> WordsCount(string[] stringArray)
        {
            Dictionary<string, int> wordsCount = new Dictionary<string, int>();
            
            foreach (var word in stringArray)
            {
                if (!wordsCount.ContainsKey(word))
                {
                    wordsCount.Add(word, 1);
                }
                else
                {
                    wordsCount[word] += 1;
                }
            }

            return wordsCount;
        }
    }
}