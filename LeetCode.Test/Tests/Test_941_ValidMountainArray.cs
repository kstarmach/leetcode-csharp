namespace LeetCode.Test;

[TestClass]
public class Test_941_ValidMountainArray
{
    [TestMethod]
    public void ValidMountainArray_Test1()
    {
        var solution = new Problem_941_ValidMountainArray();

        int[] input = new int[] { 2, 1 };
        var result = solution.ValidMountainArray(input);

        Assert.IsFalse(result);
    }
    [TestMethod]
    public void ValidMountainArray_Test2()
    {
        var solution = new Problem_941_ValidMountainArray();

        int[] input = new int[] { 3, 5, 5 };
        var result = solution.ValidMountainArray(input);

        Assert.IsFalse(result);
    }
    [TestMethod]
    public void ValidMountainArray_Test3()
    {
        var solution = new Problem_941_ValidMountainArray();

        int[] input = new int[] { 0, 3, 2, 1 };
        var result = solution.ValidMountainArray(input);

        Assert.IsTrue(result);
    }
    [TestMethod]
    public void ValidMountainArray_Test4()
    {
        var solution = new Problem_941_ValidMountainArray();

        int[] input = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        var result = solution.ValidMountainArray(input);

        Assert.IsFalse(result);
    }
    [TestMethod]
    public void ValidMountainArray_Test5()
    {
        var solution = new Problem_941_ValidMountainArray();

        int[] input = new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
        var result = solution.ValidMountainArray(input);

        Assert.IsFalse(result);
    }
}