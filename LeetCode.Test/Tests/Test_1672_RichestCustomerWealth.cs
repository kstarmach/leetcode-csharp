namespace LeetCode.Test;

[TestClass]
public class Test_1672_RichestCustomerWealth
{
    [TestMethod]
    public void RichestCustomerWealth_Test1()
    {
        var solution = new Problem_1672_RichestCustomerWealth();

        var result = solution.MaximumWealth(new int[][] { new int[] { 1, 2, 3 }, new int[] { 3, 2, 1 } });
        Assert.AreEqual(6, result);
    }

    [TestMethod]
    public void RichestCustomerWealth_Test2()
    {
        var solution = new Problem_1672_RichestCustomerWealth();

        var result = solution.MaximumWealth(new int[][] { new int[] { 1, 5 }, new int[] { 7, 3 }, new int[] { 3, 5 } });
        Assert.AreEqual(10, result);
    }

    [TestMethod]
    public void RichestCustomerWealth_Test3()
    {
        var solution = new Problem_1672_RichestCustomerWealth();

        var result = solution.MaximumWealth(new int[][] { new int[] { 2, 8, 7 }, new int[] { 7, 1, 3 }, new int[] { 1, 9, 5 } });
        Assert.AreEqual(17, result);
    }
}