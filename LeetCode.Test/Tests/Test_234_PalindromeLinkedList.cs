namespace LeetCode.Test;

[TestClass]
public class Test_234_PalindromeLinkedList
{
    [TestMethod]
    public void PalindromeLinkedList_Test1()
    {
        var solution = new Problem_234_PalindromeLinkedList();

        var result = solution.IsPalindrome(TestHelper.GenerateList(new int[] { 1, 2, 2, 1 }));
        Assert.IsTrue(result);
    }


    [TestMethod]
    public void PalindromeLinkedList_Test2()
    {
        var solution = new Problem_234_PalindromeLinkedList();

        var result = solution.IsPalindrome(TestHelper.GenerateList(new int[] { 1, 2 }));
        Assert.IsFalse(result);
    }
}