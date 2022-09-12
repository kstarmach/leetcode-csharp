namespace LeetCode.Test;

[TestClass]
public class Test_392_IsSubsequence
{
    [TestMethod]
    public void IsSubsequence_Test1()
    {
        var solution = new Problem_392_IsSubsequence();

        var result = solution.IsSubsequence("abc", "ahbgdc");
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void IsSubsequence_Test2()
    {
        var solution = new Problem_392_IsSubsequence();

        var result = solution.IsSubsequence("axc", "ahbgdc");
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void IsSubsequence_Test3()
    {
        var solution = new Problem_392_IsSubsequence();

        var result = solution.IsSubsequence("acb", "ahbgdc");
        Assert.IsFalse(result);
    }
}