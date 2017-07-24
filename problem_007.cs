// 7. Reverse Integer - https://leetcode.com/problems/reverse-integer
// Solution not using long type
public class Solution {
    public int Reverse(int x) {
        var n = Reverse(NumberToArray(x));
        if (IsOverflown(n)) return 0;
        return ArrayToNumber(n);
    }
    private static int[] NumberToArray(int n) { // -24 => [4, 2, -1]; 13 => [3, 1, 1]
        if (n == 0) return new [] { 1 , 0 };
        if (n == int.MinValue) return new [] { 8, 4, 6, 3, 8, 4, 7, 4, 1, 2, -1 };
        var sign = n < 0 ? -1 : 1;
        n = Math.Abs(n);
        var list = new List<int>();
        while (n > 0) {
            list.Add(n % 10);
            n /= 10;
        }
        list.Add(sign);
        return list.ToArray();
    }
    private int ArrayToNumber(int[] n) {
        var list = n.ToList();
        var result = 0;
        for (var i = 0; i < n.Length - 1; i++) {
            result += n[i] * (int)Math.Pow(10, i);
        }
        return GetSign(n) * result;
    }
    private static int[] Reverse(int[] n) {
        var list = n.ToList().Take(n.Length - 1).ToList();
        list.Reverse();
        list.Add(GetSign(n));
        return list.ToArray();
    }
    public static bool IsOverflown(int[] n) {
        if (Compare(NumberToArray(int.MaxValue), n) == -1) return true;
        if (Compare(NumberToArray(int.MinValue), n) == 1) return true;
        return false;
    }
    private static int Compare(int[] a, int[] b) {
        if (GetSign(a) > GetSign(b)) return 1;
        if (GetSign(b) > GetSign(a)) return -1;
        if (a.Length > b.Length) return 1 * GetSign(a);
        if (b.Length > a.Length) return -1 * GetSign(b);
        var compare = 0;
        for (var i = a.Length - 2; i >= 0; i--) {
            if (a[i] > b[i]) {
                compare = 1;
                break;
            }
            if (b[i] > a[i]) {
                compare = -1;
                break;
            }
        }
        return compare * GetSign(a);
        
    }
    private static int GetSign(int[] n) {
        return n[n.Length - 1];
    }
    private static void ConsoleArray(int[] a) {
        Console.WriteLine(string.Join(",", a.Select(x => x.ToString())));
    }
}