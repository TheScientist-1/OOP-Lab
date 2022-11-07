using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{

    /*З допомогою шаблону "Facade" створено реалізувати модель покупки одягу в онлайн-магазині з доставкою. 
     Клас Facade делегує реалізацію замовлення від клієнта до відповідних об'єктів підсистем (Order, ClothingStore, ShippingService).*/

    // Mainapp test application 
    class MainApp
    {
        static void Main(string[] args)
        {
            var store = new ClothingStore();
            var shippingService = new ShippingService();
            var facade = new Facade(store, shippingService);
            var dressOrder = new Order() { ClothingName = "Black Dress", ClothingPrice = 1500.0, Client = "Anna", ShippingAddress = "Street 1" };
            var sweatshirtOdrer = new Order() { ClothingName = "Fluffy Sweatshirt", ClothingPrice = 500, Client = "Maria", ShippingAddress = "Street 2" };
            facade.OrderClothing(new List<Order>() { dressOrder, sweatshirtOdrer });
            Console.ReadLine();
        }
    }

    // "Subsystem ClassA" 
     public class Order
    {
        public string ClothingName { get; set; }
        public double ClothingPrice { get; set; }
        public string Client { get; set; }
        public string ShippingAddress { get; set; }
        public double ShippingPrice { get; set; }
        public override string ToString()
        {
            return string.Format("Client {0} ordered {1}. The full price is {2} dollars.",
                Client, ClothingName, ClothingPrice + ShippingPrice);
        }
    }

    // Subsystem ClassB" 
    public class ClothingStore
    {
        private readonly List<Order> _cart;
        public ClothingStore()
        {
            _cart = new List<Order>();
        }
        public void AddOrderToCart(Order order)
        {
            _cart.Add(order);
        }
        public void CompleteOrders()
        {
            Console.WriteLine("Orders completed. Dispatch in progress...");
        }
    }


    // Subsystem ClassC" 
   public class ShippingService
    {
        private Order _order;
        public void AcceptOrder(Order order)
        {
            _order = order;
        }
        public void CalculateShippingExpenses()
        {
            _order.ShippingPrice = 15.5;
        }
        public void ShipOrder()
        {
            Console.WriteLine(_order.ToString());
            Console.WriteLine("Order is being shipped to {0}...", _order.ShippingAddress);
        }
    }
    
    // "Facade" 
    public class Facade
    {
        private readonly ClothingStore _store;
        private readonly ShippingService _shippingService;
        public Facade(ClothingStore store, ShippingService shippingService)
        {
            _store = store;
            _shippingService = shippingService;
        }
        public void OrderClothing(List<Order> orders)
        {
            foreach (var order in orders)
            {
                _store.AddOrderToCart(order);
            }
            _store.CompleteOrders();
            foreach (var order in orders)
            {
                _shippingService.AcceptOrder(order);
                _shippingService.CalculateShippingExpenses();
                _shippingService.ShipOrder();
            }
        }
    }
}
