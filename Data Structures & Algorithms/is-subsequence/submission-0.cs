public class Solution
{
    public bool IsSubsequence(string s, string t)
    {
        int left = 0;

        foreach (char c in t)
        {
            if (left < s.Length && s[left] == c)
            {
                left++;
            }

            if (left == s.Length)
            {
                return true;
            }
        }

        return false;
    }
}