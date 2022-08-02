namespace LeetCode.Test;

[TestClass]
public class Test_88_MergeSortedArray
{
    [TestMethod]
    public void MergeSortedArray_Test1()
    {
        var nums1 = new int[] { 1, 2, 3, 0, 0, 0 };
        var nums2 = new int[] { 2, 5, 6 };

        var solution = new Problem_88_MergeSortedArray();
        solution.Merge(nums1, 3, nums2, 3);

        AssertHelper.AssertArray(new int[] { 1, 2, 2, 3, 5, 6 }, nums1);
    }

    [TestMethod]
    public void MergeSortedArray_Test2()
    {
        var nums1 = new int[] { 1 };
        var nums2 = new int[] { };

        var solution = new Problem_88_MergeSortedArray();
        solution.Merge(nums1, 1, nums2, 0);

        AssertHelper.AssertArray(new int[] { 1 }, nums1);
    }

    [TestMethod]
    public void MergeSortedArray_Test3()
    {
        var nums1 = new int[] { 0 };
        var nums2 = new int[] { 1 };

        var solution = new Problem_88_MergeSortedArray();
        solution.Merge(nums1, 0, nums2, 1);

        AssertHelper.AssertArray(new int[] { 1 }, nums1);
    }

    [TestMethod]
    public void MergeSortedArray_Test4()
    {
        var nums1 = new int[] { -1, 0, 0, 3, 3, 3, 0, 0, 0 };
        var nums2 = new int[] { 1, 2, 2 };

        var solution = new Problem_88_MergeSortedArray();
        solution.Merge(nums1, 6, nums2, 3);

        AssertHelper.AssertArray(new int[] { -1, 0, 0, 1, 2, 2, 3, 3, 3 }, nums1);
    }

    [TestMethod]
    public void MergeTest_Nums1Empty()
    {
        var nums1 = new int[] { 0, 0, 0 };
        var nums2 = new int[] { 2, 5, 6 };

        var solution = new Problem_88_MergeSortedArray();
        solution.Merge(nums1, 0, nums2, 3);
        AssertHelper.AssertArray(new int[] { 2, 5, 6 }, nums1);
    }

    [TestMethod]
    public void MergeTest_Nums2Empty()
    {
        var nums1 = new int[] { 1, 2, 3, 0, 0, 0 };
        var nums2 = new int[] { };

        var solution = new Problem_88_MergeSortedArray();
        solution.Merge(nums1, 3, nums2, 0);
        AssertHelper.AssertArray(new int[] { 1, 2, 3, 0, 0, 0 }, nums1);
    }


}