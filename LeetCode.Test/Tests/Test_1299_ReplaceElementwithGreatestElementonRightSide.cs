namespace LeetCode.Test;

[TestClass]
public class Test_1299_ReplaceElementwithGreatestElementonRightSide
{
    [TestMethod]
    public void ReplaceElements_Test1()
    {
        var solution = new Problem_1299_ReplaceElementwithGreatestElementonRightSide();
        int[] input = new int[] { 17, 18, 5, 4, 6, 1 };
        var result = solution.ReplaceElements(input);
        AssertHelper.AssertArray(new int[] { 18, 6, 6, 6, 1, -1 }, result);
    }

    [TestMethod]
    public void ReplaceElements_OnlyOneNumber()
    {
        var solution = new Problem_1299_ReplaceElementwithGreatestElementonRightSide();
        int[] input = new int[] { 420 };
        var result = solution.ReplaceElements(input);
        AssertHelper.AssertArray(new int[] { -1 }, result);
    }

    [TestMethod]
    public void ReplaceElements_EmptyArray()
    {
        var solution = new Problem_1299_ReplaceElementwithGreatestElementonRightSide();
        int[] input = new int[] { };
        var result = solution.ReplaceElements(input);
        AssertHelper.AssertArray(null, result);
    }

    [TestMethod]
    public void ReplaceElements_TwoSizeArray1()
    {
        var solution = new Problem_1299_ReplaceElementwithGreatestElementonRightSide();
        int[] input = new int[] { 5, 4 };
        var result = solution.ReplaceElements(input);
        AssertHelper.AssertArray(new int[] { 5, -1 }, result);
    }

    [TestMethod]
    public void ReplaceElements_TwoSizeArray2()
    {
        var solution = new Problem_1299_ReplaceElementwithGreatestElementonRightSide();
        int[] input = new int[] { 3, 8 };
        var result = solution.ReplaceElements(input);
        AssertHelper.AssertArray(new int[] { 8, -1 }, result);
    }


}