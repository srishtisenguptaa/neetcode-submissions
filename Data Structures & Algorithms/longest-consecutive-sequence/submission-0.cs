public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> set = new HashSet<int>(nums);
        int longest = 0;

        foreach (int num in set) {
           
            if (!set.Contains(num - 1)) {
                int current = num;
                int streak = 1;

                while (set.Contains(current + 1)) {
                    current++;
                    streak++;
                }

                longest = Math.Max(longest, streak);
            }
        }

        return longest;
    }
}