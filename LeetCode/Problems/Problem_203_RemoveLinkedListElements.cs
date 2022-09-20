namespace LeetCode;

public class Problem_203_RemoveLinkedListElements
{
    public ListNode RemoveElements(ListNode head, int val)
    {
        var temp = head;

        while (temp != null && temp.next != null)
        {
            if (temp.next.val == val)
            {
                temp.next = temp.next.next;
            }
            else
            {
                temp = temp.next;
            }
        }

        if (head != null && head.val == val)
        {
            head = head.next;
        }
        return head;
    }
}