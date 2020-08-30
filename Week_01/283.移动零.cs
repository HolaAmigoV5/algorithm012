/*
 * @lc app=leetcode.cn id=283 lang=csharp
 *
 * [283] 移动零
 */

// @lc code=start
public class Solution {
    public void MoveZeroes(int[] nums) {
        //M1
        if (nums == null || nums.Length == 0) return;

        //move zeroes to the end
        int p = 0;
        for (int i = 0; i < nums.Length; i++){
            if (nums[i] != 0){
                if (i != p){
                    nums[p] = nums[i];
                    nums[i] = 0;
                }
                p++;
            }
        }

        //move zeroes to the begin
        // int p=nums.Length-1;
        // for(int i=nums.Length-1; i>=0; i--){
        //     if(nums[i]!=0){
        //         if(i!=p){
        //             nums[p]=nums[i];
        //             nums[i]=0;
        //         }
        //         p--;
        //     }
        // }

        //move zeroes to the center
        int half=(p-1)/2;
        int m=len-1;
        while(half++<p){
            nums[m]=nums[half];
            nums[half]=0;
            m--;
        }
    }
}
// @lc code=end

