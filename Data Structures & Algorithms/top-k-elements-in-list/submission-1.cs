public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
    
        var dict = new Dictionary<int,int>();

        foreach(var n in nums){
            dict[n] = dict.GetValueOrDefault(n,0)+1;
        }

        var queue = new PriorityQueue<int,int>();

        foreach(var (key,freq) in dict){

            queue.Enqueue(key,freq);

            if(queue.Count>k)
            queue.Dequeue();
        }

        var ans = new int[k];
        for(int i=0;i<k;i++){
            ans[i]=queue.Dequeue();
        }

        return ans;
    }
}
