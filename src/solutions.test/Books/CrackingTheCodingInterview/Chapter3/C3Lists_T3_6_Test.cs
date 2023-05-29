using Shouldly;
using solutions.Books.CrackingTheCodingInterview.Chapter3.Task3p6;

namespace solutions.test.Books.CrackingTheCodingInterview.Chapter3.Task3_6;

public class C3Lists_T3_6_Test
{
    [Fact]
    public void EnqueueCat1yo_DequeuedCat1yo()
    {
        var queue = new OrderedQueueOfAnimals();
        var cat1yo = new Cat(1);

        queue.Enqueue(cat1yo);
        queue.DequeueAny()
             .ShouldBe(cat1yo);
    }

    [Fact]
    public void EnqueueTwoCats_DequeuedAnyCorrectOrderCat()
    {
        var queue = new OrderedQueueOfAnimals();
        var cat1yo = new Cat(1);
        var cat2yo = new Cat(2);

        queue.Enqueue(cat1yo);
        queue.Enqueue(cat2yo);

        queue.DequeueAny()
             .ShouldBe(cat2yo);
        queue.DequeueAny()
             .ShouldBe(cat1yo);
    }

    [Fact]
    public void EnqueueTwoCats_DequeuedCatCorrectOrderCat()
    {
        var queue = new OrderedQueueOfAnimals();
        var cat1yo = new Cat(1);
        var cat2yo = new Cat(2);

        queue.Enqueue(cat1yo);
        queue.Enqueue(cat2yo);

        queue.DequeueCat()
             .ShouldBe(cat2yo);
        queue.DequeueCat()
             .ShouldBe(cat1yo);
    }

    [Fact]
    public void EnqueueTwoDogs_DequeuedAnyCorrectOrderCat()
    {
        var queue = new OrderedQueueOfAnimals();
        var dog3yo = new Dog(3);
        var dog4yo = new Dog(4);

        queue.Enqueue(dog3yo);
        queue.Enqueue(dog4yo);

        queue.DequeueAny()
             .ShouldBe(dog4yo);
        queue.DequeueAny()
             .ShouldBe(dog3yo);
    }

    [Fact]
    public void EnqueueTwoDogsAndTwoCats_DequeuedAnyInCorrectOrderCat()
    {
        var queue = new OrderedQueueOfAnimals();
        var cat1yo = new Cat(1);
        var cat3yo = new Cat(3);

        var dog2yo = new Dog(2);
        var dog4yo = new Dog(4);

        queue.Enqueue(dog2yo);
        queue.Enqueue(cat1yo);
        queue.Enqueue(dog4yo);
        queue.Enqueue(cat3yo);

        queue.DequeueAny()
             .ShouldBe(dog4yo);
        queue.DequeueAny()
             .ShouldBe(cat3yo);
        queue.DequeueAny()
             .ShouldBe(dog2yo);
        queue.DequeueAny()
             .ShouldBe(cat1yo);
    }

    [Fact]
    public void EnqueueTwoDogs_DequeuedDogCorrectOrderCat()
    {
        var queue = new OrderedQueueOfAnimals();
        var dog3yo = new Dog(3);
        var dog4yo = new Dog(4);

        queue.Enqueue(dog4yo);
        queue.Enqueue(dog3yo);

        queue.DequeueDog()
             .ShouldBe(dog4yo);
        queue.DequeueDog()
             .ShouldBe(dog3yo);
    }

    [Fact]
    public void EnqueueTwoDogsAndTwoCats_DequeuedDogInCorrectOrderCat()
    {
        var queue = new OrderedQueueOfAnimals();
        var cat1yo = new Cat(1);
        var cat3yo = new Cat(3);

        var dog2yo = new Dog(2);
        var dog4yo = new Dog(4);

        queue.Enqueue(cat3yo);
        queue.Enqueue(dog4yo);
        queue.Enqueue(cat1yo);
        queue.Enqueue(dog2yo);

        queue.DequeueDog()
             .ShouldBe(dog4yo);
        queue.DequeueDog()
             .ShouldBe(dog2yo);
    }

    [Fact]
    public void EnqueueTwoDogsAndTwoCats_DequeuedCatInCorrectOrderCat()
    {
        var queue = new OrderedQueueOfAnimals();
        var cat1yo = new Cat(1);
        var cat3yo = new Cat(3);

        var dog2yo = new Dog(2);
        var dog4yo = new Dog(4);
        var dog3yo = new Dog(3);

        queue.Enqueue(cat3yo);
        queue.Enqueue(dog2yo);
        queue.Enqueue(cat1yo);
        queue.Enqueue(dog3yo);
        queue.Enqueue(dog4yo);

        queue.DequeueCat()
             .ShouldBe(cat3yo);
        queue.DequeueCat()
             .ShouldBe(cat1yo);
    }
}
