namespace LeetCode;

public class Problem_1089_DuplicateZeros
{
    public void DuplicateZeros(int[] arr)
    {
        if (!arr.Contains(0))
            return;

        List<int> temp = new List<int>();

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == 0)
            {
                temp.Add(0);
                temp.Add(0);
            }
            else
            {
                temp.Add(arr[i]);
            }
        }

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = temp[i];
        }

    }
}