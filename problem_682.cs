// 682. Baseball Game - https://leetcode.com/problems/baseball-game
public class Solution {
    public int CalPoints(string[] ops) {
        var list = new List<int>();
        foreach (var op in ops) {
            if (op == "C")list.RemoveAt(list.Count - 1);
            else if (op == "D") list.Add(list[list.Count - 1] * 2);
            else if (op == "+")list.Add(list[list.Count - 1] + list[list.Count - 2]);
            else list.Add(int.Parse(op));
        }
        var result = 0;
        foreach (var n in list) result += n;
        return result;
    }
}