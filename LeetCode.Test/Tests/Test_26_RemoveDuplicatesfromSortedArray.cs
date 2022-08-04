namespace LeetCode.Test;

[TestClass]
public class Test_26_RemoveDuplicatesfromSortedArray
{
    [TestMethod]
    public void RemoveDuplicatesfromSortedArray_Test1()
    {
        var solution = new Problem_26_RemoveDuplicatesfromSortedArray();

        int[] input = new int[] { 1, 1, 2 };
        var result = solution.RemoveDuplicates(input);

        Assert.AreEqual(2, result);
        AssertHelper.AssertArray(new int[] { 1, 2 }, input, true);
    }

    [TestMethod]
    public void RemoveDuplicatesfromSortedArray_Test2()
    {
        var solution = new Problem_26_RemoveDuplicatesfromSortedArray();

        int[] input = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
        var result = solution.RemoveDuplicates(input);

        Assert.AreEqual(5, result);
        AssertHelper.AssertArray(new int[] { 0, 1, 2, 3, 4 }, input, true);
    }


}