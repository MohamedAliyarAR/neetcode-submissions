public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        Dictionary<int,int> dict = new Dictionary<int,int>();
        
        for(int i = 0;i<nums.Length;i++){

            if(dict.TryGetValue(target-nums[i],out int value)){
                return new int[2]{value,i};
            }
            else 
            dict[nums[i]]  = i;

        }

        return new int[2];

    }
}
