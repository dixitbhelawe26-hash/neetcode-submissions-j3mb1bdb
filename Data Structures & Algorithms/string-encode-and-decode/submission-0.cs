public class Solution {

    public string Encode(IList<string> strs) {
        string result = "";
        List<string> list = new List<string>();
        foreach(var str in strs)
        {
            int length = str.Length;
            result += length.ToString() + "#" +str;
        }

        return result;
    }

public List<string> Decode(string s) 
{
    List<string> result = new List<string>();
    int i = 0;

    while (i < s.Length)
    {
        int j = i;

        // 1. Find the delimiter '#'
        while (s[j] != '#')
        {
            j++;
        }

        // 2. Extract length
        int length = int.Parse(s.Substring(i, j - i));

        // 3. Extract the string
        string word = s.Substring(j + 1, length);
        result.Add(word);

        // 4. Move pointer to next block
        i = j + 1 + length;
    }

    return result;
}
}
