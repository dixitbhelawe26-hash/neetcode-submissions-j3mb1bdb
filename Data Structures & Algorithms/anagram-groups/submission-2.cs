public class Solution {
     public List<List<string>> GroupAnagrams(string[] strs) 
    {
        var dict = new Dictionary<string, List<string>>();

        foreach (var s in strs)
        {
            int[] count = new int[26];

            foreach (char c in s)
            {
                count[c - 'a']++;
            }

            var sb = new StringBuilder();

            foreach (int i in count)
            {
                sb.Append(i).Append('#');
            }

            string key = sb.ToString();

            if (!dict.TryGetValue(key, out var list))
            {
                list = new List<string>();
                dict[key] = list;
            }

            list.Add(s);
        }

        return dict.Values.ToList();
    }
}
