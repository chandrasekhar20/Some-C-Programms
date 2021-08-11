using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nested_for_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string star = "*";
            for(int i = 0; i<5; i++)
            {
                for(int j = 0; j<5;j++)
                {
                    if(i == 0 && j == 0 && j == 1)
                    Console.Write(" ");
                    else Console.WriteLine(star);
                }
                Console.WriteLine("");
            }
        }
    }
}
