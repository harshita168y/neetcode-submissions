public class Solution {
    public bool hasDuplicate(int[] nums) {
        Dictionary<int,int> n = new Dictionary<int, int>();
        for(int i =0; i< nums.Length; i++){
            if (n.ContainsKey(nums[i]))
            {
                return true;
            }
            else
            {
                n.Add(nums[i], 1);
            }
        }
        return false;
    }
}