/*
 * @lc app=leetcode.cn id=5 lang=csharp
 *
 * [5] 最长回文子串
 */

// @lc code=start
public class Solution {
    int lo=0, maxLen=0;
    public string LongestPalindrome(string s) {
        int len=s.Length;
        if(len<2) return s;

        //M1
        // for(int i=0; i<len-1; i++){
        //     ExpendPalindrome(s,i,i); //assume odd length, try to extend Palindrome as possible
        //     ExpendPalindrome(s,i,i+1); //assum even length
        // }
        // return s.Substring(lo,maxLen);

        //M2
        // int start=0, maxLen=0;
        // for(int i=0; i<len-maxLen/2; i++){
        //     int left=i, right=i;

        //     while(right<len-1 && s[right]==s[right+1])
        //         right++;

        //     while(left>0 && right<len-1 && s[left-1]==s[right+1]){
        //         left--; right++;
        //     }
        //     int newLen=right-left+1;
        //     if(newLen>maxLen){
        //         start=left;
        //         maxLen=newLen;
        //     }
        // }
        // return s.Substring(start, maxLen);

        //dp
        bool[,] dp=new bool[len, len];
        int maxLen=1, start=0;
        for(int i=len-1; i>=0; i--){
            for(int j=i; j<len; j++){
                dp[i,j]=s[i]==s[j] && (j-i<3 || dp[i+1,j-1]);
                if(dp[i,j]){
                    if(j-i+1>maxLen){
                        maxLen=j-i+1;
                        start=i;
                    }
                }
            }
        }
        return s.Substring(start,maxLen);
    }
    private void ExpendPalindrome(string s, int j, int k){
        while(j>=0 && k<s.Length && s[j]==s[k]){
            j--; k++;
        }
        if(k-j-1>maxLen){
            lo=j+1;
            maxLen=k-j-1;
        }
    }
}
// @lc code=end

