namespace LeetCode;

public class Problem_206_ReverseLinkedList
{
    public ListNode ReverseList(ListNode head)
    {
        ListNode result = null;
        while (head != null)
        {
            var temp = head.next;
            head.next = result;
            result = head;
            head = temp;
        }
        return result;
    }
}