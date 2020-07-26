/*
 * @lc app=leetcode.cn id=189 lang=csharp
 *
 * [189] 旋转数组
 *
 * https://leetcode-cn.com/problems/rotate-array/description/
 *
 * algorithms
 * Easy (42.05%)
 * Likes:    617
 * Dislikes: 0
 * Total Accepted:    139.2K
 * Total Submissions: 330.9K
 * Testcase Example:  '[1,2,3,4,5,6,7]\n3'
 *
 * 给定一个数组，将数组中的元素向右移动 k 个位置，其中 k 是非负数。
 * 
 * 示例 1:
 * 
 * 输入: [1,2,3,4,5,6,7] 和 k = 3
 * 输出: [5,6,7,1,2,3,4]
 * 解释:
 * 向右旋转 1 步: [7,1,2,3,4,5,6]
 * 向右旋转 2 步: [6,7,1,2,3,4,5]
 * 向右旋转 3 步: [5,6,7,1,2,3,4]
 * 
 * 
 * 示例 2:
 * 
 * 输入: [-1,-100,3,99] 和 k = 2
 * 输出: [3,99,-1,-100]
 * 解释: 
 * 向右旋转 1 步: [99,-1,-100,3]
 * 向右旋转 2 步: [3,99,-1,-100]
 * 
 * 说明:
 * 
 * 
 * 尽可能想出更多的解决方案，至少有三种不同的方法可以解决这个问题。
 * 要求使用空间复杂度为 O(1) 的 原地 算法。
 * 
 * 
 */

// @lc code=start
public class Solution {
    public void Rotate(int[] nums, int k) {
        //M1:move 1 step, k times
        // int tem=0, pre=0;
        // k%=nums.Length;
        // for(int i=0;i<k;i++){
        //     pre=nums[nums.Length-1];
        //     for(int j=0;j<nums.Length;j++){
        //         tem=nums[j];
        //         nums[j]=pre;
        //         pre=tem;
        //     }
        // }

        //M2：new Array
        /* int len=nums.Length;
        int [] newNums=new int[len];
        for(int i=0;i<len;i++){
            newNums[(i+k)%len]=nums[i];
        }
        for(int i=0;i<len;i++){
            nums[i]=newNums[i];
        } */

        //M3:loop Replace
        int len=nums.Length;
        k=k%len;
        int count=0;
        for(int start=0; count<len;start++){
            int current=start;
            int prev=nums[start];
            do
            {
                int next=(current+k)%len;
                int temp=nums[next];
                nums[next]=prev;
                prev=temp;
                current=next;
                count++;
            } while (start!=current);
        } 

        //M4: Reverse
        // int len=nums.Length;
        // k%=len;
        // reverse(nums,0,len-1);
        // reverse(nums,0,k-1);
        // reverse(nums,k,len-1);
    }

    public void reverse(int[] nums, int start, int end){
        while (start < end)
        {
            int temp = nums[start];
            nums[start] = nums[end];
            nums[end] = temp;
            start++;
            end--;
        }
    }
}
// @lc code=end

