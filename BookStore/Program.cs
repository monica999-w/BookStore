using BookStore;
using BookStore.Interface;
using BookStore.Members;

class Program
{
    static void Main(string[] args)
    {
      
        IOrderSubject orderProcessor = new OrderSystem();

       
        Customer customer1 = new Customer("Monica");
        Customer customer2 = new Customer("Adina");
        Staff staff1 = new Staff("Alex");
        Staff staff2 = new Staff("Razvan");


        orderProcessor.Attach(customer1);
        orderProcessor.Attach(customer2);
        orderProcessor.Attach(staff1);
        orderProcessor.Attach(staff2);

        orderProcessor.Detach(customer1);

        ((OrderSystem)orderProcessor).Processing();
        ((OrderSystem)orderProcessor).Delivered();
        ((OrderSystem)orderProcessor).Ready();
        ((OrderSystem)orderProcessor).Shipped();
        ((OrderSystem)orderProcessor).Received();


       
       // orderProcessor.Detach(customer2);
        orderProcessor.Detach(staff1);
       // orderProcessor.Detach(staff2);

       
    }
}