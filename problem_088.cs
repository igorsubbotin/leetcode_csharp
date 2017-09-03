// 88. Merge Sorted Array - https://leetcode.com/problems/merge-sorted-array
public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        var list = new List<int>();
        var i = 0;
        var j = 0;
        while (i + j < m + n) {
            if (i == m || (i != m && j != n && nums2[j] < nums1[i])) {
                list.Add(nums2[j]);
                j++;
            } else {
                list.Add(nums1[i]);
                i++;
            }
        }
        for (var k = 0; k < list.Count; k++) {
            nums1[k] = list[k];
        }
    }
}