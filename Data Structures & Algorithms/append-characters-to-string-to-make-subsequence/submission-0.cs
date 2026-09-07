public class Solution
{
    public int AppendCharacters(string s, string t)
    {
        int left = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if (left < t.Length && s[i] == t[left])
            {
                left++;
            }
        }

        return t.Length - left;
    }
}