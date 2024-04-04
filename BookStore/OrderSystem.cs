
using BookStore.Interface;


namespace BookStore
{
    public class OrderSystem : IOrderSubject
    {
        private readonly List<IObserver> observers = [];
        private int state;
        
        
        private Dictionary<int, string> stateNames = new Dictionary<int, string>()
        {
           { 1, "Processing" },
           { 2, "Ready" },
           { 3, "Shipped" },
           { 4, "Delivered" },
           { 5, "Received" }
        };

        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in observers)
            {
                observer.Update(this);
            }
        }


        public void UpdateState(int newState)
        {
            state = newState;
            Notify();
        }

        public void Processing()
        {
            Console.WriteLine("Order state updated to 'Processing'.");
            UpdateState(1);
        }

        public void Ready()
        {
            Console.WriteLine("Order state updated to 'Ready'.");
            UpdateState(2);
        }

        public void Shipped()
        {
            Console.WriteLine("Order state updated to 'Shipped'.");
            UpdateState(3);
        }

        public void Delivered()
        {
            Console.WriteLine("Order state updated to 'Delivered'.");
            UpdateState(4);
        }

        public void Received()
        {
            Console.WriteLine("Order state updated to 'Received'.");
            UpdateState(5);
        }

        public string GetState()
        {
            return stateNames[state];
        }
    }
}
