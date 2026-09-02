public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length){
            return false;
        }
        Dictionary<char, int>  sb = new Dictionary<char, int>();
        Dictionary<char, int> tb = new Dictionary<char, int>();
        for(int i = 0; i< s.Length; i ++){
            if(sb.ContainsKey(s[i])){
                sb[s[i]]++;
            }
            else{
                sb.Add(s[i], 1);
            }
            if(tb.ContainsKey(t[i])){
                tb[t[i]]++;   
            }
            else{
                tb.Add(t[i],1);
            }
        }
        for(int i=0; i<s.Length; i++){
            if(!tb.ContainsKey(s[i]) || sb[s[i]]!=tb[s[i]]){
                return false;
            }
        }
        return true;

    }
}