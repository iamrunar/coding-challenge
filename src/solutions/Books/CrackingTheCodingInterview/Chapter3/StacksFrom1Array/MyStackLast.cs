namespace solutions.Books.CrackingTheCodingInterview.Chapter3.StacksFrom1Array;

public class MyStackLast : IMyStack
{
    int _valueOffset;
    int []_array; 

    public MyStackLast(int[] array)
    {
        _array = array;
        _valueOffset = _array.Length;
    }

    public void Push(int value)
    {
        --_valueOffset;
        _array[_valueOffset] = value;
    }

    public int  Pop()
    {
        if(_valueOffset>=_array.Length) throw new InvalidOperationException();
        
        int v = _array[_valueOffset];
        ++_valueOffset;
        return v;
    }
}
