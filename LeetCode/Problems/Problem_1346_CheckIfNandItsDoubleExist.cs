namespace LeetCode;

public class Problem_1346_CheckIfNandItsDoubleExist
{
    public bool CheckIfExist(int[] arr)
    {
        var temp = new HashSet<int>();
        foreach (var item in arr)
        {

            if (temp.Contains(2 * item))
            {
                return true;
            }

            if (item % 2 == 0 && temp.Contains(item / 2))
            {
                return true;
            }

            temp.Add(item);
        }
        return false;
    }
}