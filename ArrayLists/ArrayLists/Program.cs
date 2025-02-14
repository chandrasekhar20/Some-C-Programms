﻿using System;
using System.Collections;

namespace ArrayLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring an ArrayList with undefined amount of objects....
            ArrayList myArrayList = new ArrayList();
            //Declaring an ArrayList with defined amount of objects....
            ArrayList myArrayList2 = new ArrayList(2);
            //Adding objects to ArrayList....
            myArrayList.Add(25);
            myArrayList.Add(10);
            myArrayList.Add("Chandu");
            myArrayList.Add(1.5);
            myArrayList.Add('a');

            //Deleting elements with specific value form the ArrayList....
           // myArrayList.Remove(25);

            //Deleting elements with specific Index in the ArrayList....
           // myArrayList.RemoveAt(2);
            //....................
            Console.WriteLine(myArrayList.Count);
            int sum = 0;

            foreach(object obj in myArrayList)
            {
                if(obj is int)
                {
                    sum = sum + Convert.ToInt32(obj);
                }
                Console.WriteLine(obj);
            }
            Console.WriteLine(sum);
        }
    }
}
