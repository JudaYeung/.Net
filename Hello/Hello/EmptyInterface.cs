using System;

namespace BinarySearch
{
    class BinarySearch
    {
        public static void Main(string[] args)
        {
            int[] array = ReadArray();
            int target = ReadTarget();

            int index = Search(array, target);
            Console.WriteLine("The target number in the array index is:" + index);

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

        private static int Search(int[] array, int target)
        {
            int left = 0, right = array.Length - 1;

            while (left <= right)
            {
                int mid = (right - left) / 2 + left;
                int num = array[mid];
                if (num == target) { return mid; }
                else if (num > target) { right = mid - 1; }
                else { left = mid + 1; }
            }
            return -1;
        }
    }
}