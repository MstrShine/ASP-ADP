using HAN.ASD.ADP.Datasets;
using HAN.ASD.ADP.DataStructures.Graph;
using HAN.ASD.ADP.Helpers;
using System.Diagnostics;

namespace HAN.ASD.ADP.Test.DataStructures
{
    [TestClass]
    public class GraphTest
    {
        private Stopwatch Watch = new Stopwatch();

        private GrafenDataset _dataSet;

        [TestInitialize]
        public void TestInit()
        {
            var data = JsonHelper.LoadJson<GrafenDataset>(".\\Datasets\\Raw\\grafen.json");
            if (data == null)
            {
                _dataSet = new GrafenDataset();
                return;
            }

            _dataSet = data;
        }

        [TestMethod]
        public void DataSet_LijnLijst()
        {
            var graph = new Graph();
            var lines = _dataSet.lijnlijst;
            Watch.Restart();
            foreach (var line in lines)
            {
                graph.AddEdge(line[0].ToString(), line[1].ToString(), 1);
            }
            Watch.Stop();

            Console.WriteLine("Insert {0}", Watch.ToString());
            graph.PrintGraph();
        }

        [TestMethod]
        public void LijnLijst_ShortestPath()
        {
            var graph = new Graph();
            var lines = _dataSet.lijnlijst;
            Watch.Restart();
            foreach (var line in lines)
            {
                graph.AddEdge(line[0].ToString(), line[1].ToString(), 1);
            }
            Watch.Stop();

            Console.WriteLine("Insert {0}", Watch.ToString());
            graph.PrintGraph();

            foreach (var vertex in graph.GetVertices())
            {
                Watch.Restart();
                var shortest = graph.UnweightedShortestPath(vertex.Name);
                Watch.Stop();

                Console.WriteLine($"Shortest path from {vertex.Name} took {Watch}");
            }
        }

        [TestMethod]
        public void DataSet_VerbindingsLijst()
        {
            var graph = new Graph();
            var connections = _dataSet.verbindingslijst;
            Watch.Restart();
            for (int i = 0; i < connections.Length; i++)
            {
                var conn = connections[i];
                foreach (var c in conn)
                {
                    graph.AddEdge(i.ToString(), c.ToString(), 1);
                }
            }
            Watch.Stop();

            Console.WriteLine("Insert {0}", Watch.ToString());
            graph.PrintGraph();
        }

        [TestMethod]
        public void VerbindingsLijst_ShortestPath()
        {
            var graph = new Graph();
            var connections = _dataSet.verbindingslijst;
            Watch.Restart();
            for (int i = 0; i < connections.Length; i++)
            {
                var conn = connections[i];
                foreach (var c in conn)
                {
                    graph.AddEdge(i.ToString(), c.ToString(), 1);
                }
            }
            Watch.Stop();

            Console.WriteLine("Insert {0}", Watch.ToString());
            graph.PrintGraph();

            foreach (var vertex in graph.GetVertices())
            {
                Watch.Restart();
                var shortest = graph.UnweightedShortestPath(vertex.Name);
                Watch.Stop();

                Console.WriteLine($"Shortest path from {vertex.Name} took {Watch}");
            }
        }

        [TestMethod]
        public void DataSet_VerbindingsMatrix()
        {
            var graph = new Graph();
            var matrix = _dataSet.verbindingsmatrix;
            Watch.Restart();
            for (int i = 0; i < matrix.Length; i++)
            {
                var to = matrix[i];
                for (int j = 0; j < to.Length; j++)
                {
                    if (to[j] != 0)
                    {
                        graph.AddEdge(i.ToString(), j.ToString(), 1);
                    }
                }
            }
            Watch.Stop();

            Console.WriteLine("Insert {0}", Watch.ToString());
            graph.PrintGraph();
        }

        [TestMethod]
        public void VerbindingsMatrixTest_ShortestPath()
        {
            var graph = new Graph();
            var matrix = _dataSet.verbindingsmatrix;
            Watch.Restart();
            for (int i = 0; i < matrix.Length; i++)
            {
                var to = matrix[i];
                for (int j = 0; j < to.Length; j++)
                {
                    if (to[j] != 0)
                    {
                        graph.AddEdge(i.ToString(), j.ToString(), 1);
                    }
                }
            }
            Watch.Stop();

            Console.WriteLine("Insert {0}", Watch.ToString());
            graph.PrintGraph();

            foreach (var vertex in graph.GetVertices())
            {
                Watch.Restart();
                var shortest = graph.UnweightedShortestPath(vertex.Name);
                Watch.Stop();

                Console.WriteLine($"Shortest path from {vertex.Name} took {Watch}");
            }
        }

        [TestMethod]
        public void DataSet_LijnLijstGewogen()
        {
            var graph = new Graph();
            var lines = _dataSet.lijnlijst_gewogen;
            Watch.Restart();
            foreach (var line in lines)
            {
                graph.AddEdge(line[0].ToString(), line[1].ToString(), line[2]);
            }
            Watch.Stop();

            Console.WriteLine("Insert {0}", Watch.ToString());
            graph.PrintGraph();
        }

        [TestMethod]
        public void LijnLijstGewogen_Dijkstra()
        {
            var graph = new Graph();
            var lines = _dataSet.lijnlijst_gewogen;
            Watch.Restart();
            foreach (var line in lines)
            {
                graph.AddEdge(line[0].ToString(), line[1].ToString(), line[2]);
            }
            Watch.Stop();

            Console.WriteLine("Insert {0}", Watch.ToString());
            graph.PrintGraph();

            foreach (var vertex in graph.GetVertices())
            {
                Watch.Restart();
                var shortest = graph.Dijkstra(vertex.Name);
                Watch.Stop();

                Console.WriteLine($"Shortest path from {vertex.Name} took {Watch}");
            }
        }

        [TestMethod]
        public void DataSet_VerbindingsLijstGewogen()
        {
            var graph = new Graph();
            var connections = _dataSet.verbindingslijst_gewogen;
            Watch.Restart();
            for (int i = 0; i < connections.Length; i++)
            {
                var conn = connections[i];
                foreach (var c in conn)
                {
                    graph.AddEdge(i.ToString(), c[0].ToString(), c[1]);
                }
            }
            Watch.Stop();

            Console.WriteLine("Insert {0}", Watch.ToString());
            graph.PrintGraph();
        }

        [TestMethod]
        public void VerbindingsLijstGewogen_Dijkstra()
        {
            var graph = new Graph();
            var connections = _dataSet.verbindingslijst_gewogen;
            Watch.Restart();
            for (int i = 0; i < connections.Length; i++)
            {
                var conn = connections[i];
                foreach (var c in conn)
                {
                    graph.AddEdge(i.ToString(), c[0].ToString(), c[1]);
                }
            }
            Watch.Stop();

            Console.WriteLine("Insert {0}", Watch.ToString());
            graph.PrintGraph();

            foreach (var vertex in graph.GetVertices())
            {
                Watch.Restart();
                var shortest = graph.Dijkstra(vertex.Name);
                Watch.Stop();

                Console.WriteLine($"Shortest path from {vertex.Name} took {Watch}");
            }
        }

        [TestMethod]
        public void DataSet_VerbindingsMatrixGewogen()
        {
            var graph = new Graph();
            var matrix = _dataSet.verbindingsmatrix_gewogen;
            Watch.Restart();
            for (int i = 0; i < matrix.Length; i++)
            {
                var to = matrix[i];
                for (int j = 0; j < to.Length; j++)
                {
                    if (to[j] != 0)
                    {
                        graph.AddEdge(i.ToString(), j.ToString(), to[j]);
                    }
                }
            }
            Watch.Stop();

            Console.WriteLine("Insert {0}", Watch.ToString());
            graph.PrintGraph();
        }

        [TestMethod]
        public void VerbindingsMatrixGewogen_Dijkstra()
        {
            var graph = new Graph();
            var matrix = _dataSet.verbindingsmatrix_gewogen;
            Watch.Restart();
            for (int i = 0; i < matrix.Length; i++)
            {
                var to = matrix[i];
                for (int j = 0; j < to.Length; j++)
                {
                    if (to[j] != 0)
                    {
                        graph.AddEdge(i.ToString(), j.ToString(), to[j]);
                    }
                }
            }
            Watch.Stop();

            Console.WriteLine("Insert {0}", Watch.ToString());
            graph.PrintGraph();

            foreach (var vertex in graph.GetVertices())
            {
                Watch.Restart();
                var shortest = graph.Dijkstra(vertex.Name);
                Watch.Stop();

                Console.WriteLine($"Shortest path from {vertex.Name} took {Watch}");
            }
        }
    }
}
