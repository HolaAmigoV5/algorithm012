/*
 * @lc app=leetcode.cn id=121 lang=csharp
 *
 * [121] 买卖股票的最佳时机
 */

// @lc code=start
public class Solution {
    public int MaxProfit(int[] prices) {
        if(prices==null || prices.Length==0)
            return 0;
        
        int len=prices.Length;
        // int[,] dp=new int[len+1,2];
        // //base base
        // dp[0,0]=0;
        // dp[0,1]=-prices[0];
        // for(int i=1; i<len; i++){
        //     dp[i,0]=Math.Max(dp[i-1,0], dp[i-1,1]+prices[i]);
        //     dp[i,1]=Math.Max(dp[i-1,1],-prices[i]);
        // }
        // return dp[len-1,0];

        //M2:states compression
        //base case
        int dp_i_0=0, dp_i_1=int.MinValue;

        for(int i=0; i<len; i++){
            dp_i_0=Math.Max(dp_i_0, dp_i_1+prices[i]);
            dp_i_1=Math.Max(dp_i_1, -prices[i]);
        }
        return dp_i_0;
    }
}
// @lc code=end

