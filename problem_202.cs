// 202. Happy Number - https://leetcode.com/problems/happy-number
public class Solution {
    public bool IsHappy(int n) {
        var v = new HashSet<int>();
        while (n != 1 && !v.Contains(n)) {
            v.Add(n);
            var str = n.ToString();
            n = 0;
            foreach (var c in str) {
                var x = int.Parse(c.ToString());
                n += x * x;
            }
        }
        return n == 1;
    }
}