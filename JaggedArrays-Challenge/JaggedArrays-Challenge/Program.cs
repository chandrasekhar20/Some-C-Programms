using System;

namespace JaggedArrays_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] friends = new string[][]
            {
                new string[]{"Chandu","Bala"},
                new string[]{"Rama" , "Umesh"},
                new string[]{"Tarak" , "Malli"}
            };

            Console.WriteLine("Hii {0},This is my friend {1}" , friends[0][0] , friends[2][1]);
        }
    }
}
