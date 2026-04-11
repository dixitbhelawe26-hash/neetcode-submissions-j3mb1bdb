public class Solution {
    public int[] TopKFrequent(int[] nums, int k) 
    {
            Dictionary<int, int> IntFre = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (IntFre.ContainsKey(nums[i]))
                {
                    IntFre[nums[i]]++;
                }
                else
                {
                    IntFre.Add(nums[i], 1);
                }
            }
            var sorted = IntFre.OrderByDescending(x => x.Value).ToArray();
            var topk = sorted.Take(k).Select(x => x.Key).ToArray();
            return topk;
    }
}
