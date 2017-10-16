// 451. Sort Characters By Frequency - https://leetcode.com/problems/sort-characters-by-frequency
public class Solution {
    public string FrequencySort(string s) {
        var hash = new char[256];
        foreach (var c in s) hash[c]++;
        var a = new KeyValuePair<char, int>[256];
        for (var i = 0; i < 256; i++) a[i] = new KeyValuePair<char, int>((char)i, hash[i]);
        var sb = new StringBuilder();
        foreach (var pair in a.OrderByDescending(x => x.Value))
            for (var j = 0; j < pair.Value; j++) sb.Append(pair.Key);
        return sb.ToString();
    }
}