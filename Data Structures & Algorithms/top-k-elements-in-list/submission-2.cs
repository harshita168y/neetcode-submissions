public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int> filtering = new Dictionary<int, int>() ;
        for(int i = 0; i< nums.Length; i++){
            if(filtering.ContainsKey(nums[i])){
                filtering[nums[i]]++;
            }
            else{
                filtering[nums[i]]= 1;
            }
        }
       int[] result = nums
                    .GroupBy(n => n)
                    .OrderByDescending(g => g.Count())
                    .Take(k)
                    .Select(g => g.Key)
                    .ToArray();
        return result;
    }
}
