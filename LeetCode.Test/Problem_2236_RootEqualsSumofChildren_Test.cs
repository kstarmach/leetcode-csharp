namespace LeetCode.Test;

[TestClass]
public class Problem_2236_RootEqualsSumofChildren_Test
{
    [TestMethod]
    public void RootEqualsSumofChildren_TrueStatement()
    {
        var root = TestHelper.GenerateTree(new int?[] { 10, 4, 6 });
        var solution = new Problem_2236_RootEqualsSumofChildren();
        var result = solution.RootEqualsSumofChildren(root);
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void RootEqualsSumofChildren_FalseStatement()
    {
        var root = TestHelper.GenerateTree(new int?[] { 10, 4, 8 });
        var solution = new Problem_2236_RootEqualsSumofChildren();
        var result = solution.RootEqualsSumofChildren(root);
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void RootEqualsSumofChildren_NegativeNumbers()
    {
        var root = TestHelper.GenerateTree(new int?[] { -23, -3, -23 });
        var solution = new Problem_2236_RootEqualsSumofChildren();
        var result = solution.RootEqualsSumofChildren(root);
        Assert.IsFalse(result);
    }
}