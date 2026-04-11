public class Solution {
    public int[] TopKFrequent(int[] nums, int k) 
    {

Dictionary<int, int> freq = new(); 
foreach (int num in nums) freq[num] = freq.GetValueOrDefault(num, 0) + 1;
 PriorityQueue<int, int> minHeap = new();
  foreach (var kv in freq) 
  { minHeap.Enqueue(kv.Key, kv.Value); 
  if (minHeap.Count > k) minHeap.Dequeue();
   // removes lowest frequency 
   } 
   int[] result = new int[k];
    for (int i = k - 1; i >= 0; i--)
     result[i] = minHeap.Dequeue();
      return result;
    }
}
