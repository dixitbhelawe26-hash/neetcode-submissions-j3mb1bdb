public class Solution {
    public bool IsPalindrome(string s) {

StringBuilder sb = new StringBuilder();

foreach (char c in s)
{
    if (char.IsLetterOrDigit(c))
    {
        sb.Append(char.ToLower(c)); // optional (useful for palindrome)
    }
}

s = sb.ToString();
int left = 0, right = s.Length - 1;

while (left < right)
{
    if (s[left] != s[right])
    {
        return false;
    }

    left++;
    right--;
}

return true;
        
    }
}
