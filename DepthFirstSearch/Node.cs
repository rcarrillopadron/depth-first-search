using System.Collections.Generic;

namespace DepthFirstSearch
{
    class Node
    {
        private readonly List<Node> _children;
        public Node(string name)
        {
            Name = name;
            _children = new List<Node>();
        }
        public string Name { get; set; }
        public bool IsVisited { get; set; }

        public IEnumerable<Node> Children
        {
            get { return _children; }
        }

        public void AddNode(Node node)
        {
            _children.Add(node);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}