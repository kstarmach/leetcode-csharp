namespace LeetCode.Test;

[TestClass]
public class Test_1051_HeightChecker
{
    [TestMethod]
    public void HeightChecker_Test1()
    {
        var solution = new Problem_1051_HeightChecker();

        int[] input = new int[] { 1, 1, 4, 2, 1, 3 };
        var result = solution.HeightChecker(input);

        Assert.AreEqual(3, result);
        AssertHelper.AssertArray(new int[] { 1, 1, 1, 2, 3, 4 }, input);
    }

    [TestMethod]
    public void HeightChecker_Test2()
    {
        var solution = new Problem_1051_HeightChecker();

        int[] input = new int[] { 5, 1, 2, 3, 4 };
        var result = solution.HeightChecker(input);

        Assert.AreEqual(5, result);
        AssertHelper.AssertArray(new int[] { 1, 2, 3, 4, 5 }, input);
    }

    [TestMethod]
    public void HeightChecker_Test3()
    {
        var solution = new Problem_1051_HeightChecker();

        int[] input = new int[] { 1, 2, 3, 4, 5 };
        var result = solution.HeightChecker(input);

        Assert.AreEqual(0, result);
        AssertHelper.AssertArray(new int[] { 1, 2, 3, 4, 5 }, input);
    }
}