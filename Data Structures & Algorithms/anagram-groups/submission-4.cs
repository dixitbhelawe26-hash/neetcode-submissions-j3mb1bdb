public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) 
    {
        int[] count; 
        Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
        foreach(string s in strs)
        {
            count = new int[26];
            foreach(char c in s)
            {
                count[c-'a']++;
            }
            StringBuilder st = new StringBuilder();
foreach(int i in count)
{
    st.Append(i);
    st.Append('#');
}
            
            if (dict.ContainsKey(st.ToString()))
            {
                dict[st.ToString()].Add(s);
            }
            else
            {
                dict[st.ToString()] = new List<string> { s };
            }  
        }
        return dict.Values.ToList();
    }
}
