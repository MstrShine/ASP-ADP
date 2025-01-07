namespace HAN.ASD.ADP.DataStructures.Graph
{
    public class Path : IComparable<Path>
    {
        public Vertex Destination { get; set; }
        public int Cost { get; set; }

        public Path(Vertex destination, int cost)
        {
            Destination = destination;
            Cost = cost;
        }

        public int CompareTo(Path other)
        {
            var otherCost = other.Cost;

            return Cost.CompareTo(otherCost);
        }
    }
}
