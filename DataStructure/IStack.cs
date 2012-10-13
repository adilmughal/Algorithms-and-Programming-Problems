namespace DataStructure
{
    public interface IStack<T>
    {
        void Push(T item);
        T Pop();
        bool IsEmpty();
        bool IsFull();
    }
}