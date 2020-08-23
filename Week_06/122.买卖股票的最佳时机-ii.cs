/*
 * @lc app=leetcode.cn id=122 lang=csharp
 *
 * [122] 买卖股票的最佳时机 II
 */

// @lc code=start
public class Solution {
    public int MaxProfit(int[] prices) {
        if(prices==null || prices.Length==0)
            return 0;
        
        // int len=prices.Length;
        // int dp_i_0=0, dp_i_1=int.MinValue;
        // for(int i=0; i<len;i++){
        //     int temp=dp_i_0;
        //     dp_i_0=Math.Max(dp_i_0, dp_i_1+prices[i]);
        //     dp_i_1=Math.Max(dp_i_1, temp-prices[i]);
        // }
        // return dp_i_0;

        //greedy
        // int profit=0;
        // for(int i=1; i<prices.Length; i++)
        //     profit+=Math.Max(0,prices[i]-prices[i-1]);
        // return profit;

        int dp_i0=0, dp_i1=-prices[0];
        for(int i=0; i<m; i++){
            dp_i0=Math.Max(dp_i0, dp_i1+prices[i]);
            dp_i1=Math.Max(dp_i1, dp_i0-prices[i]);
        }
        return dp_i0;
    }
}
// @lc code=end

