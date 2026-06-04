public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        // Step 1: Build frequency map
        Dictionary<int, int> freq = new Dictionary<int, int>();
        foreach (int num in nums)
            freq[num] = freq.GetValueOrDefault(num, 0) + 1;

        // Step 2: Bucket sort — index = frequency, value = list of numbers
        List<int>[] bucket = new List<int>[nums.Length + 1];
        foreach (var pair in freq) {
            int count = pair.Value;
            if (bucket[count] == null)
                bucket[count] = new List<int>();
            bucket[count].Add(pair.Key);
        }

        // Step 3: Collect top k elements from highest frequency down
        int[] result = new int[k];
        int idx = 0;
        for (int i = bucket.Length - 1; i >= 0 && idx < k; i--) {
            if (bucket[i] == null) continue;
            foreach (int num in bucket[i]) {
                result[idx++] = num;
                if (idx == k) break;
            }
        }

        return result;
    }
}