/*
 * @lc app=leetcode.cn id=1 lang=csharp
 *
 * [1] 两数之和
 */

// @lc code=start
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        //M1:Violence, O(n²), O(1)
        // for(int i=0;i<nums.Length;i++){
        //     for(int j=i+1;j<nums.Length;j++){
        //         if(nums[i]+nums[j]==target)
        //             return new int[]{i,j};
        //     }
        // }
        // return null;

        //M2:use Dictionary, O(n),O(n)
        Dictionary<int, int> kvs = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int tem = target - nums[i];
            if (kvs.ContainsKey(tem))
            {
                return new int[] { i, kvs[tem] };
            }
            if (!kvs.ContainsKey(nums[i]))
                kvs.Add(nums[i], i);
        }
        return new int[] { 0, 0 };
    }
}
// @lc code=end

