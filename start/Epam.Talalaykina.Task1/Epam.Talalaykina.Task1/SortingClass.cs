namespace Epam.Talalaykina.Task1
{
    public class SortingClass
    {
        public void SortingArray(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int subElem = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = subElem;
                    }
                }
            }
        }
    }
}