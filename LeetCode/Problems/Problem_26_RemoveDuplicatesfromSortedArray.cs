namespace LeetCode;

public class Problem_26_RemoveDuplicatesfromSortedArray
{
    public int RemoveDuplicates(int[] nums) 
    {
        if(nums.Length <= 1) return nums.Length;
        
        int index = 0;
        int last_value = nums[index];
        
        for(int i = 0; i < nums.Length; i++)
        {
            if(nums[i] == last_value) continue;
            
            nums[++index] = nums[i];
            last_value = nums[index];
        }
        
        return index + 1;
    }
}