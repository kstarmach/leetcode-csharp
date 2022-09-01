namespace LeetCode;

public class Problem_142_LinkedListCycleII
{
    public ListNode DetectCycle(ListNode head)
    {
        if (head == null || head.next == null) return null;

        ListNode slow = head;
        ListNode fast = head;

        while (fast?.next is not null)
        {
            slow = slow.next;
            fast = fast.next.next;
            if (fast == slow)
            {
                slow = head;
                while (slow != fast)
                {
                    slow = slow.next;
                    fast = fast.next;
                }

                return slow;
            }
        }

        return null;
    }
}