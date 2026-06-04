public class Solution {
    public int MissingNumber(int[] nums) {
        int n= nums.Length;
        int expected = n*(n+1)/2;
        int actual =0;
        foreach(int num in nums)
        actual+=num;

        return expected-actual;
    }
}
