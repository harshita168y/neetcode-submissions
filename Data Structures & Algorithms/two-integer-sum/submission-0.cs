public class Solution {
    public int[] TwoSum(int[] nums, int target) {
      Dictionary<int, int> dct = new Dictionary<int, int>();
      for(int i =0; i<nums.Length; i++){
        int needed = target - nums[i];
        if(dct.ContainsKey(needed)){
            return new int[] {dct[needed], i};
        }
        dct[nums[i]] = i;
      }
    return new int[] {};
    }
}
