using HAN.ASD.ADP.Datasets;
using HAN.ASD.ADP.DataStructures.Graph;
using HAN.ASD.ADP.Helpers;

namespace HAN.ASD.ADP.Test.DataStructures
{
    [TestClass]
    public class GraphTest
    {
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
        public void LijnLijstTest()
        {
            var graph = new Graph();
            var lines = _dataSet.lijnlijst;
            foreach (var line in lines)
            {
                graph.AddEdge(line[0].ToString(), line[1].ToString(), 1);
            }

            graph.PrintGraph();
        }

        [TestMethod]
        public void VerbindingsLijstTest()
        {
            var graph = new Graph();
            var connections = _dataSet.verbindingslijst;
            for (int i = 0; i < connections.Length; i++)
            {
                var conn = connections[i];
                foreach (var c in conn)
                {
                    graph.AddEdge(i.ToString(), c.ToString(), 1);
                }
            }

            graph.PrintGraph();
        }

        [TestMethod]
        public void VerbindingsMatrixTest()
        {
            var graph = new Graph();
            var matrix = _dataSet.verbindingsmatrix;
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

            graph.PrintGraph();
        }

        [TestMethod]
        public void LijnLijstGewogenTest()
        {
            var graph = new Graph();
            var lines = _dataSet.lijnlijst_gewogen;
            foreach (var line in lines)
            {
                graph.AddEdge(line[0].ToString(), line[1].ToString(), line[2]);
            }

            graph.PrintGraph();
        }

        [TestMethod]
        public void VerbindingsLijstGewogenTest()
        {
            var graph = new Graph();
            var connections = _dataSet.verbindingslijst_gewogen;
            for (int i = 0; i < connections.Length; i++)
            {
                var conn = connections[i];
                foreach (var c in conn)
                {
                    graph.AddEdge(i.ToString(), c[0].ToString(), c[1]);
                }
            }

            graph.PrintGraph();
        }

        [TestMethod]
        public void VerbindingsMatrixGewogenTest()
        {
            var graph = new Graph();
            var matrix = _dataSet.verbindingsmatrix_gewogen;
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

            graph.PrintGraph();
        }
    }
}
