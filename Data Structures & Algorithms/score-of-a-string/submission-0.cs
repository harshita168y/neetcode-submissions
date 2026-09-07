public class Solution
{
    public int ScoreOfString(string s)
    {
        char[] arr = s.ToCharArray();
        int sum = 0;

        for (int i = 0; i < arr.Length - 1; i++)
        {
            sum += Math.Abs(arr[i] - arr[i + 1]);
        }

        return sum;
    }
}