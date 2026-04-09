public class Solution {
    public bool hasDuplicate(int[] nums) 
    {
        HashSet<int> Duplicate =  new HashSet<int>();
        for(int i=0;i<nums.Length;i++)
        {
            if(!Duplicate.Contains(nums[i]))
            {
                Duplicate.Add(nums[i]);
            }
            else 
            {
                return true;
            }
        }
        return false;
        
    }
}