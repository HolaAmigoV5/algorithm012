/*
 * @lc app=leetcode.cn id=11 lang=csharp
 *
 * [11] 盛最多水的容器
 */

// @lc code=start
public class Solution {
    public int MaxArea(int[] height)
    {
        //O(n), O(1)
        int i = 0, j = height.Length - 1, res = 0;
        while (i < j)
        {
            res = height[i] < height[j] ?
            Math.Max(res, (j - i) * height[i++]) :
            Math.Max(res, (j - i) * height[j--]);
        }
        return res;
    }
}
// @lc code=end

