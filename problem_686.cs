// 686. Repeated String Match - https://leetcode.com/problems/repeated-string-match
public class Solution {
    public int RepeatedStringMatch(string A, string B) {
        var sb = new StringBuilder();
        var i = 0;
        do {
            i += 1;
            sb.Append(A);
            if (sb.Length < B.Length) continue;
            if (sb.ToString().Contains(B)) return i;
        } while (i < 2 || sb.Length <= B.Length);
        return -1;
    }
}