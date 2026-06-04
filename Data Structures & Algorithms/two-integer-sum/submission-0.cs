public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int []ans = new int [2]; 
        Dictionary <int ,int> check = new  Dictionary <int ,int> ();

        for(int i =0;i<nums.Length;i++)
        {
            int sec = target-nums[i];
            if(check.ContainsKey(sec))
            {
                ans[0]=check[sec];
                ans[1]=i;

            }
            check[nums[i]]=i;

        }
        return ans;

    }
}
