using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = ReadArray();

            int target = ReadTarget();

            int FindIndex = BinarySearch(array,target);

            Console.WriteLine("Index element = " + FindIndex);

        }

        private int BinarySearch(int[] array, int target)
        {
            int l = 0;
            int r = array.Length - 1;
            while (l <= r)
            {
                int mid = l + (r - 1) / 2;
                if (target < array[mid])
                    r = mid - 1;
                else if (target > array[mid])
                    l = mid + 1;
                else
                    return mid;
            
            }
            return -1;

        }

        private static int[] ReadArray()
        {
            Console.WriteLine("Enter number of elements:");
            string line = Console.ReadLine();
            int count = Int32.Parse(line);

            int[] array = new int[count];
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Enter element " + i);
                string current = Console.ReadLine();
                array[i] = Int32.Parse(current);
            }

            return array;

        }

        private static int ReadTarget()
        {
            Console.WriteLine("Enter target number:");
            string line = Console.ReadLine();
            int target = Int32.Parse(line);

            return target;
        }
    }

}
