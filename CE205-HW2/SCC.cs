// C# implementation of Kosaraju's algorithm to print all SCCs
using Microsoft.Msagl.Drawing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CE205_HW3
{
    public class SCC
    {
        private int Vertexsize;
        private List<int>[] adj;

        public SCC(int vertexsize)
        {
            Vertexsize = vertexsize;
            adj = new List<int>[vertexsize];
            for(int i = 0; i < vertexsize; ++i)
            {
                adj[i] = new List<int>();
            }
        }
        public void addEdge(int vertexsize, int w)
        {
            adj[vertexsize].Add(w);
        }
        public void DFSUtil(int v, int[] visited, int[,] graphArray, ref Microsoft.Msagl.Drawing.Graph graphObject)
        {
            int vertexSize = graphArray.GetLength(0);
            Stack<int> stack = new Stack<int>();
            stack.Push(v);
            visited[v] = 1;
            while (stack.Count != 0)
            {
                int u = stack.Peek();
                string fromNode = Util.GetNodeLetter(u);
                string toNode = "";
                string weight = "";
                for (int i = 0; i < vertexSize; i++)
                {
                    if (graphArray[i, u] != 0 && visited[i] == 0)
                    {
                        toNode = Util.GetNodeLetter(i);
                        weight = graphArray[i, u].ToString();
                        Node node = graphObject.FindNode(fromNode);
                        if (node != null)
                        {
                            node.RemoveOutEdge(new Microsoft.Msagl.Drawing.Edge(fromNode, weight, toNode));
                        }
                        Edge edge = graphObject.AddEdge(fromNode, weight, toNode);
                        edge.Attr.Color = Microsoft.Msagl.Drawing.Color.Green;
                        edge.Attr.LineWidth = 5;
                        stack.Push(i);
                        visited[i] = 1;
                    }
                }
                stack.Pop();
            }
        }
        public SCC getTranspose()
        {
            SCC g = new SCC(Vertexsize);
            for (int v = 0; v < Vertexsize; v++)
            {
                foreach (int i in adj[v])
                {
                    g.adj[i].Add(v);
                }
            }
            return g;
        }
        public void fillOrder(int v, int[] visited, Stack<int> stack)
        {
            visited[v] = 1;
            foreach (int i in adj[v])
            {
                if (visited[i] == 0)
                {
                    fillOrder(i, visited, stack);
                }
            }
            stack.Push(v);
        }
        public void printSCC(int[,] graphArray, bool clearEdges, ref Microsoft.Msagl.Drawing.Graph graphObject)
        {
            if (clearEdges)
            {
                graphObject = new Microsoft.Msagl.Drawing.Graph("graph");
            }

            Stack<int> stack = new Stack<int>();

            int[] visited = new int[graphArray.GetLength(0)];
            for (int i = 0; i < graphArray.GetLength(0); i++)
            {
                if (visited[i] == 0)
                {
                    fillOrder(i, visited, stack);
                }
            }

            SCC scc = getTranspose();

            for (int i = 0; i < graphArray.GetLength(0); i++)
            {
                visited[i] = 0;
            }

            while (stack.Count != 0)
            {
                int v = stack.Pop();
                if (visited[v] == 0)
                {
                    scc.DFSUtil(v, visited, graphArray, ref graphObject);
                }
            }
        }
    }
}
