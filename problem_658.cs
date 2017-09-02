// 658. Find K Closest Elements - https://leetcode.com/problems/find-k-closest-elements
public class Solution {
    public IList<int> FindClosestElements(IList<int> arr, int k, int x) {
        var index = FindIndex(arr, x, 0, arr.Count - 1);
        var left = index - 1;
        var right = index;
        while (k > 0) {
            if (left == -1) {
                right++;
            } else if (right == arr.Count) {
                left--;
            }
            else {
                var leftDiff = Math.Abs(x - arr[left]);
                var rightDiff = Math.Abs(x - arr[right]);
                if (leftDiff <= rightDiff) {
                    left--;
                } else {
                    right++;
                }
            }
            k--;
        }
        left++;
        right--;
        return arr.Skip(left).Take(right - left + 1).ToList();
    }
    
    private static int FindIndex(IList<int> arr, int target, int left, int right) {
        var length = right - left + 1;
        if (length < 3) {
            if (target <= arr[left]) return left;
            return right;
        }
        var median = left + length / 2;
        if (target < arr[median]) return FindIndex(arr, target, left, median - 1);
        else if (target > arr[median]) return FindIndex(arr, target, median + 1, right);
        return median;
    }
}