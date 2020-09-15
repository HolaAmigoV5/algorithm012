/*
 * @lc app=leetcode.cn id=3 lang=csharp
 *
 * [3] 无重复字符的最长子串
 */

// @lc code=start
public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if(s.Length==0) return 0;
        
        //M1
        int[] map=new int[128];

        int begin=0, end=0, counter=0, maxLen=0;
        while(end<s.Length){
            //>0 means repeating character
            var ch=s[end];
            if(map[ch]>0) counter++;
            map[ch]++;
            end++;

            while(counter>0){
                char c=s[begin];
                if(map[c]>1) counter--;
                map[c]--;
                begin++;
            }
            maxLen=Math.Max(maxLen, end-begin);
        }
        return maxLen;

        //M2
        // var letter=new HashSet<char>();
        // int left=0, right=0, counter=0, max=0;
        // while(right<s.Length){
        //     if(!letter.Contains(s[right])){
        //         letter.Add(s[right]);
        //         right++;
        //         counter++;
        //     }
        //     else{
        //         //the left letter is repeat
        //         letter.Remove(s[left]);
        //         left++;
        //         counter--;
        //     }
        //     max=Math.Max(max, counter);
        // }
        // return max;

        //M3:
        // var dic=new Dictionary<char, int>();
        // int max=0, left=0;
        // for(int i=0; i<s.Length; i++){
        //     if(dic.ContainsKey(s[i]))
        //         left=Math.Max(left, dic[s[i]]);
        //     dic[s[i]]=i+1;
        //     max=Math.Max(max, i-left+1);
        // }
        // return max;
    }
}
// @lc code=end

