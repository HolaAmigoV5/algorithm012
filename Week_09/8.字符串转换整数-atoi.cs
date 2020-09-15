/*
 * @lc app=leetcode.cn id=8 lang=csharp
 *
 * [8] 字符串转换整数 (atoi)
 */

// @lc code=start
using System.Text.RegularExpressions;
public class Solution {
    public int MyAtoi(string str) {
        if(string.IsNullOrEmpty(str.Trim()))
            return 0;

        // var chars=str.ToCharArray();
        // int n=chars.Length;
        // int idx=0;
        // while(idx<n && chars[idx]==' ')
        //     idx++; //去掉前导空格
        // if(idx==n)
        //     return 0; //去掉前导空格后到末尾了

        // bool negative=false;
        // if(chars[idx]=='-'){
        //     negative=true;  //遇到负号
        //     idx++;
        // }
        // else if(chars[idx]=='+')
        //     idx++;
        // else if(!char.IsDigit(chars[idx]))
        //     return 0; //非数字

        // int ans=0;
        // while(idx<n && char.IsDigit(chars[idx])){
        //     int digit=chars[idx]-'0';
        //     if(ans>(int.MaxValue-digit)/10){
        //         // 本来应该是 ans * 10 + digit > Integer.MAX_VALUE
        //         // 但是 *10 和 + digit 都有可能越界，所有都移动到右边去就可以了。
        //         return negative?int.MinValue:int.MaxValue;
        //     }
        //     ans=ans*10+digit;
        //     idx++;
        // }
        // return negative?-ans:ans;

        //Regex
        /* 
            ^ 表示匹配字符串开头，我们匹配的就是 '+'  '-'  号
            [] 表示匹配包含的任一字符，比如[0-9]就是匹配数字字符 0 - 9 中的一个
            ? 表示前面一个字符出现零次或者一次，这里用 ? 是因为 '+' 号可以省略
            \d 表示一个数字 0 - 9 范围
            + 表示前面一个字符出现一次或者多次，\\d+ 合一起就能匹配一连串数字了
        */
        int ans=0;
        str=str.Trim();
        Match match=Regex.Match(str, @"^[\+\-]?\d+");
        if(match.Success){
            if(int.TryParse(match.Value, out ans))
                return ans;
            else
                ans=str[0]=='-'?int.MinValue:int.MaxValue;
        }
        return ans;
    }
}
// @lc code=end

