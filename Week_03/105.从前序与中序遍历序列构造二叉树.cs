/*
 * @lc app=leetcode.cn id=105 lang=csharp
 *
 * [105] 从前序与中序遍历序列构造二叉树
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
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        //Recursion
        var dic=new Dictionary<int, int>();
        for(int i=0; i<inorder.Length; i++){
            dic[inorder[i]]=i;
        }
        return BuildTreeHelper(preorder,0,preorder.Length,inorder,0,inorder.Length,dic);
    }

    private TreeNode BuildTreeHelper(int[] preorder, int p_start, int p_end, 
    int[] inorder, int i_start, int i_end, Dictionary<int,int> dic){
        //preorder为空，直接返回null
        if(p_start==p_end)
            return null;
        int root_val=preorder[p_start];
        TreeNode root=new TreeNode(root_val);
        //在中序遍历中找到根节点的位置
        int i_root_index=dic[root_val];
        
        int leftNum=i_root_index-i_start;
        //递归构造左子树
        root.left=BuildTreeHelper(preorder, p_start+1, p_start+leftNum+1, inorder, i_start,i_root_index,dic);
        //递归构造右子树
        root.right=BuildTreeHelper(preorder,p_start+leftNum+1, p_end,inorder,i_root_index+1,i_end,dic);
        return root;
    }
}
// @lc code=end

