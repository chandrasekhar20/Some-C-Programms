using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues_In_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<Order> ordersQueue = new Queue<Order>();

            foreach(Order o in RecieveOrdersFromBranch1())
            {
                ordersQueue.Enqueue(o);
            }
            foreach(Order o in RecieveOrdersFromBranch2())
            {
                ordersQueue.Enqueue(o);
            }

            while(ordersQueue.Count > 0)
            {
                Order currentOrder = ordersQueue.Dequeue();
                currentOrder.ProcessOrder();
            }
        }

        static Order[] RecieveOrdersFromBranch1()
        {
            Order[] orders = new Order[]
            {
                new Order(1,2),
                new Order(2,4),
                new Order(3,6)
            };
            return orders;
        }

        static Order[] RecieveOrdersFromBranch2()
        {
            Order[] orders = new Order[]
            {
                new Order(4,7),
                new Order(5,8),
                new Order(6,9)
            };
            return orders;
        }
    }

    class Order
    {
        public int OrderId { get; set; }
        public int OrderQuantity { get; set; }

        public Order(int id , int quantity)
        {
            this.OrderId = id;
            this.OrderQuantity = quantity;
        }

        public void ProcessOrder()
        {
            Console.WriteLine($"Order {OrderId} processed!.");
        }
    }
}
