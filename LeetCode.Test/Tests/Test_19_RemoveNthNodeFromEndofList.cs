namespace LeetCode.Test;

[TestClass]
public class Test_19_RemoveNthNodeFromEndofList
{
    [TestMethod]
    public void RemoveNthFromEnd_Test1()
    {
        ListNode head = TestHelper.GenerateList(new int[] { 1, 2, 3, 4, 5 });

        var solution = new Problem_19_RemoveNthNodeFromEndofList();
        var result = solution.RemoveNthFromEnd(head, 2);

        AssertHelper.AssertLinkList(new int[] { 1, 2, 3, 5 }, result);
    }

    [TestMethod]
    public void RemoveNthFromEnd_Test2()
    {
        ListNode head = TestHelper.GenerateList(new int[] { 1 });

        var solution = new Problem_19_RemoveNthNodeFromEndofList();
        var result = solution.RemoveNthFromEnd(head, 1);

        AssertHelper.AssertLinkList(new int[] { }, result);
    }

    [TestMethod]
    public void RemoveNthFromEnd_Test3()
    {
        ListNode head = TestHelper.GenerateList(new int[] { 1, 2 });

        var solution = new Problem_19_RemoveNthNodeFromEndofList();
        var result = solution.RemoveNthFromEnd(head, 1);

        AssertHelper.AssertLinkList(new int[] { 1 }, result);
    }
}