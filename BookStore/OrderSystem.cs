using BookStore.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    public class OrderSystem : IOrderSubject

    {
        private List<IOrderObserver> _observers = new List<IOrderObserver>();

        public void Attach(IOrderObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IOrderObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify(string message)
        {
            foreach (var observer in _observers)
            {
                observer.Update(message);
            }
        }

        public void PlaceOrder(string orderDetails)
        {
            Console.WriteLine("Order placed: " + orderDetails);
            Notify("New order placed: " + orderDetails);
        }

        public void OrderReadyForShipping(string orderDetails)
        {
            Console.WriteLine("Order ready for shipping: " + orderDetails);
            Notify("Order ready for shipping: " + orderDetails);
        }
        
        public void OrderInWarehouse(string orderDetails)
        {
            Console.WriteLine("Order in warehouse: " + orderDetails);
            Notify("Your order is in our warehouse: " + orderDetails);
        }

        public void OrderShipped(string orderDetails)
        {
            Console.WriteLine("Order shipped: " + orderDetails);
            Notify("Your order is on its way to you: " + orderDetails);
        }


    }
}
