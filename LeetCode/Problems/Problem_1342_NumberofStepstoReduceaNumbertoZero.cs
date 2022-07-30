namespace LeetCode;

public class Problem_1342_NumberofStepstoReduceaNumbertoZero
{
    public int NumberOfSteps(int num)
    {
        int count = 0;
        while (num != 0)
        {
            // all even numbers have 0 at the end so logical "and" returns 0
            if ((num & 1) == 0)
            {
                // bitwise right shift operator discards the low-order bit, making it half
                num = num >> 1;
            }
            else
            {
                num -= 1;
            }
            count++;
        }

        return count;
    }
}

