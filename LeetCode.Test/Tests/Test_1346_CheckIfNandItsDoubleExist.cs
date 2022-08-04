namespace LeetCode.Test;

[TestClass]
public class Test_1346_CheckIfNandItsDoubleExist
{
    [TestMethod]
    public void CheckIfNandItsDoubleExist_Test1()
    {
        var solution = new Problem_1346_CheckIfNandItsDoubleExist();

        int[] input = new int[] { 10, 2, 5, 3 };
        var result = solution.CheckIfExist(input);
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void CheckIfNandItsDoubleExist_Test2()
    {
        var solution = new Problem_1346_CheckIfNandItsDoubleExist();

        int[] input = new int[] { 7, 1, 14, 11 };
        var result = solution.CheckIfExist(input);
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void CheckIfNandItsDoubleExist_Test3()
    {
        var solution = new Problem_1346_CheckIfNandItsDoubleExist();

        int[] input = new int[] { 3, 1, 7, 11 };
        var result = solution.CheckIfExist(input);
        Assert.IsFalse(result);
    }
    [TestMethod]
    public void CheckIfNandItsDoubleExist_Test4()
    {
        var solution = new Problem_1346_CheckIfNandItsDoubleExist();

        int[] input = new int[] { -2, 0, 10, -19, 4, 6, -8 };
        var result = solution.CheckIfExist(input);
        Assert.IsFalse(result);
    }
}