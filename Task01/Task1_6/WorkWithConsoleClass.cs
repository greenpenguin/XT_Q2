using System;
using System.Text;

namespace Task1_6
{
    public class WorkWithConsoleClass
    {
        public void SwichFontAdjustment()
        {
            bool isBold = false;
            bool isItalic = false;
            bool isUnderline = false;
            bool isInput = true;

            while (isInput)
            {
                Console.WriteLine("Параметры надписи: " + Output(isBold, isItalic, isUnderline));
                Console.WriteLine("Введите:" + Environment.NewLine + "\t 1: bold" + Environment.NewLine + "\t 2: italic"
                                  + Environment.NewLine + "\t 3: underline" + Environment.NewLine + "\t 4: выход из программы");
                
                if (int.TryParse(Console.ReadLine(), out int result))
                {
                    switch (result)
                    {
                        case 1:
                        {
                            isBold = !isBold;
                            break;
                        }

                        case 2:
                        {
                            isItalic = !isItalic;
                            break;
                        }

                        case 3:
                        {
                            isUnderline = !isUnderline;
                            break;
                        }

                        case 4:
                        {
                            isInput = false;
                            break;
                        }
                    }
                }
            }
        }

        string Output(bool isBold, bool isItalic, bool isUnderline)
        {
            string resultString = String.Empty;
            
            if ((!isBold) && (!isItalic) && (!isUnderline))
            {
                resultString = "None";
            }
            else if ((isBold) && (!isItalic) && (!isUnderline))
            {
                resultString = "Bold";
            }
            else if ((!isBold) && (isItalic) && (!isUnderline))
            {
                resultString = "Italic";
            }
            else if ((!isBold) && (!isItalic) && (isUnderline))
            {
                resultString = "Underline";
            }
            else if ((isBold) && (isItalic) && (!isUnderline))
            {
                resultString = "Bold, Italic";
            }
            else if ((isBold) && (!isItalic) && (isUnderline))
            {
                resultString = "Bold, Underline";
            }
            else if ((!isBold) && (isItalic) && (isUnderline))
            {
                resultString = "Italic, Underline";
            }
            else 
            {
                resultString = "Bold, Italic, Underline";
            }
            
            return resultString;
        }
    }
}