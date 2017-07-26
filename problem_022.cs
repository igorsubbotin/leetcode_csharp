// 22. Generate Parentheses - https://leetcode.com/problems/generate-parentheses
public class Solution {
    public IList<string> GenerateParenthesis(int n) {
        var q = new Queue<Parentheses>();
        var result = new List<string>();
        q.Enqueue(Parentheses.Empty(n));
        while (q.Count > 0) {
            var p = q.Dequeue();
            if (p.Completed()) {
                result.Add(p.result);
                continue;
            }
            if (p.CanOpen()) q.Enqueue(p.Open());
            if (p.CanClose()) q.Enqueue(p.Close());
        }
        return result;
    }
}

public class Parentheses {
    private readonly int n;
    private readonly int opened;
    private readonly int closed;
    public readonly string result;
    
    public static Parentheses Empty(int n) {
        return new Parentheses(n, string.Empty, 0, 0);
    }
    
    private Parentheses(int n, string result, int opened, int closed) {
        this.n = n;
        this.result = result;
        this.opened = opened;
        this.closed = closed;
    }
    
    public bool Completed() {
        return (opened + closed) == n * 2;
    }
    public bool CanOpen() {
        return opened < n;
    }
    public bool CanClose() {
        return closed < n && closed + 1 <= opened;
    }
    public Parentheses Open() {
        return new Parentheses(n, result + "(", opened + 1, closed);
    }
    public Parentheses Close() {
        return new Parentheses(n, result + ")", opened, closed + 1);
    }
}