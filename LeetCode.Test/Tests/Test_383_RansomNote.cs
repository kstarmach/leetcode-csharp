namespace LeetCode.Test;

[TestClass]
public class Test_383_RansomNote
{
    [TestMethod]
    public void RansomNote_Test1()
    {
        var solution = new Problem_383_RansomNote();

        var result = solution.CanConstruct("a", "b");
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void RansomNote_Test2()
    {
        var solution = new Problem_383_RansomNote();

        var result = solution.CanConstruct("aa", "ab");
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void RansomNote_Test3()
    {
        var solution = new Problem_383_RansomNote();

        var result = solution.CanConstruct("aa", "aab");
        Assert.IsTrue(result);
    }
}