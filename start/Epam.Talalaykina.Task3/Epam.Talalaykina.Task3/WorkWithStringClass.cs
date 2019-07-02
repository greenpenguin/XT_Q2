namespace Epam.Talalaykina.Task3
{
    public class WorkWithStringClass
    {
        public string SelectUniqueWords(string[] inputStringArray)
        {
            string outputString = "";
            
            for (int i = 0; i < inputStringArray.Length; i++)
            {
                bool isUnique = true;
                
                for (int j = 0; j < inputStringArray.Length; j++)
                {
                    if ((inputStringArray[i] == inputStringArray[j]) && (i != j))
                    {
                        isUnique = false;
                        break;
                    }

                }
                
                if (isUnique)
                {
                    outputString += inputStringArray[i] + " ";
                }
            }

            return outputString;
        }
    }
}