public class Solution {
    public int MaxProfit(int[] prices) {
       int sell = 1,buy=0,maxprofit =0 ;
       while(sell<prices.Length)
       {
        if(prices[buy]<prices[sell])
        {
            maxprofit = Math.Max(maxprofit,prices[sell]-prices[buy]);
        }
        else
            buy = sell;
        sell++;    
       }

       return maxprofit;
    }
}
