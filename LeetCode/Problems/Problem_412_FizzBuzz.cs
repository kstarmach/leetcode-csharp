namespace LeetCode;

public class Problem_412_FizzBuzz
{
    public IList<string> FizzBuzz(int n)
    {
        List<string> result = new List<string>();

        for (int i = 1; i <= n; i++)
        {
            string str = string.Empty;

            if (i % 3 == 0)
            {
                str += "Fizz";
            }

            if (i % 5 == 0)
            {
                str += "Buzz";
            }

            if (string.IsNullOrEmpty(str))
            {
                str = i.ToString();
            }

            result.Add(str);
        }

        return result;
    }
}