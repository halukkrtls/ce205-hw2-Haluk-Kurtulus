using Microsoft.Msagl.Drawing;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CE205_HW3
{
    internal class TopologicalOrder
    {
        private LinkedList<int>[] adj;
        
        public TopologicalOrder(int vertexSize)
        {
            adj = new LinkedList<int>[vertexSize];
            for (int i = 0; i < vertexSize; i++)
            {
                adj[i] = new LinkedList<int>();
            }
        }
        public void AddEdge(int vertexSize, int w)
        {
            adj[vertexSize].AddLast(w);
        }
        
        public void TopologicalSortUtil(int v, int[] visited, int[,] graphArray, ref Microsoft.Msagl.Drawing.Graph graphObject)
        {
            int vertexSize = graphArray.GetLength(0);
            visited[v] = 1;
            foreach (int vertex in adj[v])
            {
                if (visited[vertex] == 0)
                {
                    TopologicalSortUtil(vertex, visited, graphArray, ref graphObject);
                }
            }
            for (int i = 1; i < vertexSize; i++)
            {
                string fromNode = Util.GetNodeLetter(v);
                string toNode = Util.GetNodeLetter(i);
                string weight = graphArray[i, v].ToString();

                Node node = graphObject.FindNode(fromNode);
                if (node != null)
                {
                    node.RemoveOutEdge(new Microsoft.Msagl.Drawing.Edge(fromNode, weight, toNode));
                }

                Edge edge = graphObject.AddEdge(fromNode, weight, toNode);

                edge.Attr.Color = Microsoft.Msagl.Drawing.Color.Green;
                edge.Attr.LineWidth = 5;

                //Console.WriteLine(parent[i] + " - " + i + "\t" + graph[i, parent[i]]);
            }
                graphObject.AddNode(Util.GetNodeLetter(v));
        }
        public void TopologicalSort(int[,] graphArray, bool clearEdges, ref Microsoft.Msagl.Drawing.Graph graphObject)
        {
            if (clearEdges)
            {
                graphObject = new Microsoft.Msagl.Drawing.Graph("graph");
            }
            int vertexSize = graphArray.GetLength(0);
            int[] visited = new int[vertexSize];
            for (int i = 0; i < vertexSize; i++)
            {
                if (visited[i] == 0)
                {
                    TopologicalSortUtil(i, visited, graphArray, ref graphObject);
                }
            }
        }
    }
}
