namespace LeetCode.Test;

[TestClass]
public class Problem_2235_AddTwoIntegers_Test
{
    [TestMethod]
    public void AddTwoIntegers_PositiveNumbers()
    {
        var solution = new Problem_2235_AddTwoIntegers();

        var result = solution.Sum(12, 5);
        Assert.AreEqual(17, result);

        result = solution.Sum(2, 8);
        Assert.AreEqual(10, result);

        result = solution.Sum(0, 5);
        Assert.AreEqual(5, result);
    }

    [TestMethod]
    public void AddTwoIntegers_NegativeNumbers()
    {
        var solution = new Problem_2235_AddTwoIntegers();

        var result = solution.Sum(-5, 15);
        Assert.AreEqual(10, result);

        result = solution.Sum(10, -2);
        Assert.AreEqual(8, result);

        result = solution.Sum(0, -5);
        Assert.AreEqual(-5, result);
    }
}