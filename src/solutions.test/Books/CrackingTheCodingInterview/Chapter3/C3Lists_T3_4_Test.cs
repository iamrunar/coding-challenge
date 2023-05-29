using Shouldly;
using solutions.Books.CrackingTheCodingInterview.Chapter3.Task3p4;

namespace solutions.test.Books.CrackingTheCodingInterview.Chapter3.Task3_4;

public class C3Lists_T3_4_Test
{
    [Fact]
    public void Enqueue_AddToFirstStackButSecondIsEmpty()
    {
        var queue = new MyQueue();

        queue.Enqueue(1);
        queue.Enqueue(5);

        //internal assert!
        queue.EnqueueStack
             .Pop()
             .ShouldBe(5);

        queue.EnqueueStack
             .Pop()
             .ShouldBe(1);

        queue.DequeueStack
             .Count
             .ShouldBe(0);
        //internal assert!
    }

    [Fact]
    public void Enqueue_DequeuedRightValue()
    {
        var queue = new MyQueue();

        queue.Enqueue(1);
        queue.Enqueue(5);
        queue.Enqueue(0);

        queue.Dequeue()
             .ShouldBe(1);

        queue.Dequeue()
             .ShouldBe(5);

        queue.Dequeue()
             .ShouldBe(0);
    }

    [Fact]
    public void AddedToFirstStack_Dequeue_SecondStackIsFullyButFirstIsEmpty()
    {
        var queue = new MyQueue();

        queue.Enqueue(1);
        queue.Enqueue(5);
        queue.Enqueue(0);
        //here
        //1 [0,5,1]
        //2 []

        queue.Dequeue()
             .ShouldBe(1);
        //here
        //1 []
        //2 [5,0]

        //internal assert!
        queue.EnqueueStack
             .Count
             .ShouldBe(0);

        queue.DequeueStack
             .Count
             .ShouldBe(2);

        queue.DequeueStack
             .Pop()
             .ShouldBe(5);

        queue.DequeueStack
             .Pop()
             .ShouldBe(0);
    }
}

