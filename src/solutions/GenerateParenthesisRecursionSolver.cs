using System.Security.Cryptography.X509Certificates;

namespace solutions.easy;

public class GenerateParenthesisRecursionSolver
{
    public IList<string> GenerateParenthesis(int n)
    {
        List<string> list = new List<string>();
        //func(1, 1, "(");
        func2(n, n, "");
        return list;

        void func(int t, int o, string buffer)
        {
            if (t==n && o==0)
            {
                list.Add(buffer);
                return;
            }
            if (t < n && o < n)
            {
                func(t + 1, o + 1, buffer + "(");
            }
            if (o >= 1)
            {
                func(t, o - 1, buffer + ")");
            }
        }

        void func2(int opened, int closed, string buffer)
        {
            if (opened == 0 && closed == 0)
            {
                list.Add(buffer);
                return;
            }
            if (opened>0)
            {
                func2(opened-1, closed, buffer + "(");
            }
            if (opened < closed)
            {
                func2(opened, closed-1, buffer + ")");
            }
        }
    }
}

public class GenerateParenthesisBruteforceSolver
{
    public IList<string> GenerateParenthesis(int n)
    {
        if (n == 1) return new string[] { "()" };

        HashSet<string> result = new HashSet<string>();
        var previous = GenerateParenthesis(n - 1);
        foreach (var p in previous)
        {
            AddRange(AddParenthesisBeforeAndAfterParenthesis(p));
        }
        return result.ToList();

        void AddRange(IEnumerable<string> values)
        {
            foreach (var v in values)
            {
                if (!result.Contains(v))
                {
                    result.Add(v);
                }
            }
        }

        IEnumerable<string> AddParenthesisBeforeAndAfterParenthesis(string input)
        {
            //h - here
            //h(  // (h  // h) // )h
            //if (input[i]=='(' || input[i] == ')')
            for (int i = 0; i < input.Length; i++)
            {
                yield return input.Insert(i, "()");
            }
            yield return input.Insert(input.Length, "()");
        }
    }
}
