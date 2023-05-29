namespace solutions.Books.CrackingTheCodingInterview.Chapter3.StacksFrom1Array;

public class MyStackFirst : IMyStack
{
    int _valueOffset = -1;
    int []_array; 

    public MyStackFirst(int[] array)
    {
        _array = array;
    }

    public void Push(int value)
    {
        ++_valueOffset;
        _array[_valueOffset] = value;
    }

    public int  Pop()
    {
        if(_valueOffset<0) throw new InvalidOperationException();

        int v = _array[_valueOffset];
        --_valueOffset;
        return v;
    }
}
