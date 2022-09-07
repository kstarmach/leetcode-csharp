namespace LeetCode.Test;

[TestClass]
public class Test_724_FindPivotIndex
{
    [TestMethod]
    public void PivotIndex_Test1()
    {
        int[] input = new int[] { 1, 7, 3, 6, 5, 6 };

        var solution = new Problem_724_FindPivotIndex();
        var result = solution.PivotIndex(input);

        Assert.AreEqual(3, result);

    }

    [TestMethod]
    public void PivotIndex_Test2()
    {
        int[] input = new int[] { 1, 2, 3 };

        var solution = new Problem_724_FindPivotIndex();
        var result = solution.PivotIndex(input);

        Assert.AreEqual(-1, result);

    }

    [TestMethod]
    public void PivotIndex_Test3()
    {
        int[] input = new int[] { 2, 1, -1 };

        var solution = new Problem_724_FindPivotIndex();
        var result = solution.PivotIndex(input);

        Assert.AreEqual(0, result);

    }
}