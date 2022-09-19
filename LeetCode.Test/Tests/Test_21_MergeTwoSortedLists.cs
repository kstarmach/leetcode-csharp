namespace LeetCode.Test;

[TestClass]
public class Test_21_MergeTwoSortedLists
{
    [TestMethod]
    public void MergeTwoLists_Test1()
    {
        var solution = new Problem_21_MergeTwoSortedLists();

        var node1 = TestHelper.GenerateList(new int[] { 1, 2, 4 });
        var node2 = TestHelper.GenerateList(new int[] { 1, 3, 4 });
        var result = solution.MergeTwoLists(node1, node2);

        AssertHelper.AssertLinkList(new int[] { 1, 1, 2, 3, 4, 4 }, result);
    }
    [TestMethod]
    public void MergeTwoLists_Test2()
    {
        var solution = new Problem_21_MergeTwoSortedLists();

        var node1 = TestHelper.GenerateList(new int[] { });
        var node2 = TestHelper.GenerateList(new int[] { });
        var result = solution.MergeTwoLists(node1, node2);

        Assert.IsNull(result);
    }
    [TestMethod]
    public void MergeTwoLists_Test3()
    {
        var solution = new Problem_21_MergeTwoSortedLists();

        var node1 = TestHelper.GenerateList(new int[] { });
        var node2 = TestHelper.GenerateList(new int[] { 0 });
        var result = solution.MergeTwoLists(node1, node2);

        AssertHelper.AssertLinkList(new int[] { 0 }, result);
    }
}