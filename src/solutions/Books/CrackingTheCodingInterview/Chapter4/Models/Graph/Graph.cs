namespace solutions.Books.CrackingTheCodingInterview.Chapter4.Models.Graph;

public class Graph
{
    private Dictionary<string, GraphVertex> _vertexesMap;

    public Graph(Dictionary<string, GraphVertex> vertexesMap)
    {
        this._vertexesMap = vertexesMap;
    }

    public GraphVertex? Find(string vertexName) => _vertexesMap.TryGetValue(vertexName, out var vertex) ? vertex : null;
}

public class GraphVertex
{
    private List<GraphVertex> _children = new();

    public GraphVertex(string name)
    {
        Name = name;
    }

    public string Name { get; }

    //or hashtable
    public bool TraversalMark {get; set;}

    public IEnumerable<GraphVertex> Children => _children;

    internal void AddChildren(IEnumerable<GraphVertex> children)
    {
        _children.AddRange(children);
    }
}

public static class GraphHelper
{
    public static Graph ToDirectedGraph(this string[][] adjacencyList)
    {
        Dictionary<string, GraphVertex> vertexesMap = new ();
        foreach (var vertexConnection in adjacencyList)
        {
            var currentVertexName = vertexConnection[0];
            var connections = vertexConnection.Skip(1)
                                              .Select(childVertexName=>GetOrMakeGraphVertex(childVertexName, vertexesMap));

            var currentVertex = GetOrMakeGraphVertex(currentVertexName, vertexesMap);
            currentVertex.AddChildren(connections);
        }

        return new Graph(vertexesMap);

        //local functions
        GraphVertex GetOrMakeGraphVertex(string vertexName,  Dictionary<string, GraphVertex> vertexes)
        {
            if (vertexes.ContainsKey(vertexName))
            {
                return vertexes[vertexName];
            }

            var vertex = new GraphVertex(vertexName);
            vertexes.Add(vertexName, vertex);
            return vertex;
        }
    }
}