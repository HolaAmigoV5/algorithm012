/*
 * @lc app=leetcode.cn id=152 lang=csharp
 *
 * [152] 乘积最大子数组
 */

// @lc code=start
public class Solution {
    public int MaxProduct(int[] nums) {
        if(nums.Length==0) return 0;

        //brute froce
        int max=nums[0];
        for(int i=0; i<nums.Length; i++){
            int tmp=1;
            for(int j=i; j<nums.Length; j++){
                tmp*=nums[j];
                max=Math.Max(max, tmp);
            }
        }
        return max;

        //Dp
        // int ans=nums[0];
        // int[] dp_max=new int[nums.Length];
        // int[] dp_min=new int[nums.Length];

        // //base case
        // dp_max[0]=nums[0]; dp_min[0]=nums[0];

        // for(int i=1; i<nums.Length; i++){
        //     dp_max[i]=Math.Max(nums[i], Math.Max(dp_max[i-1]*nums[i], dp_min[i-1]*nums[i]));
        //     dp_min[i]=Math.Min(nums[i], Math.Min(dp_max[i-1]*nums[i], dp_min[i-1]*nums[i]));

        //     ans=Math.Max(ans, dp_max[i]);
        // }

        // return ans;

        // int max=int.MinValue, imax=1, imin=1;
        // for(int i=0; i<nums.Length; i++){
        //     if(nums[i]<0){
        //         int tmp=imax;
        //         imax=imin;
        //         imin=tmp;
        //     }

        //     imax=Math.Max(imax*nums[i], nums[i]);
        //     imin=Math.Min(imin*nums[i], nums[i]);

        //     max=Math.Max(max, imax);
        // }
        // return max;
    }
}
// @lc code=end

