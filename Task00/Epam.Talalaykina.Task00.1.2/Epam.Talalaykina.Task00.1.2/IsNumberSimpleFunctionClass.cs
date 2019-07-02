using System;

namespace Epam.Talalaykina.Task00._1._2
{
    public class IsNumberSimpleFunctionClass
    {
        public bool IsNumberSimpleCheck(int n)
        {
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}