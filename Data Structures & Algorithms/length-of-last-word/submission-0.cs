public class Solution {
    public int LengthOfLastWord(string s) {
        string [] arr = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int count = 0;
        count = arr[arr.Length-1].Length;
        return count;
    }
}