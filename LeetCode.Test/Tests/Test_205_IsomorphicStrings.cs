namespace LeetCode.Test;

[TestClass]
public class Test_205_IsomorphicStrings
{
    [TestMethod]
    public void IsIsomorphic_Test1()
    {
        var solution = new Problem_205_IsomorphicStrings();
        var result = solution.IsIsomorphic("egg", "add");

        Assert.IsTrue(result);
    }

    [TestMethod]
    public void IsIsomorphic_Test2()
    {
        var solution = new Problem_205_IsomorphicStrings();
        var result = solution.IsIsomorphic("foo", "bar");

        Assert.IsFalse(result);
    }

    [TestMethod]
    public void IsIsomorphic_Test3()
    {
        var solution = new Problem_205_IsomorphicStrings();
        var result = solution.IsIsomorphic("paper", "title");

        Assert.IsTrue(result);
    }

}