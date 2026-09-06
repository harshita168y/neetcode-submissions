public class Solution
{
    public int[] GetConcatenation(int[] nums)
    {
        int n = nums.Length;
        int[] a = new int[n * 2];

        for (int i = 0; i < n; i++)
        {
            a[i] = nums[i];
            a[i + n] = nums[i];
        }

        return a;
    }
}