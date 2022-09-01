namespace LeetCode.Test;

[TestClass]
public class Test_141_LinkedListCycle
{
    [TestMethod]
    public void HasCycle_Test1()
    {
        var solution = new Problem_141_LinkedListCycle();

        var root = TestHelper.GenerateList(new int[] { 3, 2, 0, -4 });
        root.next.next.next.next = root.next;
        var result = solution.HasCycle(root);

        Assert.IsTrue(result);
    }

    [TestMethod]
    public void HasCycle_Test2()
    {
        var solution = new Problem_141_LinkedListCycle();

        var root = TestHelper.GenerateList(new int[] { 1, 2 });
        root.next.next = root.next;
        var result = solution.HasCycle(root);

        Assert.IsTrue(result);
    }

    [TestMethod]
    public void HasCycle_Test3()
    {
        var solution = new Problem_141_LinkedListCycle();

        var root = TestHelper.GenerateList(new int[] { 1 });
        var result = solution.HasCycle(root);

        Assert.IsFalse(result);
    }
}