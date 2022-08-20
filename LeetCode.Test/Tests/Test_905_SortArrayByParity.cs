namespace LeetCode.Test;

[TestClass]
public class Test_905_SortArrayByParity
{
    [TestMethod]
    public void SortArrayByParity_Test1()
    {
        var solution = new Problem_905_SortArrayByParity();

        int[] input = new int[] { 3, 1, 2, 4 };
        var result = solution.SortArrayByParity(input);
        AssertHelper.AssertArray(new int[] { 2, 4, 3, 1 }, result);
    }
}