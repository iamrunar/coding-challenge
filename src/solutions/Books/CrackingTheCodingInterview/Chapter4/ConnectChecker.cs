namespace solutions.Books.CrackingTheCodingInterview.Chapter4.Task4_1;
using solutions.Books.CrackingTheCodingInterview.Chapter4.Models.Graph;

public class ConnectChecker
{
    public bool IsConnected(GraphVertex from, GraphVertex to)
    {
        Queue<GraphVertex> queue = new ();
        queue.Enqueue(from);
        while (queue.Count>0)
        {
            var currentVertex = queue.Dequeue();
            currentVertex.TraversalMark = true;
            foreach (var child in currentVertex.Children)
            {
                if (child.TraversalMark)
                {
                    continue;
                }

                if (child == to) return true;

                queue.Enqueue(child);
            }
        }
        return false;
    }
}