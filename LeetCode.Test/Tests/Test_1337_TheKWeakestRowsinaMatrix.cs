namespace LeetCode.Test;

[TestClass]
public class Test_1337_TheKWeakestRowsinaMatrix
{
    [TestMethod]
    public void TheKWeakestRowsinaMatrix_Test1()
    {
        var solution = new Poblem_1337_TheKWeakestRowsinaMatrix();

        var result = solution.KWeakestRows(
            new int[][] {
                new int[] { 1, 1, 0, 0, 0 },
                new int[] { 1, 1, 1, 1, 0 },
                new int[] { 1, 0, 0, 0, 0 },
                new int[] { 1, 1, 0, 0, 0 },
                new int[] { 1, 1, 1, 1, 1 },
            }, 3);

        AssertHelper.AssertArray(new int[] { 2, 0, 3 }, result);
    }

    [TestMethod]
    public void TheKWeakestRowsinaMatrix_Test2()
    {
        var solution = new Poblem_1337_TheKWeakestRowsinaMatrix();

        var result = solution.KWeakestRows(
            new int[][] {
                new int[] { 1,0,0,0},
                new int[] { 1,1,1,1 },
                new int[] { 1,0,0,0 },
                new int[] { 1,0,0,0 },
            }, 2);

        AssertHelper.AssertArray(new int[] { 0, 2 }, result);
    }
}