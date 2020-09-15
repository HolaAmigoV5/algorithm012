/*
 * @lc app=leetcode.cn id=771 lang=csharp
 *
 * [771] 宝石与石头
 */

// @lc code=start
public class Solution {
    public int NumJewelsInStones(string J, string S) {
        if(string.IsNullOrEmpty(J) || string.IsNullOrEmpty(S))
            return 0;

        int count=0;
        //M1
        // foreach(var ch in S){
        //     if(J.IndexOf(ch)>=0)
        //         count++;
        // }
        // return count;

        //M2
        var chars=S.ToCharArray();
        foreach(char c in chars){
            if(J.Contains(c))
                count++;
        }
        return count;
    }
}
// @lc code=end

