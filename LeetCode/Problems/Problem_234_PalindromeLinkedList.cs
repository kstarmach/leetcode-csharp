namespace LeetCode;

public class Problem_234_PalindromeLinkedList
{
    public bool IsPalindrome(ListNode head)
    {
        List<int> temp = new List<int>();

        while (head != null)
        {
            temp.Add(head.val);
            head = head.next;
        }

        var temp_array = temp.ToArray();
        int front = 0;
        int back = temp.Count() - 1;
        while (front < back)
        {
            if (!temp_array[front].Equals(temp_array[back]))
            {
                return false;
            }

            front++;
            back--;
        }

        return true;
    }
}