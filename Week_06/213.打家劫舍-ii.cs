/*
 * @lc app=leetcode.cn id=213 lang=csharp
 *
 * [213] 打家劫舍 II
 */

// @lc code=start
public class Solution {
    public int Rob(int[] nums) {
        int len = nums.Length;
        if(len == 0 ) return 0;
        if(len == 1 ) return nums[0];

        return Math.Max(GetResult(nums,0,len-1),
                        GetResult(nums,1,len));
    }

    private int GetResult(int[] nums,int start,int length){
        int curr = 0 ,pre = 0 ,temp;
        for(int i = start ; i < length ; i++){
            temp = curr;
            curr = Math.Max(curr,pre+nums[i]);
            pre = temp;
        }
        return curr;
    }
}
// @lc code=end

