namespace LeetCode.Test;

[TestClass]
public class Test_1480_RunningSumof1dArray
{
    [TestMethod]
    public void RunningSumof1dArrayTest()
    {
        var solution = new Problem_1480_RunningSumof1dArray();

        var result = solution.RunningSum(new int[] { 1, 2, 3, 4 });
        AssertHelper.AssertArray(new int[] { 1, 3, 6, 10 }, result);

        result = solution.RunningSum(new int[] { 1, 1, 1, 1, 1 });
        AssertHelper.AssertArray(new int[] { 1, 2, 3, 4, 5 }, result);

        result = solution.RunningSum(new int[] { 3, 1, 2, 10, 1 });
        AssertHelper.AssertArray(new int[] { 3, 4, 6, 16, 17 }, result);
    }
}