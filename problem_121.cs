// 121. Best Time to Buy and Sell Stock - https://leetcode.com/problems/best-time-to-buy-and-sell-stock
public class Solution {
    public int MaxProfit(int[] prices) {
        var min = int.MaxValue;
        var profit = 0;
        for (var i = 0; i < prices.Length; i++) {
            min = Math.Min(min, prices[i]);
            profit = Math.Max(profit, prices[i] - min);
        }
        return profit;
    }
}