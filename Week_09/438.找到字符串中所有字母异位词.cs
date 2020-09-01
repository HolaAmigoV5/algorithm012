/*
 * @lc app=leetcode.cn id=438 lang=csharp
 *
 * [438] 找到字符串中所有字母异位词
 */

// @lc code=start
public class Solution {
    public IList<int> FindAnagrams(string s, string p) {
        List<int> res=new List<int>();
        if(p.Length>s.Length) return res;
        
        var dic=new Dictionary<char, int>();
        foreach(var ch in p.ToCharArray()){
            if(dic.ContainsKey(ch))
                dic[ch]++;
            else
                dic[ch]=1;
        }

            
        var window=new Dictionary<char, int>();

        int left=0, right=0;
        int valid=p.Length;

        while(right<s.Length){
            if(dic.ContainsKey(s[right])){
                if(window.ContainsKey(s[right]))
                    window[s[right]]++;
                else
                     window[s[right]]=1;
               
                if(window[s[right]]<=dic[s[right]])
                    valid--;
            }

            while(valid==0){
                if(right-left+1==p.Length)
                    res.Add(left);
                if(dic.ContainsKey(s[left])){
                    window[s[left]]--;
                    if(window[s[left]]<dic[s[left]])
                        valid++;
                }
                left++;
            }
            right++;
        }
        return res;
    }
}
// @lc code=end

