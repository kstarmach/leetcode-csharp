namespace LeetCode.Test;

[TestClass]
public class Test_160_IntersectionofTwoLinkedLists
{
    [TestMethod]
    public void GetIntersectionNode_Test1()
    {
        var root = TestHelper.GenerateList(new int[] { 8, 4, 5 });
        var headA = TestHelper.GenerateList(new int[] { 4, 1 });
        var headB = TestHelper.GenerateList(new int[] { 5, 6, 1 });
        headA.next.next = root.next;
        headB.next.next.next = root.next;

        var solution = new Problem_160_IntersectionofTwoLinkedLists();
        var result = solution.GetIntersectionNode(headA, headB);
        Assert.AreEqual(4, result.val);
    }

    [TestMethod]
    public void GetIntersectionNode_Test2()
    {
        var root = TestHelper.GenerateList(new int[] { 2, 4 });
        var headA = TestHelper.GenerateList(new int[] { 1, 9, 1 });
        var headB = TestHelper.GenerateList(new int[] { 3 });
        headA.next.next.next = root.next;
        headB.next = root.next;

        var solution = new Problem_160_IntersectionofTwoLinkedLists();
        var result = solution.GetIntersectionNode(headA, headB);
        Assert.AreEqual(4, result.val);
    }

    [TestMethod]
    public void GetIntersectionNode_Test3()
    {
        var headA = TestHelper.GenerateList(new int[] { 2, 6, 4 });
        var headB = TestHelper.GenerateList(new int[] { 1, 5 });

        var solution = new Problem_160_IntersectionofTwoLinkedLists();
        var result = solution.GetIntersectionNode(headA, headB);
        Assert.IsNull(result);
    }
}