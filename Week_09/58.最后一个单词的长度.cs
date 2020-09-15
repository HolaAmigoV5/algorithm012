/*
 * @lc app=leetcode.cn id=58 lang=csharp
 *
 * [58] 最后一个单词的长度
 */

// @lc code=start
public class Solution {
    public int LengthOfLastWord(string s) {
        if(string.IsNullOrEmpty(s))
            return 0;
        //return s.Trim().Split(' ').Last().Length;

        int end=s.Length-1;
        while(end>=0 && s[end]==' ')
            end--;
        if(end<0) return 0;

        int start=end;
        while(start>=0 && s[start]!=' ')
            start--;
        
        return end-start;
    }
}
// @lc code=end

