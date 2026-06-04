public class Solution {
    public int Rob(int[] nums) {
    if (nums.Length == 1) return nums[0];
    if (nums.Length == 2) return Math.Max(nums[0], nums[1]);

    return Math.Max(Rob(nums, 0, nums.Length - 2), 
                    Rob(nums, 1, nums.Length - 1));
}

private int Rob(int[] nums, int start, int end) {
    int prev2 = 0, prev1 = 0;

    for (int i = start; i <= end; i++) {
        int curr = Math.Max(prev1, prev2 + nums[i]);
        prev2 = prev1;
        prev1 = curr;
    }

    return prev1;
}
}
