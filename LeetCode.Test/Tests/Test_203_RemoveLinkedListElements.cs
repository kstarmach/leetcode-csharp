namespace LeetCode.Test;

[TestClass]
public class Test_203_RemoveLinkedListElements
{
    [TestMethod]
    public void RemoveElements_Test1()
    {
        var solution = new Problem_203_RemoveLinkedListElements();

        var list = TestHelper.GenerateList(new int[] { 1, 2, 6, 3, 4, 5, 6 });
        var result = solution.RemoveElements(list, 6);

        AssertHelper.AssertLinkList(new int[] { 1, 2, 3, 4, 5 }, result);
    }
}
