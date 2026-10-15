public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> num = new HashSet<int>();

        if (nums.Length == 0) {
            return 0;
        }

        int max = 0;

        for (int i = 0; i < nums.Length; i++) {
            num.Add(nums[i]);
        }

        foreach (int i in num) {
            if (!num.Contains(i - 1)) {
                int current = i;
                int length = 1;

                while (num.Contains(current + 1)) {
                    current++;
                    length++;
                }

                max = Math.Max(max, length);
            }
        }

        return max;
    }
}