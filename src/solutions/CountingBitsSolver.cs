namespace solutions.easy;

public class CountingBitsSolver
{
    public int[] CountBits(int n)
    {
        var r1 = CountBits3(n);
        var r2 = CountBits2(n);
        var r3 = CountBits3(n);
        if (!r1.SequenceEqual(r2) || !r1.SequenceEqual(r3))
        {
            throw new InvalidOperationException("Incorrect answer");
        }
        return r1;
    }

    public int[] CountBits3(int n)
    {
        var ans = new int[n + 1];
        for (int i = 1; i <= n; i++)
        {
            ans[i] = ans[i / 2] + i % 2;
        }
        return ans;
    }

    public int[] CountBits2(int n)
    {
        var ans = new int[n + 1];
        //ans[0] = 0;

        for (int i = 1; i <= n; i++)
        {
            ans[i] = Counter(i);
        }
        return ans;

        int Counter(int nu)
        {
            if (nu == 1)
            {
                return 1;
            }
            if (nu == 2)
            {
                return 1;
            }

            return Counter(nu / 2) + nu % 2;
        }
    }

    public int[] CountBits1(int n)
    {
        var result = new int[n+1];

        for (int i = 0; i<=n; i++)
        {

            result[i]= Count1ForValue(i);
        }
        return result;

        int Count1ForValue(int value)
        {
            int counter = 0;
            for (int i=0;i<sizeof(int); i++, value >>= 1)
            {
                if ((value & 1) == 1)
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
