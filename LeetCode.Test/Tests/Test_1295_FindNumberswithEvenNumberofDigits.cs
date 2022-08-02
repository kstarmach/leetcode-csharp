namespace LeetCode.Test;

[TestClass]
public class Test_1295_FindNumberswithEvenNumberofDigits
{
    [TestMethod]
    public void FindNumberswithEvenNumberofDigits_Test1()
    {
        var solution = new Problem_1295_FindNumberswithEvenNumberofDigits();

        var result = solution.FindNumbers(new int[] { 12, 345, 2, 6, 7896 });
        Assert.AreEqual(2, result);
    }

    [TestMethod]
    public void FindNumberswithEvenNumberofDigits_Test2()
    {
        var solution = new Problem_1295_FindNumberswithEvenNumberofDigits();

        var result = solution.FindNumbers(new int[] { 555, 901, 482, 1771 });
        Assert.AreEqual(1, result);
    }
}