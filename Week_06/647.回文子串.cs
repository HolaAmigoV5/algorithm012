/*
 * @lc app=leetcode.cn id=647 lang=csharp
 *
 * [647] 回文子串
 */

// @lc code=start
public class Solution {
    public int CountSubstrings(string s) {
        if(string .IsNullOrEmpty(s))
            return 0;
        
        int n=s.Length;
        bool[,] dp=new bool[n,n];
        int result=s.Length;
        for(int i=0; i<n; i++)
            dp[i,i]=true;

        for(int i=n-1; i>=0; i--){
            for(int j=i+1; j<n; j++){
                if(s[i]==s[j])
                {
                    if(j-i==1)
                        dp[i,j]=true;
                    else
                        dp[i,j]=dp[i+1,j-1];
                }
                else
                    dp[i,j]=false;
                if(dp[i,j])
                    result++;
            }
        }
        return result;
    }
}
// @lc code=end

