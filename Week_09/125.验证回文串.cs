/*
 * @lc app=leetcode.cn id=125 lang=csharp
 *
 * [125] 验证回文串
 */

// @lc code=start
public class Solution {
    public bool IsPalindrome(string s) {
        int left=0, right=s.Length-1;
        while(left<right){
            while(left<right && !char.IsLetterOrDigit(s[left])) left++;
            while(left<right && !char.IsLetterOrDigit(s[right])) right--;

            if(char.ToLower(s[left++])!=char.ToLower(s[right--]))
                return false;
        }
        return true;
    }
}
// @lc code=end

