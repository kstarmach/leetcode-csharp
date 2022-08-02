namespace LeetCode.Test;

[TestClass]
public class Test_1089_DuplicateZeros
{
    [TestMethod]
    public void DuplicateZeros_1()
    {
        var input = new int[] { 1, 0, 2, 3, 0, 4, 5, 0 };

        var solution = new Problem_1089_DuplicateZeros();
        solution.DuplicateZeros(input);
        AssertHelper.AssertList(new int[] { 1, 0, 0, 2, 3, 0, 0, 4 }, input);
    }

    [TestMethod]
    public void DuplicateZeros_2()
    {
        var input = new int[] { 1, 2, 3 };

        var solution = new Problem_1089_DuplicateZeros();
        solution.DuplicateZeros(input);
        AssertHelper.AssertList(new int[] { 1, 2, 3 }, input);
    }
}