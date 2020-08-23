/*
 * @lc app=leetcode.cn id=123 lang=csharp
 *
 * [123] 买卖股票的最佳时机 III
 */

// @lc code=start
public class Solution {
    public int MaxProfit(int[] prices) {
        if(prices==null || prices.Length==0)
            return 0;

        int len=prices.Length;

        int dp_i10=0, dp_i11=int.MinValue;
        int dp_i20=0, dp_i21=int.MinValue;
        foreach(var price in prices){
            dp_i20=Math.Max(dp_i20, dp_i21+price);
            dp_i21=Math.Max(dp_i21, dp_i10-price);
            dp_i10=Math.Max(dp_i10, dp_i11+price);
            dp_i11=Math.Max(dp_i11, -price);
        }
        return dp_i20;
    }
}
// @lc code=end

