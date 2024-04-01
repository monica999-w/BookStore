using BookStore;

class Program
{
    static void Main(string[] args)
    {
      
        OrderSystem orderSystem = new OrderSystem();

       
        Customer customer1 = new Customer("Monica");
        Customer customer2 = new Customer("Adina");
        Staff staff1 = new Staff("Alex");
        Staff staff2 = new Staff("Razvan");

       
        orderSystem.Attach(customer1);
        orderSystem.Attach(customer2);
        orderSystem.Attach(staff1);
        orderSystem.Attach(staff2);

       
        orderSystem.PlaceOrder("Book: 'Design Patterns'");
        orderSystem.OrderReadyForShipping("Book: 'Design Patterns'");
        orderSystem.OrderInWarehouse("Book: 'Design Patterns'");
        orderSystem.OrderShipped("Book: 'Design Patterns'");



        orderSystem.Detach(customer2);

       
        orderSystem.PlaceOrder("Book: 'Clean Code'");

        Console.ReadLine();
    }
}