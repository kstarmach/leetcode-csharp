namespace LeetCode.Test;

[TestClass]
public class Test_412_FizzBuzz
{
    [TestMethod]
    public void FizzBuzz_Test1()
    {
        var solution = new Problem_412_FizzBuzz();

        var result = solution.FizzBuzz(3);
        AssertHelper.AssertList(new string[] { "1", "2", "Fizz" }, result);
    }

    [TestMethod]
    public void FizzBuzz_Test2()
    {
        var solution = new Problem_412_FizzBuzz();

        var result = solution.FizzBuzz(5);
        AssertHelper.AssertList(new string[] { "1", "2", "Fizz", "4", "Buzz" }, result);
    }

    [TestMethod]
    public void FizzBuzz_Test3()
    {
        var solution = new Problem_412_FizzBuzz();

        var result = solution.FizzBuzz(15);
        AssertHelper.AssertList(new string[] { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" }, result);
    }
}