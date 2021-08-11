using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiDimensionalArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] matrix; //Declare 2D array....
            //Two dimensional array....
            int[,] array2d = new int[,]
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };
            Console.WriteLine("Central value is " + array2d[1,1]);
            Console.WriteLine("Third row First column number is " + array2d[2,0]);

            int[,,] array3d = new int[,,]
            {
                {
                    {1,2 },
                    {3,4 }
                },
                {
                    {5,6 },
                    {7,8 }
                },
                {
                    {9,10 },
                    {11,12 }
                }
            };
            Console.WriteLine("Umm Integer is :" + array3d[0, 1, 0]);

            int[,] array2dInt = new int[3, 2]
            {
                {1,2 },
                {3,4 },
                {5,6 }
            };
            Console.WriteLine("Umm another number is :" +array2dInt[1,1]);
            array2dInt[1, 1] = 10;
            Console.WriteLine("Modified number is :" + array2dInt[1,1]);
            int dimenstions = array3d.Rank;
            Console.WriteLine(dimenstions);
        }
    }
}
