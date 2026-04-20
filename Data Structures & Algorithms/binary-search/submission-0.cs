public class Solution {
    public int Search(int[] nums, int target) 
    {
        for(int j=0;j<nums.Length;j++)
        {
           if(target == nums[j])
           {
            return j;
           }


        }
        return -1;
        
    }
}
