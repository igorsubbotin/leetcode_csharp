// 349. Intersection of Two Arrays - https://leetcode.com/problems/intersection-of-two-arrays
public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        var result = new HashSet<int>();
        Array.Sort(nums1);
        Array.Sort(nums2);
        var i = 0;
        var j = 0;
        while (i < nums1.Length && j < nums2.Length) {
            if (nums1[i] == nums2[j]) {
                if (!result.Contains(nums1[i])) result.Add(nums1[i]);
                i++;
                j++;
            } else if (nums1[i] < nums2[j]) i++;
            else j++;
        }
        return result.ToList().ToArray();
    }
}