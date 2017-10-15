// 692. Top K Frequent Words - https://leetcode.com/problems/top-k-frequent-words
public class Solution {
    public IList<string> TopKFrequent(string[] words, int k) {
        var d = new Dictionary<string, int>();
        foreach (var word in words) {
            if (!d.ContainsKey(word)) d[word] = 0;
            d[word]++;
        } 
        return d.OrderByDescending(x => x.Value).ThenBy(x => x.Key).Select(x => x.Key).Take(k).ToList();
    }
}