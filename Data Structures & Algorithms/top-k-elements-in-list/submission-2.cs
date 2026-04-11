public class Solution {
    public int[] TopKFrequent(int[] nums, int k) 
    {
        Dictionary<int, int> freq = new();

    foreach (int num in nums)
        freq[num] = freq.GetValueOrDefault(num, 0) + 1;

    List<int>[] buckets = new List<int>[nums.Length + 1];

    foreach (var kv in freq)
    {
        int count = kv.Value;
        if (buckets[count] == null)
            buckets[count] = new List<int>();

        buckets[count].Add(kv.Key);
    }

    List<int> result = new();

    for (int i = buckets.Length - 1; i >= 0 && result.Count < k; i--)
    {
        if (buckets[i] != null)
            result.AddRange(buckets[i]);
    }

    return result.Take(k).ToArray();
    }
}
