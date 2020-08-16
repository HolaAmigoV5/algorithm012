/*
 * @lc app=leetcode.cn id=91 lang=csharp
 *
 * [91] 解码方法
 */

// @lc code=start
public class Solution {
    public int NumDecodings(string s) {
        if(s[0]=='0')
            return 0;
        char[] charArray=s.ToCharArray();
        int last_2=1, last_1=1;
        for(int i=1;i<s.Length; i++){
            int temp=last_1;
            if(charArray[i]=='0'){
                if(charArray[i-1]=='1' || charArray[i-1]=='2')
                    temp=last_2;
                else
                    return 0;
            }
            else if(charArray[i-1]=='1' || 
            (charArray[i-1] == '2' && charArray[i] - '0'>0 && charArray[i] - '0'<7))
                temp+=last_2;
            
            last_2=last_1;
            last_1=temp;
        }
        return last_1;
    }
}
// @lc code=end

