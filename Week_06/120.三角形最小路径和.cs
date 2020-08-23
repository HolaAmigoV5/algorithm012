/*
 * @lc app=leetcode.cn id=120 lang=csharp
 *
 * [120] 三角形最小路径和
 */

// @lc code=start
public class Solution {
    public int MinimumTotal(IList<IList<int>> triangle) {
        int n=triangle.Count();
        int[] dp=new int[n+1];
        for(int i=n-1; i>=0; i--){
            for(int j=0; j<=i; j++){
                dp[j]=Math.Min(dp[j], dp[j+1])+triangle[i][j];
            }
        }
        return dp[0];
    }
}
// @lc code=end

