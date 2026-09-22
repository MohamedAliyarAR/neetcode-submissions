public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
    
        var dict = new Dictionary<int,int>();

        foreach(var n in nums){
            dict[n] = dict.GetValueOrDefault(n,0)+1;
        }

        return  dict.OrderByDescending(i=>i.Value).Select(kvp=>kvp.Key).Take(k).ToArray();

    }
}
