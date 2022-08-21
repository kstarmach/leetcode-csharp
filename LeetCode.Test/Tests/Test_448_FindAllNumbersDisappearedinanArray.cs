namespace LeetCode.Test;

[TestClass]
public class Test_448_FindAllNumbersDisappearedinanArray
{
    [TestMethod]
    public void FindDisappearedNumbers_Test1()
    {
        var solution = new Problem_448_FindAllNumbersDisappearedinanArray();

        int[] input = new int[] { 4, 3, 2, 7, 8, 2, 3, 1 };
        var result = solution.FindDisappearedNumbers(input);

        AssertHelper.AssertList(new int[] { 5, 6 }, result);
    }

    [TestMethod]
    public void FindDisappearedNumbers_Test2()
    {
        var solution = new Problem_448_FindAllNumbersDisappearedinanArray();

        int[] input = new int[] { 1, 1 };
        var result = solution.FindDisappearedNumbers(input);

        AssertHelper.AssertList(new int[] { 2 }, result);
    }
}