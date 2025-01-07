namespace HAN.ASD.ADP.DataStructures.Graph
{
    public class Vertex
    {
        public string Name { get; set; };
        public LinkedList<Edge> Edges { get; set; }

        public int Distance { get; set; }
        public Vertex Previous { get; set; }
        public bool Done { get; set; }

        public Vertex(string name)
        {
            Name = name;
            Edges = new LinkedList<Edge>();

            Previous = null;
            Distance = int.MaxValue;
            Done = false;
        }

        public void Reset()
        {
            Previous = null;
            Distance = int.MaxValue;
            Done = false;
        }
    }
}
