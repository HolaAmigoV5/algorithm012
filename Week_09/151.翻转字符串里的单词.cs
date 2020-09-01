/*
 * @lc app=leetcode.cn id=151 lang=csharp
 *
 * [151] 翻转字符串里的单词
 */

// @lc code=start
public class Solution {
    public string ReverseWords(string s) {
        //O(n), O(n)
        // string[] strs=s.Split(' ').Where(s=>s.Length>0).ToArray();
        // Array.Reverse(strs);
        // return string.Join(" ", strs);

        string[] strs=s.Split(' ');
        var sb=new StringBuilder();
        int len=strs.Length;
        while(len-->0){
            //Console.WriteLine(strs[len]);
            if(!string.IsNullOrEmpty(strs[len]))
                sb.Append(strs[len]+" ");
        }
        
        return sb.ToString().Trim();
    }
}
// @lc code=end

