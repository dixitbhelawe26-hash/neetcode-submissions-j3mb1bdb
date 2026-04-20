public class Solution {
    public int Search(int[] nums, int target) 
    {

      int i=0;  

    while(i<nums.Length&&target!=nums[i])
    {
        i++;
    }
    if(i!=nums.Length)
    {
        return i;
    }
    return -1;
    }
}
