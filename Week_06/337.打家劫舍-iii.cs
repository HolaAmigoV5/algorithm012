/*
 * @lc app=leetcode.cn id=337 lang=csharp
 *
 * [337] 打家劫舍 III
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
    public int Rob(TreeNode root) {
        if(root==null)
            return 0;
            
        //brute force
        // int money=root.val;
        // if(root.left!=null)
        //     money+=(Rob(root.left.left)+Rob(root.left.right));
        
        // if(root.right!=null)
        //     money+=(Rob(root.right.left)+Rob(root.right.right));

        // return Math.Max(money, Rob(root.left)+Rob(root.right));

        //use dic
        // var memo=new Dictionary<TreeNode, int> ();
        // return RobInternal(root, memo);

        //use Array
        int[] result=RobInternal(root);
        return Math.Max(result[0], result[1]);
    }

    private int RobInternal(TreeNode root, Dictionary<TreeNode, int> memo){
        if(root==null)
            return 0;
        if(memo.ContainsKey(root))
            return memo[root];
        int money=root.val;
        if(root.left!=null)
            money+=(RobInternal(root.left.left, memo)+RobInternal(root.left.right, memo));
        if(root.right!=null)
            money+=(RobInternal(root.right.left, memo)+RobInternal(root.right.right, memo));

        int result=Math.Max(money, RobInternal(root.left, memo)+RobInternal(root.right, memo));
        memo[root]=result;
        return result;
    }

    private int[] RobInternal(TreeNode root){
        int[] result=new int[2];
        if(root==null)
            return result;
        
        int[] left=RobInternal(root.left);
        int[] right=RobInternal(root.right);

        result[0]=Math.Max(left[0], left[1])+Math.Max(right[0], right[1]);
        result[1]=left[0]+right[0]+root.val;

        return result;
    }
}
// @lc code=end

