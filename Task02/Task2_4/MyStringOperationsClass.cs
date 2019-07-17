using System.Text;

namespace Task2_4
{
    public class MyStringOperationsClass
    {
        public bool IsEqual(MyString firstMyString, MyString secondMyString)
        {
            if (firstMyString.TakeLength() != secondMyString.TakeLength())
            {
                return false;
            }
            else
            {
                for (int i = 0; i < firstMyString.TakeLength(); i++)
                {
                    if (firstMyString.TakeChar(i) != secondMyString.TakeChar(i))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public int SearchChar(MyString myString, char charForSearching)
        {
            for (int i = 0; i < myString.TakeLength(); i++)
            {
                if (myString.TakeChar(i) == charForSearching)
                {
                    return i;
                }
            }

            return -1;
        }

        public MyString TakeSubstring(MyString myString, int startIndex)
        {
            StringBuilder stringBuilder = new StringBuilder();
            if (myString.TakeLength() < startIndex)
            {
                return new MyString("ERROR: start index is greater than the string length");
            }
            else
            {
                for (int i = startIndex; i < myString.TakeLength(); i++)
                {
                    stringBuilder.Append(myString.TakeChar(i));
                }
            }
            
            return new MyString(stringBuilder.ToString());
        }
        
        public MyString AddSubstring(MyString myString, MyString mySubstring, int startIndex)
        {
            StringBuilder stringBuilder = new StringBuilder();
            if (myString.TakeLength() < startIndex)
            {
                return new MyString("ERROR: start index is greater than the string length");
            }
            else
            {
                for (int i = 0; i < myString.TakeLength(); i++)
                {
                    if (i != startIndex)
                    {
                        stringBuilder.Append(myString.TakeChar(i));
                    }
                    else
                    {
                        for (int j = 0; j < mySubstring.TakeLength(); j++)
                        {
                            stringBuilder.Append(mySubstring.TakeChar(j));
                        }
                    }
                }
            }
            
            return new MyString(stringBuilder.ToString());
        }
    }
}