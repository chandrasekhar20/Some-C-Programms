using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jagged_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declared Jagged Array....
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[3];
            jaggedArray[2] = new int[2];

            jaggedArray[0] = new int[] { 1, 2, 3, 4, 5 };
            jaggedArray[1] = new int[] { 6, 7, 8 };
            jaggedArray[2] = new int[] { 9, 10 };

            Console.WriteLine("The value in the middle of the first entry is :" + jaggedArray[0][2]);

           for(int i = 0; i<jaggedArray.Length; i++)
            {
                Console.WriteLine("Elements "+i);
                for(int j = 0; j<jaggedArray[i].Length; j++)
                {
                    Console.WriteLine(jaggedArray[i][j]);
                }
            }

        }
    }
}
