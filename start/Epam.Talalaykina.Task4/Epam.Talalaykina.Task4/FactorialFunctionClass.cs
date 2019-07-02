namespace Epam.Talalaykina.Task4
{
    public class FactorialFunctionClass
    {
        public int FactorialCalculate(int number)
        {
            if ((number == 0) || (number == 1))
            {
                return 1;
            }
            else
            {
                return number * FactorialCalculate(number - 1);
            }
        }
    }
}