// 646. Maximum Length of Pair Chain - https://leetcode.com/problems/maximum-length-of-pair-chain
public class Solution {
    public int FindLongestChain(int[,] pairs) {
        var list = new List<int[]>();
        for (var i = 0; i < pairs.GetLength(0); i++) list.Add(new [] { pairs[i, 0], pairs[i, 1] });
        list = list.OrderBy(x => x[0]).ToList();
        var min = int.MaxValue;
        var ix = 0;
        for (var i = 0; i < list.Count; i++) {
            if (list[i][0] < min) {
                min = list[i][0];
                ix = i;
            }
        }
        var result = 1;
        var current = list[ix];
        for (var j = ix + 1; j < list.Count; j++) {
            if (current[1] < list[j][0]) {
                result++;
                current = list[j];
            }
            else if (current[1] > list[j][1]) current = list[j];
        }
        return result;
    }
}