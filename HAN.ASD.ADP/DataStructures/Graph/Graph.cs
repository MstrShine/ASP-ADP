namespace HAN.ASD.ADP.DataStructures.Graph
{
    public class Graph
    {
        private Dictionary<string, Vertex> _vertexMap;

        public Graph()
        {
            _vertexMap = new Dictionary<string, Vertex>();
        }

        public void AddVertex(Vertex vertex)
        {
            if (!_vertexMap.ContainsKey(vertex.Name))
            {
                _vertexMap[vertex.Name] = vertex;
            }
        }

        public void RemoveVertex(Vertex vertex)
        {
            if (_vertexMap.Remove(vertex.Name))
            {
                foreach (var v in _vertexMap.Values)
                {
                    v.Edges = new LinkedList<Edge>(v.Edges.Where(e => e.Destination != vertex));
                }
            }
        }

        public void AddEdge(string from, string to, int cost)
        {
            if (!_vertexMap.ContainsKey(from))
            {
                _vertexMap.Add(from, new Vertex(from));
            }

            if (!_vertexMap.ContainsKey(to))
            {
                _vertexMap.Add(to, new Vertex(to));
            }

            var edge = new Edge(_vertexMap[to], cost);
            _vertexMap[from].Edges.AddLast(edge);
        }

        public void RemoveEdge(string from, string to)
        {
            if (_vertexMap.TryGetValue(from, out var fromVertex) && _vertexMap.TryGetValue(to, out var toVertex))
            {
                fromVertex.Edges = new LinkedList<Edge>(fromVertex.Edges.Where(e => e.Destination != toVertex));
            }
        }

        public void UnweightedShortestPath(string startName)
        {
            if (!_vertexMap.TryGetValue(startName, out Vertex start))
            {
                throw new KeyNotFoundException(startName);
            }

            Clear();

            var queue = new Queue<Vertex>();
            queue.Enqueue(start);
            start.Distance = 0;

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();
                foreach (var edge in current.Edges)
                {
                    var dest = edge.Destination;
                    if (dest.Distance == int.MaxValue)
                    {
                        dest.Distance = current.Distance + 1;
                        dest.Previous = current;
                        queue.Enqueue(dest);
                    }
                }
            }
        }

        public void Dijkstra(string startName)
        {
            if (!_vertexMap.TryGetValue(startName, out Vertex start))
            {
                throw new KeyNotFoundException(startName);
            }

            Clear();
            var queue = new PriorityQueue<Path, int>();
            queue.Enqueue(new Path(start, 0), 0);
            start.Distance = 0;

            var nodesSeen = 0;
            while (queue.Count > 0 && nodesSeen < _vertexMap.Count)
            {
                var path = queue.Dequeue();
                var current = path.Destination;
                if (current.Done)
                {
                    continue;
                }

                current.Done = true;
                nodesSeen++;

                foreach (var edge in current.Edges)
                {
                    var dest = edge.Destination;
                    if (edge.Cost < 0)
                    {
                        throw new Exception("Graph has negative edges");
                    }

                    if (dest.Distance > current.Distance + edge.Cost)
                    {
                        dest.Distance = current.Distance + edge.Cost;
                        dest.Previous = current;
                        queue.Enqueue(new Path(dest, dest.Distance), dest.Distance);
                    }
                }
            }
        }

        public void PrintGraph()
        {
            foreach (var vertex in _vertexMap.Values)
            {
                Console.WriteLine($"Vertex {vertex.Name}:");
                foreach (var edge in vertex.Edges)
                {
                    Console.WriteLine($"  -> {edge.Destination.Name} (Cost: {edge.Cost})");
                }
            }
        }

        private void Clear()
        {
            foreach (var vertex in _vertexMap.Values)
            {
                vertex.Reset();
            }
        }
    }
}
