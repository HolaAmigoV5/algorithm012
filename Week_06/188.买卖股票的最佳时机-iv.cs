/*
 * @lc app=leetcode.cn id=188 lang=csharp
 *
 * [188] 买卖股票的最佳时机 IV
 */

// @lc code=start
public class Solution {
    public int MaxProfit(int k, int[] prices) {
        if(prices==null || prices.Length==0)
            return 0;
        
        int len=prices.Length;
        if(k>=len/2)
            return MaxProfit_k_inf(prices);
        
        int[,,] dp=new int[len, k+1,2];

        for(int i=0; i<len; i++){
            for(int j=k; j>=1; j--){
                if(i==0){
                    //base case
                    dp[0,j,0]=0; 
                    dp[0,j,1]=-prices[0];
                    continue;
                }
                dp[i,j,0]=Math.Max(dp[i-1,j,0], dp[i-1,j,1]+prices[i]);
                dp[i,j,1]=Math.Max(dp[i-1,j,1], dp[i-1,j-1,0]-prices[i]);
            }
        }
        return dp[len-1,k,0];
    }

    public int MaxProfit_k_inf(int[] prices) {
        if(prices==null || prices.Length==0)
            return 0;
        
        int len=prices.Length;
        int dp_i_0=0, dp_i_1=int.MinValue;
        for(int i=0; i<len;i++){
            int temp=dp_i_0;
            dp_i_0=Math.Max(dp_i_0, dp_i_1+prices[i]);
            dp_i_1=Math.Max(dp_i_1, temp-prices[i]);
        }
        return dp_i_0;

        //greedy
        // int profit=0;
        // for(int i=1; i<prices.Length; i++)
        //     profit+=Math.Max(0,prices[i]-prices[i-1]);
        // return profit;
    }
}
// @lc code=end

