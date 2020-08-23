/*
 * @lc app=leetcode.cn id=152 lang=csharp
 *
 * [152] 乘积最大子数组
 */

// @lc code=start
public class Solution {
    public int MaxProduct(int[] nums) {
        int max=int.MinValue, imax=1, imin=1;
        for(int i=0; i<nums.Length; i++){
            if(nums[i]<0){
                int tmp=imax;
                imax=imin;
                imin=tmp;
            }

            imax=Math.Max(imax*nums[i], nums[i]);
            imin=Math.Min(imin*nums[i], nums[i]);

            max=Math.Max(max, imax);
        }
        return max;
    }
}
// @lc code=end

