
namespace BookStore.Interface
{
    public interface IObserver
    {
        void Update(IOrderSubject orderSubject);
        string Role { get; }
    }
}
