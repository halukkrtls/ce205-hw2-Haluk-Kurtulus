using Microsoft.Msagl.Drawing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CE205_HW3
{
    internal class DFS
    {
        private List<int>[] adj;
        
        public DFS(int vertexSize)
        {
            adj = new List<int>[vertexSize];
            for (int i = 0; i < vertexSize; i++)
            {
                adj[i] = new List<int>();
            }
        }
        void AddEdge(int vertexSize, int w)
        {
            adj[vertexSize].Add(w);
        }
        void DFSUtil(int v, int[] visited, int[,] graphArray, ref Microsoft.Msagl.Drawing.Graph graphObject)
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

        public void printDFS(int[,] graphArray, bool clearEdges, ref Microsoft.Msagl.Drawing.Graph graphObject)
        {
            if (clearEdges)
            {
                graphObject = new Microsoft.Msagl.Drawing.Graph("graph");
            }
            int[] visited = new int[graphArray.GetLength(0)];
            for (int i = 0; i < graphArray.GetLength(0); i++)
            {
                if (visited[i] == 0)
                {
                    DFSUtil(i, visited, graphArray, ref graphObject);
                }
            }
        }
    }
}