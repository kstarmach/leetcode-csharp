namespace LeetCode;

public class Problem_19_RemoveNthNodeFromEndofList
{
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        ListNode temp = new ListNode(0, head);
        var slow = temp;
        var fast = temp;

        for (int i = 0; i < n; i++)
        {
            fast = fast.next;
        }

        while (fast?.next != null)
        {
            slow = slow.next;
            fast = fast.next;
        }

        slow.next = slow.next.next;

        return temp.next;
    }
}