
using BookStore.Interface;


namespace BookStore.Members
{
    public class Staff : IObserver
    {
        private string _name;
        public string Role => "Staff";
        public Staff(string name)
        {
            _name = name;
        }

        public void Update(IOrderSubject orderSubject)
        {
            string state = ((OrderSystem)orderSubject).GetState();
            if (Role == "Staff")
                Console.WriteLine($"Notification for staff {_name}: Order is in state {state}.");
        }

    }
}
