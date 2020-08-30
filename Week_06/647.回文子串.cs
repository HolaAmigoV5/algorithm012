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
        int len=s.Length;
        if(len<2) return len;
        int count=0;

        //M1:Brute force
        // for(int i=0; i<len; i++){
        //     for(int j=i; j<len; j++){
        //         if(IsPalindrome(s.Substring(i, j-i+1)))
        //             count++;
        //     }
        // }
        // return count;

        //M2, dp, dp[i,j] means whether the substring s[i,j] is palindrome
        // bool[,] dp=new bool[len,len];
        // for(int j=0; j<len; j++){
        //     for(int i=0; i<=j;i++){
        //         // if(s[i]==s[j]){
        //         //     if(i==j){
        //         //         dp[i,j]=true;
        //         //         count++;
        //         //     }
        //         //     else if(j-i==1){
        //         //         dp[i,j]=true;
        //         //         count++;
        //         //     }
        //         //     else if(j-i>0 && dp[i+1,j-1]){
        //         //         dp[i,j]=true;
        //         //         count++;
        //         //     }
        //         // }

        //         if(s[i]==s[j] && (j-i<=1 || dp[i+1, j-1])){
        //             count++;
        //             dp[i,j]=true;
        //         }
        //     }
        // }
        // return count;

        //M3:Dp, Compression space
        bool[] dp=new bool[len];
        for(int j=0; j<len; j++){
            for(int i=0; i<=j; i++){
                if(s[i]==s[j] && (j-i<=1 || dp[i+1])){
                    dp[i]=true;
                    count++;
                }
                else
                    dp[i]=false;
            }
        }
        return count;
        // for(int i=0; i<s.Length; i++){
        //     ExtendPalindrome(s,i,i);
        //     ExtendPalindrome(s,i,i+1);
        // }
        // return count;
    }
    private void ExtendPalindrome(string s, int left, int right){
        while(left>=0 && right<s.Length && s[left]==s[right]){
            count++;
            left--;
            right++;
        }
    }

    private bool IsPalindrome(string str){
        int len=str.Length;
        if(len<2) return true;

        int left=0, right=len-1;
        while(left<right){
            if(str[left++]!=str[right--])
                return false;
            // left++;
            // right--;
        }
        return true;
    }
}
// @lc code=end

