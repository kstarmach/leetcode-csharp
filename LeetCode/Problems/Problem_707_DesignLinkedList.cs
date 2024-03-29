namespace LeetCode;

public class MyListNode
{
    public int val;
    public MyListNode next;

    public MyListNode(int val)
    {
        this.val = val;
        this.next = null;
    }
}

public class MyLinkedList
{
    private MyListNode head;

    /** Initialize your data structure here. */
    public MyLinkedList()
    {
        head = null;
    }

    /** Get the value of the index-th node in the linked list. If the index is invalid, return -1. */
    public int Get(int index)
    {
        MyListNode current = head;
        int i = 0;
        while (current != null && i < index)
        {
            current = current.next;
            i++;
        }

        if (current == null) return -1;

        return current.val;
    }

    /** Add a node of value val before the first element of the linked list. After the insertion, the new node will be the first node of the linked list. */
    public void AddAtHead(int val)
    {
        MyListNode first = new MyListNode(val);
        first.next = head;
        head = first;
    }

    /** Append a node of value val to the last element of the linked list. */
    public void AddAtTail(int val)
    {
        MyListNode current = head;
        MyListNode previous = null;

        while (current != null)
        {
            previous = current;
            current = current.next;
        }

        if (previous == null)
        {
            head = new MyListNode(val);
        }
        else
        {
            previous.next = new MyListNode(val);
        }
    }

    /** Add a node of value val before the index-th node in the linked list. 
    If index equals to the length of linked list, the node will be appended to the end of linked list. 
    If index is greater than the length, the node will not be inserted. */
    public void AddAtIndex(int index, int val)
    {
        MyListNode current = head;
        MyListNode previous = null;

        if (index < 0) return;

        if (index == 0)
        {
            var next = head;
            head = new MyListNode(val);
            head.next = next;
            return;
        }

        int i = 0;
        while (current != null && i < index)
        {
            previous = current;
            current = current.next;
            i++;
        }

        if (i == index)
        {
            var next = current;
            previous.next = new MyListNode(val);
            previous.next.next = next;
        }

    }

    /** Delete the index-th node in the linked list, if the index is valid. */
    public void DeleteAtIndex(int index)
    {
        MyListNode current = head;
        MyListNode previous = null;

        if (index < 0) return;

        if (index == 0)
        {
            head = head.next;
            return;
        }

        int i = 0;

        while (current != null && i < index)
        {
            previous = current;
            current = current.next;
            i++;
        }

        if (i == index) previous.next = current?.next;

    }
}
