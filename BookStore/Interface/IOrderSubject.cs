

namespace BookStore.Interface
{
    public interface IOrderSubject
    {

        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void Notify();
    }
}
