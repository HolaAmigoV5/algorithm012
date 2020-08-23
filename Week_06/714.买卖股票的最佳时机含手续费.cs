/*
 * @lc app=leetcode.cn id=714 lang=csharp
 *
 * [714] 买卖股票的最佳时机含手续费
 */

// @lc code=start
public class Solution {
    public int MaxProfit(int[] prices, int fee) {
        if(prices==null || prices.Length==0)
            return 0;
        
        int len=prices.Length;
        int dp_i_0=0, dp_i_1=int.MinValue;
        for(int i=0; i<len; i++){
            int temp=dp_i_0;
            dp_i_0=Math.Max(dp_i_0, dp_i_1+prices[i]);
            dp_i_1=Math.Max(dp_i_1, temp-prices[i]-fee);
        }
        return dp_i_0;
    }
}
// @lc code=end

