namespace solutions.Books.CrackingTheCodingInterview.Chapter3.StacksFrom1Array;

public class StackFactory
{
    public IMyStack[] CreateThreeStacks()
    {
        int[] array = new int[100];
        var headStack = new MyStackFirst(array);
        var middleStack = new MyStackCenter(array);
        var tailStack = new MyStackLast(array);
        return new IMyStack[]{headStack, middleStack, tailStack};
    }
}
