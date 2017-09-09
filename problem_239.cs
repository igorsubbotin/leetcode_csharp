// 239. Sliding Window Maximum - https://leetcode.com/problems/sliding-window-maximum
public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        var result = new List<int>();
        var window = new PriorityQueue();
        var i = 0;
        while (i < k - 1) window.Add(nums[i++]);
        while (i < nums.Length) {
            window.Add(nums[i++]);
            result.Add(window.Max);            
            window.Remove(nums[i - k]);
        }
        return result.ToArray();
    }
    
    private class PriorityQueue {
        private SortedList<int, int> list = new SortedList<int, int>();
        public int Max { get { return list.Keys[list.Count - 1]; } }
        public void Add(int value) {
            if (!list.ContainsKey(value)) list.Add(value, 0);
            list[value]++;
        }      
        public void Remove(int value) { if (--list[value] == 0) list.Remove(value); }
    }
}