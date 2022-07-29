namespace LeetCode;

public class Problem_1672_RichestCustomerWealth
{
    public int MaximumWealth(int[][] accounts)
    {
        int result = 0;

        foreach (var item in accounts)
        {
            int temp = 0;

            for (int i = 0; i < item.Length; i++)
            {
                temp += item[i];
            }

            if (temp > result)
                result = temp;
        }

        return result;
    }
}