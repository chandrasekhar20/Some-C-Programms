using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks_In_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Defining a new stack....
            Stack<int> stack = new Stack<int>();
            //Adding element to the stack using Push() method....
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            foreach(int i in stack)
            {
                Console.WriteLine("Values in the Stack is : " + i);
            }
            //Removing value from the stack by using Pop() method, And we can return the poped value....
            int myStackItem = stack.Pop();
            Console.WriteLine("Removed item from the stack is : " + myStackItem);
            Console.WriteLine("Total data present in the stack is : " + stack.Count());
            Console.WriteLine("The top value present in the stack is : " + stack.Peek());

            while (stack.Count > 0)
            {
                Console.WriteLine("The top value from the stack is removed : " + stack.Pop());

                Console.WriteLine("The current count in stack is : " + stack.Count());
            }

            int[] numbers = {1,2,3,4,5,6,7,8,9 };
            Stack<int> myStack = new Stack<int>();

            Console.WriteLine("The numbers in the array are : ");

            foreach (int number in numbers)
            {
                Console.WriteLine(number + " ");
                myStack.Push(number);
            }

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("The values present in the stack after reversing are : ");

            while(myStack.Count > 0)
            {
                int myPopItem = myStack.Pop();
                Console.WriteLine(myPopItem);
            }
            Console.ReadKey();
        }
    }
}
