/*
 * @lc app=leetcode.cn id=438 lang=csharp
 *
 * [438] 找到字符串中所有字母异位词
 */

// @lc code=start
public class Solution {
    public IList<int> FindAnagrams(string s, string p) {
       var res=new List<int>();
       if(p.Length>s.Length) return res;

       //map the p
       var dic=new Dictionary<char, int>();
       foreach(var ch in p){
            if(dic.ContainsKey(ch))
                dic[ch]++;
            else
                dic[ch]=1;
       }

       int left=0, right=0, counter=dic.Count;
       //build window
       while(right<s.Length){
           var ch =s[right];
           if(dic.ContainsKey(ch)){
               dic[ch]--;
               if(dic[ch]==0) counter--;
           }
           right++;

           while(counter==0){
               var c=s[left];
               if(dic.ContainsKey(c)){
                   dic[c]++;
                   if(dic[c]>0) counter++;
               }

                if(right-left==p.Length)
                    res.Add(left);
                left++;
           }
       }
       return res;
    }
}
// @lc code=end

