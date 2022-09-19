namespace LeetCode.Test;

[TestClass]
public class Test_206_ReverseLinkedList
{
    [TestMethod]
    public void ReverseList_Test1()
    {
        var solution = new Problem_206_ReverseLinkedList();

        var list = TestHelper.GenerateList(new int[] { 1, 2, 3, 4, 5 });
        var result = solution.ReverseList(list);

        AssertHelper.AssertLinkList(new int[] { 5, 4, 3, 2, 1 }, result);
    }
}