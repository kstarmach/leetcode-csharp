namespace LeetCode.Test;

[TestClass]
public class Test_283_MoveZeroes
{
    [TestMethod]
    public void MoveZeroes_Test1()
    {
        int[] input = new int[] { 0, 1, 0, 3, 12 };
        var solution = new Problem_283_MoveZeroes();
        solution.MoveZeroes(input);

        AssertHelper.AssertArray(new int[] { 1, 3, 12, 0, 0 }, input);
    }

    [TestMethod]
    public void MoveZeroes_Test2()
    {
        int[] input = new int[] { 0 };
        var solution = new Problem_283_MoveZeroes();
        solution.MoveZeroes(input);

        AssertHelper.AssertArray(new int[] { 0 }, input);
    }
}