using _09_AulaNelio.Entities;
using _09_AulaNelio.Entities.Enums;
using System;

namespace _09_AulaNelio
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.Delivered
            };

            Console.WriteLine(order);
            string txt = OrderStatus.PendingPayment.ToString();
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine();
            Console.WriteLine(txt);
            Console.WriteLine(os);
        }
    }
}
