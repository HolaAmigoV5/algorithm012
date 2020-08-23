/*
 * @lc app=leetcode.cn id=518 lang=csharp
 *
 * [518] 零钱兑换 II
 */

// @lc code=start
public class Solution {
    public int Change(int amount, int[] coins) {
        //dynamic programming. O(mn), O(m)
        int[] dp=new int[amount+1];
        dp[0]=1;
        foreach(var coin in coins){
            for(int i=1; i<=amount; i++){
                if(i<coin)
                    continue;
                dp[i]+=dp[i-coin];
            }
        }
        return dp[amount];
    }
}
// @lc code=end

