/*
 * @lc app=leetcode.cn id=309 lang=csharp
 *
 * [309] 最佳买卖股票时机含冷冻期
 */

// @lc code=start
public class Solution {
    public int MaxProfit(int[] prices) {
        if(prices==null || prices.Length==0)
            return 0;
        
        int len=prices.Length;
        int dp_i_0=0, dp_i_1=int.MinValue;
        int dp_pre_0=0; //代表dp[i-2,0];

        for(int i=0; i<len; i++){
            int temp=dp_i_0;
            dp_i_0=Math.Max(dp_i_0,dp_i_1+prices[i]);
            dp_i_1=Math.Max(dp_i_1, dp_pre_0-prices[i]);
            dp_pre_0=temp;
        }
        return dp_i_0;
    }
}
// @lc code=end

