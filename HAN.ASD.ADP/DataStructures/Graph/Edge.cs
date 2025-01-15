namespace HAN.ASD.ADP.DataStructures.Graph
{
    public class Edge
    {
        public Vertex Destination { get; set; }
        public int Cost { get; set; }

        public Edge(Vertex destination, int cost)
        {
            Destination = destination;
            Cost = cost;
        }
    }
}
