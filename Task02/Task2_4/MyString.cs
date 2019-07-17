using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Task2_4
{
    public class MyString
    {
        List<char> myString = new List<char>();
        
        public MyString(string inputStr)
        {
            for (int i = 0; i < inputStr.Length; i++)
            {
                myString.Add(inputStr[i]);
            }
        }

        public string MyStringToString(MyString myString)
        {
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < myString.TakeLength(); i++)
            {
                stringBuilder.Append(myString.TakeChar(i));
            }

            return stringBuilder.ToString();
        }

        public MyString StringToMyString(string str)
        {
            return new MyString(str);
        }

        public char TakeChar(int index)
        {
            return myString[index];
        }

        public int TakeLength()
        {
            return myString.Count;
        }
        
        public MyString SumMyString(MyString firstMyString, MyString secondMyString)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(MyStringToString(firstMyString));
            stringBuilder.Append(MyStringToString(secondMyString));
            
            return new MyString(stringBuilder.ToString());
        }
    }
}