public class Solution {
    public bool IsAnagram(string s, string t) {
        
        if(s.Length>t.Length)return false;

        int[] arr = new int[26];

        foreach(char i in s){
            arr[i-97]++;
        }
        foreach(char i in t){
            arr[i-97]--;
        }
        foreach(int i in arr){
            if(i!=0){
                return false;
            }
        }

        return true;

    }
}
