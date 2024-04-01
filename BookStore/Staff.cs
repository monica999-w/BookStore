using BookStore.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    public class Staff : IOrderObserver
    {
        private string _name;

        public Staff(string name)
        {
            _name = name;
        }

        public void Update(string message)
        {
            if (message.Contains("New order") || message.Contains("Order ready for shipping"))
                Console.WriteLine($"Staff {_name} received notification: {message}");
        }
    }    
}
