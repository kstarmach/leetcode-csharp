namespace LeetCode.Test;

[TestClass]
public class Test_1342_NumberofStepstoReduceaNumbertoZero
{
    [TestMethod]
    public void NumberofStepstoReduceaNumbertoZero_Test()
    {
        var solution = new Problem_1342_NumberofStepstoReduceaNumbertoZero();

        var result = solution.NumberOfSteps(14);
        Assert.AreEqual(6, result);

        result = solution.NumberOfSteps(8);
        Assert.AreEqual(4, result);

        result = solution.NumberOfSteps(123);
        Assert.AreEqual(12, result);
    }
}