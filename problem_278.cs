// 278. First Bad Version - https://leetcode.com/problems/first-bad-version
/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class Solution : VersionControl {
    public int FirstBadVersion(int n) {
        return FindIndex(1, n);
    }
    
    private int FindIndex(int left, int right) {
        var length = right - left + 1;
        var median = left + length / 2;
        if (length < 3) {
            if (IsBadVersion(left)) {
                if (left == 1 || !IsBadVersion(left - 1)) return left;
            } else {
                if (IsBadVersion(right)) return right;
            }
            return -1;
        }
        if (IsBadVersion(median)) return FindIndex(left, median);    
        return FindIndex(median, right);
    }
}