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

        }

        public void AddEdge(Edge edge)
        {

        }

        public void UnweightedShortestPath(string startName)
        {
            if (_vertexMap.TryGetValue(startName, out Vertex start))
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
            if (_vertexMap.TryGetValue(startName, out Vertex start))
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

        private void Clear()
        {
            foreach (var vertex in _vertexMap.Values)
            {
                vertex.Reset();
            }
        }
    }
}
