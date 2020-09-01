/*
 * @lc app=leetcode.cn id=557 lang=csharp
 *
 * [557] 反转字符串中的单词 III
 */

// @lc code=start
public class Solution {
    public string ReverseWords(string s) {
        // string[] st=s.Split(' ');
        // StringBuilder sb=new StringBuilder();
        // for(int i=0; i<st.Length; i++){
        //     char[] arr=st[i].ToCharArray();
        //     Array.Reverse(arr);
        //     sb.Append(new string(arr)+" ");
        // }
        // return sb.ToString().Trim();

         if(string.IsNullOrEmpty(s))
            return s;
        
        string[] strs=s.Split(' ');

        var sb=new StringBuilder();
        foreach(string str in strs)
            sb.Append(Reverse(str)+" ");
        return sb.ToString().Trim();
    }

    private string Reverse(string str){
        if(string.IsNullOrEmpty(str) || str.Length==1)
            return str;
        
        int left=0, right=str.Length-1;
        char[] arr=str.ToCharArray();

        while(left<right){
            var tmp=arr[left];
            arr[left++]=arr[right];
            arr[right--]=tmp;
        }

        return new string(arr);
    }
}
// @lc code=end

