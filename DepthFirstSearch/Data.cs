namespace DepthFirstSearch
{
    internal class Data
    {
        // G--A--D
        // |  |  |
        // E--B--F--C--H
        public static Node Fill()
        {
            var a = new Node("A");
            var b = new Node("B");
            var c = new Node("C");
            var d = new Node("D");
            var e = new Node("E");
            var f = new Node("F");
            var g = new Node("G");
            var h = new Node("H");

            a.AddNode(b); a.AddNode(d);
            b.AddNode(a); b.AddNode(e); b.AddNode(f);
            c.AddNode(f); c.AddNode(h);
            d.AddNode(a); d.AddNode(f);
            e.AddNode(b); e.AddNode(g);
            f.AddNode(b); f.AddNode(c); f.AddNode(d);
            g.AddNode(a); g.AddNode(e);
            h.AddNode(c);

            return a;
        }
    }
}