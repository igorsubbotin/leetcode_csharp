// 675. Cut Off Trees for Golf Event - https://leetcode.com/problems/cut-off-trees-for-golf-event
public class Solution {
    public int CutOffTree(IList<IList<int>> forest) {
        var x = forest.Count;
        var y = forest[0].Count;
        var graph = new Node[x,y];
        var plan = new List<Node>();
        for (var i = 0; i < x; i++) {
            for (var j = 0; j < y; j++) {
                var point = new Point(i, j);
                var height = forest[i][j];
                var node = new Node(point, height);
                if (height > 1) plan.Add(node);
                graph[i, j] = node;
            }
        }
        plan = plan.OrderBy(p => p.height).ToList();
        for (var i = 0; i < x; i++) {
            for (var j = 0; j < y; j++) {
                var point = new Point(i, j);
                var node = graph[point.x, point.y];
                AddEdge(x, y, i + 1, j, node, graph);
                AddEdge(x, y, i - 1, j, node, graph);
                AddEdge(x, y, i, j + 1, node, graph);
                AddEdge(x, y, i, j - 1, node, graph);
            }
        }
        var result = 0;
        var current = new Point(0, 0);
        foreach (var item in plan) {
            var path = FindPath(x, y, current, item.pos, graph);
            if (path == -1) return -1;
            result += path;
            current = item.pos;
        }
        return result;
    }
    
    private static int FindPath(int x, int y, Point start, Point end, Node[,] graph) {
        var q = new Queue<PathItem>();
        q.Enqueue(new PathItem(graph[start.x, start.y], 0));
        var v = new bool[x, y];
        while (q.Count > 0) {
            var item = q.Dequeue();
            if (v[item.node.pos.x, item.node.pos.y]) continue;
            v[item.node.pos.x, item.node.pos.y] = true;
            if (item.node.pos.x == end.x && item.node.pos.y == end.y) return item.path;
            foreach (var sibling in item.node.edges) {
                if (sibling.height != 0) q.Enqueue(new PathItem(sibling, item.path + 1));
            }
        }
        return -1;
    }
    
    private static void AddEdge(int x, int y, int i, int j, Node node, Node[,] graph) {
        if (i < 0 || j < 0 || i == x || j == y) return;
        var point = new Point(i, j);
        var sibling_node = graph[point.x, point.y];
        if (sibling_node.height == 0) return;
        node.edges.Add(sibling_node);
    }
}

public struct Point {
    public readonly int x;
    public readonly int y; 
    public Point(int x, int y) {
        this.x = x;
        this.y = y;
    }
}

public class Node {
    public readonly Point pos;
    public readonly IList<Node> edges = new List<Node>();
    public readonly int height;
    public Node(Point pos, int height) {
        this.pos = pos;
        this.height = height;
    }
}

public class PathItem {
    public readonly Node node;
    public readonly int path;
    public PathItem(Node node, int path) {
        this.node = node;
        this.path = path;
    }
}