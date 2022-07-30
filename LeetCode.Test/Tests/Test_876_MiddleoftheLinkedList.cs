namespace LeetCode.Test;

[TestClass]
public class Test_876_MiddleoftheLinkedList
{
    [TestMethod]
    public void MiddleoftheLinkedList_Test1()
    {
        var solution = new Problem_876_MiddleoftheLinkedList();

        var result = solution.MiddleNode(TestHelper.GenerateList(new int[] { 1, 2, 3, 4, 5 }));
        AssertHelper.AssertLinkList(new int[] { 3, 4, 5 }, result);
    }

    [TestMethod]
    public void MiddleoftheLinkedList_Test2()
    {
        var solution = new Problem_876_MiddleoftheLinkedList();

        var result = solution.MiddleNode(TestHelper.GenerateList(new int[] { 1, 2, 3, 4, 5, 6 }));
        AssertHelper.AssertLinkList(new int[] { 4, 5, 6 }, result);
    }
}