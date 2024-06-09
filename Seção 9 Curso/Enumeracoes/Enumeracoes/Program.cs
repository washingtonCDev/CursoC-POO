using Enumeracoes.Entities.Enums;
using Enumeracoes.Entities;
using System;
namespace Enumeracoes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Order order = new Order
            {
                Id = 1090,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();//convertendo ENUMERADO para STRING

            OrderStatus os = (OrderStatus)Enum.Parse(typeof(OrderStatus), "Delivered");
            /* Convertendo String para tipo Enumerado - os recebe a conversão
            de um string para tipo  enumerado
            "Delivered" deve estar escrito igual na OrderStatus */

            Console.WriteLine(txt);
            Console.WriteLine(os);
        }
    }
}