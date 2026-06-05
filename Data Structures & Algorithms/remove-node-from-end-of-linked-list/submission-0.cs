/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        ListNode curr = head;
        List<ListNode> list = new List<ListNode>();
        while(curr!=null)
        {
            list.Add(curr);
            curr = curr.next;
        }

       int count=list.Count();
       int targetNode = count-n;

       if(targetNode==0)
       return head.next;
       ListNode prev = list[targetNode-1];
       prev.next = prev.next.next;

       return head;
    }
}
