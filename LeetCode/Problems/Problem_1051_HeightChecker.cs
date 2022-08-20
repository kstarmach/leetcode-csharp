namespace LeetCode;

public class Problem_1051_HeightChecker
{
    public int HeightChecker(int[] heights)
    {
        int[] expected = heights.OrderBy(x => x).ToArray();
        int counter = 0;

        for (int i = 0; i < heights.Length; i++)
        {
            if (heights[i] != expected[i])
            {
                heights[i] = expected[i];
                counter++;
            }
        }

        return counter;
    }
}