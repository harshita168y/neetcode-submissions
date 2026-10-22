public class Solution {
    public int MaxArea(int[] heights) {
       int left =0;
       int right = heights.Length -1;
       int max =0;
       while(left < right){
        int width = right - left;
        int height = Math.Min(heights[left], heights[right]);
        int area = width * height;
        max = Math.Max(max, area);

            if(heights[left] < heights[right]){
                left++;
            }
            else{
                right--;
            }
       }
       return max;
    }
}
