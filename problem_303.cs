// 303. Range Sum Query - Immutable - https://leetcode.com/problems/range-sum-query-immutable
public class NumArray {
    private readonly int[] nums;
    
    public NumArray(int[] nums) {
        for (var i = 1; i < nums.Length; i++) nums[i] += nums[i - 1];
        this.nums = nums;
    }
    
    public int SumRange(int i, int j) {
        var sum = nums[j];
        if (i > 0) sum -= nums[i - 1];
        return sum;
    }
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * int param_1 = obj.SumRange(i,j);
 */