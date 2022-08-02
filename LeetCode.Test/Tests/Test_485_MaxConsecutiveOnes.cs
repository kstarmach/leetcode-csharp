namespace LeetCode.Test;

[TestClass]
public class Test_485_MaxConsecutiveOnes
{
    [TestMethod]
    public void FindMaxConsecutiveOnes_Test1()
    {
        var solution = new Problem_485_MaxConsecutiveOnes();

        var result = solution.FindMaxConsecutiveOnes(new int[] { 1, 1, 0, 1, 1, 1 });
        Assert.AreEqual(3, result);
    }

    [TestMethod]
    public void FindMaxConsecutiveOnes_Test2()
    {
        var solution = new Problem_485_MaxConsecutiveOnes();

        var result = solution.FindMaxConsecutiveOnes(new int[] { 1, 0, 1, 1, 0, 1 });
        Assert.AreEqual(2, result);
    }
}