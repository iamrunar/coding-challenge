namespace solutions.Books.CrackingTheCodingInterview.Chapter3.StacksFrom1Array;

public class MyStackCenter : IMyStack
{
    int _startArrayOffset;
    int _valueOffset;

    int []_array; 

    public MyStackCenter(int[] array)
    {
        _array = array;
        _startArrayOffset = array.Length/2;
        _valueOffset = _startArrayOffset-1;
    }

    public void Push(int value)
    {
        ++_valueOffset;
        _array[_valueOffset] = value;
    }

    public int  Pop()
    {
        if(_valueOffset<_startArrayOffset) throw new InvalidOperationException();
        
        int v = _array[_valueOffset];
        --_valueOffset;
        return v;
    }
}