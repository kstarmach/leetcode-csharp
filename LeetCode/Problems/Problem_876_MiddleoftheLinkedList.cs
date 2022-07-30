namespace LeetCode;

public class Problem_876_MiddleoftheLinkedList
{
    public ListNode MiddleNode(ListNode head)
    {
        var result = head;
        int count = 1;
        while (head.next != null)
        {
            count++;

            head = head.next;
            if (count % 2 == 0)
            {
                result = result.next;
            }
        }

        return result;
    }
}

