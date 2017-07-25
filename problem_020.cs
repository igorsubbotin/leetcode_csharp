// 20. Valid Parentheses - https://leetcode.com/problems/valid-parentheses
public class Solution {
    public bool IsValid(string s) {
        var st = new Stack<int>();
        foreach (var c in s) {
            if (c == '{') st.Push(0);
            else if (c == '[') st.Push(1);
            else if (c == '(') st.Push(2);
            else {
                if (st.Count == 0) return false;
                var value = st.Pop();
                if (c == '}' && value != 0) return false;
                if (c == ']' && value != 1) return false;
                if (c == ')' && value != 2) return false;
            }
        }
        return st.Count == 0;
    }
}