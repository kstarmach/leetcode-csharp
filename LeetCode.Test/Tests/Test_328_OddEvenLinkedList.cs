namespace LeetCode.Test;

[TestClass]
public class Test_328_OddEvenLinkedList
{
    [TestMethod]
    public void OddEvenList_Test1()
    {
        var solution = new Problem_328_OddEvenLinkedList();

        var list = TestHelper.GenerateList(new int[] { 1, 2, 3, 4, 5 });
        var result = solution.OddEvenList(list);

        AssertHelper.AssertLinkList(new int[] { 1, 3, 5, 2, 4 }, result);
    }

    [TestMethod]
    public void OddEvenList_Test2()
    {
        var solution = new Problem_328_OddEvenLinkedList();

        var list = TestHelper.GenerateList(new int[] { 2, 1, 3, 5, 6, 4, 7 });
        var result = solution.OddEvenList(list);

        AssertHelper.AssertLinkList(new int[] { 2, 3, 6, 7, 1, 5, 4 }, result);
    }
}