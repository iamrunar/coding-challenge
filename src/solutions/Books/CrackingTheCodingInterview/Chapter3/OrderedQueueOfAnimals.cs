namespace solutions.Books.CrackingTheCodingInterview.Chapter3.Task3p6;
using solutions.Models;

public class OrderedQueueOfAnimals
{
    private LinkedListNode3<Animal> _cats = null;
    private LinkedListNode3<Animal> _dogs = null;

    public Animal? DequeueAny()
    {
        if (_dogs==null && _cats==null)
        {
             throw new InvalidCastException();
        }

        if (_dogs==null)
        {
            return DequeueCat();
        }
        
        if (_cats == null)
        {
            return DequeueDog();
        }

        var dog = _dogs.val;
        var cat = _cats.val;

        if (dog.Yo > cat.Yo)
        {
            return DequeueDog();
        }
        else 
        {
            return DequeueCat();
        }
    }

    public Dog? DequeueDog()
    {
        if (_dogs==null) throw new InvalidCastException();

        var val = _dogs.val;
        _dogs = _dogs.next;
        return val as Dog;
    }

    public Cat? DequeueCat()
    {
        if (_cats==null) throw new InvalidCastException();

        var val = _cats.val;
        _cats = _cats.next;
        return val as Cat;
    }

    public void Enqueue(Animal animal)
    {
        var newAnimalNode = new LinkedListNode3<Animal>(animal);
        LinkedListNode3<Animal> list = GetListOfAnimal(animal);
        var olderAnimalNode = GetPreviousOlderAnimal(list, animal.Yo);
        if (olderAnimalNode == null)
        {
            SetHeadForList(newAnimalNode);
        }
        else
        {
            newAnimalNode.next = olderAnimalNode.next;
            olderAnimalNode.next = newAnimalNode;
        }
    }

    private void SetHeadForList(LinkedListNode3<Animal> newAnimalNode)
    {
        if (newAnimalNode.val is Dog)
        {
            newAnimalNode.next = _dogs;
            _dogs = newAnimalNode;
        }
        else if (newAnimalNode.val is Cat)
        {
            newAnimalNode.next = _cats;
            _cats = newAnimalNode;
        }
    }

    private LinkedListNode3<Animal> GetListOfAnimal(Animal animal)
    {
        if (animal is Dog dog)
        {
            return _dogs;
        }
        else if (animal is Cat cat)
        {
            return _cats;
        }
        else 
            throw new InvalidOperationException();
    }

    private LinkedListNode3<T>? GetPreviousOlderAnimal<T>(LinkedListNode3<T> head, int yo) where T: Animal
    {
        LinkedListNode3<T>? previous = null;
        while (head!=null)
        {
            if (yo > head.val.Yo)
            {
                break;
            }
            previous = head;
            head=head.next;
        }

        return previous;
    }
}

public class Animal
{
    public int Yo {get;}

    public Animal(int yo)
    {
        Yo = yo;
    }
}

public class Cat : Animal
{
    public Cat(int yo)
        :base(yo)
    {
    }
}

public class Dog : Animal
{
    public Dog(int yo)
        :base(yo)
    {
    }
}