public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        
        var an = new List<List<string>>();
        Dictionary<string,List<string>> resSet = new Dictionary<string,List<string>>();

        foreach(var str in strs){

            var count = new int[26];

            foreach(var ch in str)
            count[ch-'a']++;
            var ans = string.Join(",",count);
            if(!resSet.ContainsKey(ans))
            resSet[ans] = new List<string>();
            resSet[ans].Add(str);


        }

        


        return resSet.Values.ToList();
    }
}
