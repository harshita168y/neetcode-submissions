public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int [] output = new int[nums.Length];
        int pre = 1;
        int post =1;
        for(int i =0; i< nums.Length; i++){
            output[i] = pre;
            pre *= nums[i];
        }
        for(int i = nums.Length-1; i>=0; i--){
            output[i] *= post;
            post *= nums[i];
        }
        return output;
    }
}
