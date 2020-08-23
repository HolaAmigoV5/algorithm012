/*
 * @lc app=leetcode.cn id=647 lang=csharp
 *
 * [647] 回文子串
 */

// @lc code=start
public class Solution {
    int count=0;
    public int CountSubstrings(string s) {
        if(s==null || s.Length==0)
            return 0;
       //dp
        // int n=s.Length;
        // //bool[,] dp=new bool[n,n];
        // bool[] dp=new bool[n];
        // for(int j=0; j<n; j++){
        //     for(int i=0; i<=j; i++){
        //         // if(s[i]==s[j])
        //         //     if(dp[i,j]=i==j || j-i==1 || dp[i+1,j-1])
        //         //         count++;

        //         if(s[i]==s[j] && (j-i<=1 || dp[i+1])){
        //             count++;
        //             dp[i]=true;
        //         }
        //         else
        //             dp[i]=false;
                    
        //     }
        // }
        // return count;

        for(int i=0; i<s.Length; i++){
            ExtendPalindrome(s,i,i);
            ExtendPalindrome(s,i,i+1);
        }
        return count;
    }
    private void ExtendPalindrome(string s, int left, int right){
        while(left>=0 && right<s.Length && s[left]==s[right]){
            count++;
            left--;
            right++;
        }
    }
}
// @lc code=end

