/*
 * @lc app=leetcode.cn id=198 lang=csharp
 *
 * [198] 打家劫舍
 */

// @lc code=start
public class Solution {
    public int Rob(int[] nums) {
        if(nums==null || nums.Length==0)
            return 0;
        
        //O(n), O(n)
        // int n=nums.Length;
        // int[] dp=new int[n+1];
        // dp[0]=0;
        // dp[1]=nums[0];

        // for(int k=2; k<=n;k++)
        //     dp[k]=Math.Max(dp[k-1], nums[k-1]+dp[k-2]);
        
        // return dp[n];

        //M2: states Compressing. O(n), O(1)
        int prev=0, curr=0;
        foreach(var num in nums){
            int temp=Math.Max(curr, prev+num);
            prev=curr;
            curr=temp;
        }
        return curr;
    }
}
// @lc code=end

