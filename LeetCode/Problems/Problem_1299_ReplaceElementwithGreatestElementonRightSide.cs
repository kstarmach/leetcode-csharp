namespace LeetCode;

public class Problem_1299_ReplaceElementwithGreatestElementonRightSide
{
    public int[] ReplaceElements(int[] arr)
    {
        if (arr == null || arr.Length == 0) return null;

        int max = -1;
        int[] result = new int[arr.Length];
        result[arr.Length - 1] = max;

        for (int i = arr.Length - 1; i > 0; i--)
        {
            if (arr[i] > max) max = arr[i];

            result[i - 1] = max;
        }

        return result;
    }
}