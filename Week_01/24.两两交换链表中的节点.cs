/*
 * @lc app=leetcode.cn id=24 lang=csharp
 *
 * [24] 两两交换链表中的节点
 */

// @lc code=start
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode SwapPairs(ListNode head) {
        //Recursion
        // if(head==null || head.next==null)
        //     return head;
        // var next=head.next;
        // head.next=SwapPairs(next.next);
        // next.next=head;
        // return next;

        //Iteration
        ListNode pre=new ListNode(0);
        pre.next=head;
        ListNode temp=pre;
        while(temp.next!=null && temp.next.next!=null){
            ListNode start=temp.next;
            ListNode end=temp.next.next;
            temp.next=end;
            start.next=end.next;
            end.next=start;
            temp=start;
        }
        return pre.next;
    }
}
// @lc code=end

