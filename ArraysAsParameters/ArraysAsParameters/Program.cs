using System;

namespace ArraysAsParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            int minNumber = MinValue(10, 20, 30, 2, 3, 4, 5, -293434, 3, 56, 3, 53, 54);
            Console.WriteLine("The smaller value in the given list is :" + minNumber);
        }
        public static int MinValue(params int[] numbers)
        {
            int minValue = int.MaxValue;
            foreach(int number in numbers)
            {
                if (number < minValue)
                    minValue = number;
            }
            return minValue;
        }
    }
}

