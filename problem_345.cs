// 345. Reverse Vowels of a String - https://leetcode.com/problems/reverse-vowels-of-a-string
public class Solution {
    public string ReverseVowels(string s) {
        var sb = new StringBuilder(s);
        var vowels = new List<int>();
        for (var i = 0; i < sb.Length; i++) 
            if (IsVowel(sb[i])) vowels.Add(i);
        for (var i = 0; i < vowels.Count / 2; i++) {
            var tmp = sb[vowels[i]];
            sb[vowels[i]] = sb[vowels[vowels.Count - i - 1]];
            sb[vowels[vowels.Count - i - 1]] = tmp;
        }
        return sb.ToString();
    }
    
    private static bool IsVowel(char c) {
        return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' || c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U';
    }
}