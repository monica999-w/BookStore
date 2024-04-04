
using BookStore.Interface;


namespace BookStore.Members
{
    public class Customer : IObserver
    {
        private string _name;
        public string Role => "Customer";

        public Customer(string name)
        {
            _name = name;
        }


        public void Update(IOrderSubject orderSubject)
        {
            string stateName = ((OrderSystem)orderSubject).GetState();
            if (Role == "Customer" && (stateName == "Ready" || stateName == "Shipped"))
                Console.WriteLine($"Notification for customer {_name}: Order is in state {stateName}");
        }
    }
}
