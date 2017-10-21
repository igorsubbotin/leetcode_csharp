// 459. Repeated Substring Pattern - https://leetcode.com/problems/repeated-substring-pattern
public class Solution {
    public bool RepeatedSubstringPattern(string s) {
        if (s.Length < 2) return false;
        var step = 0;
        while (step <= s.Length / 2) {
            step += 1;
            if (s.Length % step != 0) continue;
            var steps = s.Length / step;
            var stop = false;
            var started = false;
            for (var i = 0; i < step; i++) {
                var prev = s[i];
                for (var j = 1; j < steps; j++) {
                    started = true;
                    var ix = j * step + i;
                    if (prev != s[ix]) {
                        stop = true;
                        break;
                    }
                    prev = s[ix];
                }
                if (stop) break;
            }
            if (started && !stop) return true;
        }
        return false;
    }
}