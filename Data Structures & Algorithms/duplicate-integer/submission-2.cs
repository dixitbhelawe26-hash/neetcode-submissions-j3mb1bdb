public class Solution {
    public bool hasDuplicate(int[] nums) 
    {
        HashSet<int> Duplicate =  new HashSet<int>();
        for(int i=0;i<nums.Length;i++)
        {
            if(!Duplicate.Add(nums[i]))
            {
                 return true;
            }
        }
        return false;
        
    }
}