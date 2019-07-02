namespace Epam.Talalaykina.Task2
{
    public class WorkWithArrayClass
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

        public void SearchingElementInformation(int[] array)
        {
            WorkWithConsoleClass workWithConsoleClass = new WorkWithConsoleClass();
            int element = workWithConsoleClass.InputSearchingElement();
            
            if (SearchingElement(element, array) == -1)
            {
                workWithConsoleClass.OutputArrayWithMessage(array, "There is no element = " + element + " in the array");
            }
            else
            {
                workWithConsoleClass.OutputArrayWithMessage(array, "There is element = " + element + " in the array. " +
                    "Its index is " + SearchingElement(element, array));
            }
        }
        
        int SearchingElement(int element, int[] array)
        {
            int left = 0;
            int mid = 0;
            int right = array.Length;
            
            while (!(left >= right))
            {
                mid = left + (right - left) / 2;
            
                if (array[mid] == element)
                    return mid;
            
                if (array[mid] > element)
                    right = mid;
                else
                    left = mid + 1;
            }
            
            return -1;
        }
        
    }
}