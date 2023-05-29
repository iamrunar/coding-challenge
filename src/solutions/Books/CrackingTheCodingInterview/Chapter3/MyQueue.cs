namespace solutions.Books.CrackingTheCodingInterview.Chapter3.Task3p4;

public class MyQueue
{
    //development only
    public Stack<int> EnqueueStack {get;} = new Stack<int>();

    //development only
    public Stack<int> DequeueStack { get; } = new Stack<int>();

    public int Dequeue()
    {
        if (DequeueStack.Count == 0)
        {
            while (EnqueueStack.Count>0)
                DequeueStack.Push(EnqueueStack.Pop());
        }

        return DequeueStack.Pop();
    }

    public void Enqueue(int v)
    {
        EnqueueStack.Push(v);
    }
}