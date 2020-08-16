/*
 * @lc app=leetcode.cn id=221 lang=csharp
 *
 * [221] 最大正方形
 */

// @lc code=start
public class Solution {
    public int MaximalSquare(char[][] matrix) {
        if(matrix==null || matrix.Length<1 || matrix[0].Length<1)
            return 0;
        
        int height=matrix.Length;
        int width=matrix[0].Length;
        int maxSide=0;

        int[] dp=new int[width+1];

        foreach(char[] chars in matrix){
            int northwest=0;
            for(int col=0; col<width; col++){
                int nextNorthwest=dp[col+1];
                if(chars[col]=='1'){
                    dp[col+1]=Math.Min(Math.Min(dp[col], dp[col+1]), northwest)+1;
                    maxSide=Math.Max(maxSide,dp[col+1]);
                }
                else
                    dp[col+1]=0;
                
                northwest=nextNorthwest;
            }
        }
        return maxSide*maxSide;
    }
}
// @lc code=end

