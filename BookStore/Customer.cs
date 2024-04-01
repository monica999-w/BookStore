using BookStore.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    public class Customer : IOrderObserver
    {
        private string _name;

        public Customer(string name)
        {
            _name = name;
        }

        public void Update(string message)
        {
            Console.WriteLine($"Customer {_name} received notification: {message}");
        }
    }
}
