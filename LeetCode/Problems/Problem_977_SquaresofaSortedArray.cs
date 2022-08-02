namespace LeetCode;

public class Problem_977_SquaresofaSortedArray
{
    public int[] SortedSquares(int[] nums)
    {
        return nums.Select(x => x * x).OrderBy(i => i).ToArray();
    }
}