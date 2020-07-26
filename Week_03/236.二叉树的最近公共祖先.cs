/*
 * @lc app=leetcode.cn id=236 lang=csharp
 *
 * [236] 二叉树的最近公共祖先
 */

// @lc code=start
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        //O(n), O(n)
        if(root==null || root==p || root ==q)
            return root;
        TreeNode left=LowestCommonAncestor(root.left, p,q);
        TreeNode right=LowestCommonAncestor(root.right, p,q);
        if(left==null)
            return right;
        if(right==null)
            return left;
        return root;
    }
}
// @lc code=end

