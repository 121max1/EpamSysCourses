using ConsoleApp3.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Task3_3_3
{
    class Program
    {
        private static  void Pizzeria_OnAcceptOrder(object sender, Order order)
        {
            Console.WriteLine($"{order.Buyer.Name} ваш заказ {order.Pizza.Type} пицца принят") ;
        }
        private static  void Pizzeria_OnReady(object sender, Order order)
        {
            Console.WriteLine($"{order.Buyer.Name} ваш заказ {order.Pizza.Type} пицца готов");
        }
        async static Task Main(string[] args)
        {
            var pizzaList = new List<Pizza>()
            {
                new Pizza()
                {
                    Price = 400,
                    CookingTime =5,
                    Type = "Мясная"
                },
                new Pizza()
                {
                    Price = 350,
                    CookingTime = 4,
                    Type = "Гавайская"
                },
                new Pizza()
                {
                    Price = 200,
                    CookingTime = 3,
                    Type = "Барбекю"

                }
            };
            Pizzeria pizzeria = new Pizzeria(pizzaList);
            pizzeria.OnAcceptOrder += Pizzeria_OnAcceptOrder;
            pizzeria.OnReady += Pizzeria_OnReady;
            await pizzeria.CreateAndAddOrderToDesk(new Buyer()
            {
                Name = "Максим"
            },
           pizzaList[0]);
        }
    }
}
