using System;

namespace Task3_3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var a = new DynamicArray<int>(new int[]{1,2,3,4,5,6,7});
            a.AddRange(new int[]{ 8,9,10});
            a.Add(10000);
            a.Insert(0, 8);
            a.Remove(0);
            
            foreach (var item in a)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\nCapacity: " + a.Capacity);
            Console.WriteLine("Length: " + a.Length);
            Console.WriteLine(a[0]);
        }
    }
}