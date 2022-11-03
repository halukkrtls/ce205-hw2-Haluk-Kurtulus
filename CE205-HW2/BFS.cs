using Microsoft.Msagl.Drawing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CE205_HW3
{
    internal class BFS
    {
        LinkedList<int>[] adjacencyList;

        public BFS(int vertexSize) 
        {
            adjacencyList = new LinkedList<int>[vertexSize];
            for (int i = 0; i < vertexSize; i++)
            {
                adjacencyList[i] = new LinkedList<int>();
            }
        }

        public void AddEdge(int vertexSize, int w) // Function to add an edge into the graph
        {
            adjacencyList[vertexSize].AddLast(w);
        }

        /**
    *
    *	  @name Breadth First Search Util(BFSUtil)
    *
    *	  @brief Prints BFS traversal from a given source s
    *
    *	  It is a graph traversal algorithm that starts traversing the graph from the root node and
    *	  searches for all neighboring weddings.
    *
    *	  @param  [in] v [\b int] accessible vertices.
    *	  
    *	  @param  [in] visited [\b []] visited.
    *	  
    *	  @param  [in] graphArray [\b [,]] Graph Array.
    *     
    *     @retval [\b ]
    *     
      **/
        public void BFSUtil(int v, int[] visited, int[,] graphArray, ref Microsoft.Msagl.Drawing.Graph graphObject)
        {
            int vertexSize = graphArray.GetLength(0);
            LinkedList<int> queue = new LinkedList<int>();
            queue.AddLast(v);
            visited[v] = 1;
            while (queue.Count != 0)
            {
                int u = queue.First.Value;
                queue.RemoveFirst();
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
                        queue.AddLast(i);
                        visited[i] = 1;
                    }
                }
            }
        }

        /**
    *
    *	  @name Print Breadth First Search(printBFS)
    *
    *	  @brief BFS draws as graph
    *
    *	  It is a graph traversal algorithm that starts traversing the graph from the root node and
    *	  searches for all neighboring weddings.
    *	  
    *	  @param  [in] clearEdges [\b bool] Clear edges.
    *	  
    *	  @param  [in] graphArray [\b [,]] Graph Array.
    *     
    *     @retval [\b ]
    *     
    **/

        public void printBFS(int[,] graphArray, bool clearEdges, ref Microsoft.Msagl.Drawing.Graph graphObject)
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
                    BFSUtil(i, visited, graphArray, ref graphObject);
                }
            }
            
        }
    }
}