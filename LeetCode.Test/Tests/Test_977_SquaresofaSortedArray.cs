namespace LeetCode.Test;

[TestClass]
public class Test_977_SquaresofaSortedArray
{
    [TestMethod]
    public void SquaresofaSortedArray_Test1()
    {
        var solution = new Problem_977_SquaresofaSortedArray();

        var result = solution.SortedSquares(new int[] { -4, -1, 0, 3, 10 });
        AssertHelper.AssertArray(new int[] { 0, 1, 9, 16, 100 }, result);
    }

    [TestMethod]
    public void SquaresofaSortedArray_Test2()
    {
        var solution = new Problem_977_SquaresofaSortedArray();

        var result = solution.SortedSquares(new int[] { -7, -3, 2, 3, 11 });
        AssertHelper.AssertArray(new int[] { 4, 9, 9, 49, 121 }, result);
    }
}