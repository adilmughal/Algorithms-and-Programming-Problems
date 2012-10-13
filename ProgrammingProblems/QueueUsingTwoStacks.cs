using DataStructure;

namespace ProgrammingProblems
{
    public class QueueUsingTwoStacks<T>
    {
        private readonly Stack<T> _inStack;
        private readonly Stack<T> _outStack;

        public QueueUsingTwoStacks(int capacity)
        {
            _inStack = new Stack<T>(capacity);
            _outStack = new Stack<T>(capacity);
        }

        public void Enqueue(T item)
        {
            _inStack.Push(item);
        }

        public T Dequeue()
        {
            if (!_outStack.IsEmpty())
                return _outStack.Pop();

            while (!_inStack.IsEmpty())
            {
                _outStack.Push(_inStack.Pop());
            }
                
            return _outStack.Pop();
        }
    }
}