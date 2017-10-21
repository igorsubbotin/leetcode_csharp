// 165. Compare Version Numbers - https://leetcode.com/problems/compare-version-numbers
public class Solution {
    public int CompareVersion(string version1, string version2) {
        var v1 = GetVersion(version1);
        var v2 = GetVersion(version2);
        var n = Math.Max(v1.Length, v2.Length);
        for (var i = 0; i < n; i++) {
            var v1_value = 0;
            if (i < v1.Length) v1_value = v1[i];
            var v2_value = 0;
            if (i < v2.Length) v2_value = v2[i];
            if (v1_value > v2_value) return 1;
            else if (v2_value > v1_value) return -1;
        }
        return 0;
    }
    
    private static int[] GetVersion(string version) {
        return version.Split(new [] { '.' }).Select(x => int.Parse(x)).ToArray();
    }
}