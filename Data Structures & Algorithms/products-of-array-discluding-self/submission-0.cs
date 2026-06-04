public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int n = nums.Length;
        int[] ans = new int[n];

        // multiply all elements except self using two pointers
        for (int i = 0; i < n; i++) {
            int product = 1;
            for (int j = 0; j < n; j++) {
                if (i != j)
                    product *= nums[j];
            }
            ans[i] = product;
        }

        return ans;
    }
}