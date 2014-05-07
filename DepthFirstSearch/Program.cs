using System;
using System.Collections.Generic;
using System.Linq;

namespace DepthFirstSearch
{
    class Program
    {
        static void Main()
        {
            Node root = Data.Fill();
            Traverse(root);
            Console.WriteLine();
        }

        // G--A--D
        // |  |  |
        // E--B--F--C--H
        //
        // BFS: A B D G E F C H
        // ExpectedDFS: A B E G F C H D
        // ActualDFS:   A B E G F C H D
        private static void Traverse(Node rootNode)
        {
            var stack = new Stack<Node>();
            stack.Push(rootNode);
            rootNode.IsVisited = true;
            ProcessNode(rootNode);

            while (stack.Count != 0)
            {
                Node n = stack.Peek();
                Node child = n.Children.FirstOrDefault(x => !x.IsVisited);
                if (child == null)
                {
                    stack.Pop();
                }
                else
                {
                    child.IsVisited = true;
                    ProcessNode(child);
                    stack.Push(child);
                }
            }
        }

        private static void ProcessNode(Node node)
        {
            Console.Write(node.Name + " ");
        }
    }
}
