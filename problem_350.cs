// 350. Intersection of Two Arrays II - https://leetcode.com/problems/intersection-of-two-arrays-ii
public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        Array.Sort(nums1);
        Array.Sort(nums2);
        var result = new List<int>();
        var i = 0;
        var j = 0;
        while (i < nums1.Length && j < nums2.Length) {
            if (nums1[i] == nums2[j]) {
                result.Add(nums1[i]);
                i++;
                j++;
            } else if (nums1[i] < nums2[j]) i++;
            else j++;
        }
        return result.ToArray();
    }
}