/*
 * @lc app=leetcode.cn id=25 lang=csharp
 *
 * [25] K 个一组翻转链表
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
    public ListNode ReverseKGroup(ListNode head, int k) {
        // int n=0;
        // for(ListNode i=head; i!=null; n++, i=i.next);
        // ListNode dmy=new ListNode(0);
        // dmy.next=head;
        // for(ListNode prev=dmy, tail=head; n>=k; n-=k){
        //     for(int i=1; i<k; i++){
        //         ListNode next=tail.next.next;
        //         tail.next.next=prev.next;
        //         prev.next=tail.next;
        //         tail.next=next;
        //     }

        //     prev=tail;
        //     tail=tail.next;
        // }
        // return dmy.next;

        //Recursion
        ListNode curr=head;
        int count=0;
        while(curr!=null && count!=k){
            curr=curr.next;
            count++;
        }
        if(count==k){
            curr=ReverseKGroup(curr,k);
            while(count-->0){
                ListNode tmp=head.next;
                head.next=curr;
                curr=head;
                head=tmp;
            }
            head=curr;
        }
        return head;
    }
}
// @lc code=end

