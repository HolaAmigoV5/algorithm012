/*
 * @lc app=leetcode.cn id=76 lang=csharp
 *
 * [76] 最小覆盖子串
 */

// @lc code=start
public class Solution {
    public string MinWindow(string s, string t) {
        if(string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t))
            return "";
        
        int[] map=new int[128];
        foreach(var ch in t)
            map[ch]++;
        
        int start=0, end=0, minStart=0, minLen=int.MaxValue, counter=t.Length;
        while(end<s.Length){
            char c=s[end];
            if(map[c]>0) counter--;
            map[c]--;
            end++;

            while(counter==0){
                if(minLen>end-start){
                    minLen=end-start;
                    minStart=start;
                }

                char ch=s[start];
                map[ch]++;
                if(map[ch]>0) counter++;
                start++;
            }
        }
        return minLen==int.MaxValue?"":s.Substring(minStart,minLen);
    }
}
// @lc code=end

