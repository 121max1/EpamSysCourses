using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp3.Entities
{
    public class Pizzeria
    {
        private List<Order> _ordersDesk;
        public List<Pizza> pizzas;
        private Dictionary<string, Pizza> pizzasToOrder = new Dictionary<string, Pizza>();

        public event Action<object, Order> OnReady;
        public event Action<object, Order> OnAcceptOrder;



        public Pizzeria(List<Pizza> pizzas)
        {
            _ordersDesk = new List<Order>();
            pizzas.ForEach(pizza => pizzasToOrder.Add(pizza.Type, pizza));
            
        }
        public async Task CreateAndAddOrderToDesk(Buyer buyer, Pizza pizzaOrder)
        {
            var pizza = pizzasToOrder[pizzaOrder.Type];
            if (pizza == null)
            {
                throw new Exception($" Пиццы{pizzaOrder.Type} не существует");
            }
            var order = new Order() 
            {
                Buyer = buyer,
                Pizza = pizza
            };
            _ordersDesk.Add(order);

            OnAcceptOrder.Invoke(this, order);

            await CookPizza(order);


        }
        private async Task CookPizza(Order order)
        {
            await Task.Delay(order.Pizza.CookingTime*1000);
            OnReady?.Invoke(this, order);
            _ordersDesk.Remove(order);

        }
    }
}
