namespace LeetCode;

public class Problem_941_ValidMountainArray
{
    public bool ValidMountainArray(int[] arr)
    {
        if (arr.Length < 3 || arr == null) return false;

        if (arr[0] > arr[1])
            return false;
            
        bool isPeak = false;

        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] == arr[i + 1])
                return false;

            if (isPeak)
            {
                if (arr[i] < arr[i + 1]) return false;
            }
            else
            {
                if (arr[i] > arr[i + 1])
                {
                    isPeak = true;
                }
            }
        }
        return isPeak;
    }
}