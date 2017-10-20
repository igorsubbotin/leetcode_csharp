// 179. Largest Number - https://leetcode.com/problems/largest-number
public class Solution {
    public string LargestNumber(int[] nums) {
        var str = nums.Select(x => x.ToString()).OrderByDescending(x => x).ToList();
        var n = 0;
        foreach (var each in str) n += each.Length;
        var items = new List<Item>();
        for (var i = 0; i < n; i++) {
            items.Add(new Item(string.Empty, new HashSet<int>()));
        }
        for (var i = 0; i < str.Count; i++) {
            if (string.Compare(items[str[i].Length - 1].val, str[i], false) < 0) {
                var hs = new HashSet<int>();
                hs.Add(i);
                items[str[i].Length - 1] = new Item(str[i], hs);
            }
        }
        for (var i = 0; i < n - 1; i++) {
            var item = items[i];
            if (string.IsNullOrEmpty(item.val)) continue;
            for (var j = 0; j < str.Count; j++) {
                if (item.skip.Contains(j)) continue;
                var ix = i + str[j].Length;
                var s = item.val + str[j];
                if (string.Compare(items[ix].val, s, false) < 0) {
                    var hs = item.skip.Copy();
                    hs.Add(j);
                    items[ix] = new Item(s, hs);
                }
            }
        }
        return Clean(items.Last().val);
    }
    
    private static string Clean(string s) {
        if (s[0] == '0') return "0";
        return s;
    }
}

public static class Extensions {
    public static IList<string> Copy(this IList<string> source, int ix) {
        var result = new List<string>();
        for (var i = 0; i < source.Count; i++)
            if (ix != i) result.Add(source[i]);
        return result;
    }
    
    public static HashSet<int> Copy(this HashSet<int> source) {
        var result = new HashSet<int>();
        foreach (var each in source) result.Add(each);
        return result;
    }
}

public class Item {
    public string val;
    public HashSet<int> skip;
    public Item(string val, HashSet<int> skip) {
        this.val = val;
        this.skip = skip;
    }
}