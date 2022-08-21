namespace LeetCode.Test;

[TestClass]
public class Test_414_ThirdMaximumNumber
{
    [TestMethod]
    public void ThirdMax_Test1()
    {
        var solution = new Problem_414_ThirdMaximumNumber();

        int[] input = new int[] { 3, 2, 1 };
        var result = solution.ThirdMax(input);

        Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void ThirdMax_Test2()
    {
        var solution = new Problem_414_ThirdMaximumNumber();

        int[] input = new int[] { 1, 2 };
        var result = solution.ThirdMax(input);

        Assert.AreEqual(2, result);
    }

    [TestMethod]
    public void ThirdMax_Test3()
    {
        var solution = new Problem_414_ThirdMaximumNumber();

        int[] input = new int[] { 2, 2, 3, 1 };
        var result = solution.ThirdMax(input);

        Assert.AreEqual(1, result);
    }
    
    [TestMethod]
    public void ThirdMax_Test4()
    {
        var solution = new Problem_414_ThirdMaximumNumber();

        int[] input = new int[] { 5, 2, 2 };
        var result = solution.ThirdMax(input);

        Assert.AreEqual(5, result);
    }
}