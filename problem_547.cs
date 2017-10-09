// 547. Friend Circles - https://leetcode.com/problems/friend-circles
public class Node {
    public readonly int id;
    public readonly IList<int> connections = new List<int>();
    public bool visited;
    
    public Node(int id) {
        this.id = id;
    }
}

public class Solution {
    public int FindCircleNum(int[,] M) {
        var result = 0;
        var n = M.GetLength(0);
        if (n == 0) return 0;
        var nodes = new Node[n];
        for (var i = 0; i < n; i++) {
            nodes[i] = new Node(i);
        }
        for (var i = 0; i < n; i++) {
            for (var j = 0; j < n; j++) {
                if (M[i, j] == 1) nodes[i].connections.Add(j);
            }
        }
        for (var i = 0; i < n; i++) {
            if (nodes[i].visited) continue;
            result++;
            var q = new Queue<Node>();
            q.Enqueue(nodes[i]);
            while (q.Count > 0) {
                var node = q.Dequeue();
                if (node.visited) continue;
                node.visited = true;
                foreach (var ix in node.connections) q.Enqueue(nodes[ix]);
            }
        }
        return result;
    }
}