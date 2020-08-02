/*
 * @lc app=leetcode.cn id=122 lang=csharp
 *
 * [122] 买卖股票的最佳时机 II
 */

// @lc code=start
public class Solution {
    public int MaxProfit(int[] prices) {
        //O(n), O(1)
        int len=prices.Length;
        if(len<2)
            return 0;
        // for(int i=0; i<len-1; i++){
        //     int diff=prices[i+1]-prices[i];
        //     if(diff>0)
        //         res+=diff;
        // }
        // return res;

        // int[] cash=new int[len];
        // int[] hold=new int[len];
        // cash[0]=0;
        // hold[0]=-prices[0];

        // for(int i=1; i<len; i++){
        //     cash[i]=Math.Max(cash[i-1], hold[i-1]+prices[i]);
        //     hold[i]=Math.Max(hold[i-1], cash[i-1]-prices[i]);
        // }
        // return cash[len-1];

        //O(n), O(1)
        // int cash=0;
        // int hold=-prices[0];
        // int preCash=cash;
        // int preHold=hold;
        // for(int i=1; i<len; i++){
        //     cash=Math.Max(preCash, preHold+prices[i]);
        //     hold=Math.Max(preHold, preCash-prices[i]);

        //     preCash=cash;
        //     preHold=hold;
        // }
        // return cash;

        // int profit=0;
        // for(int i=1; i<prices.Length; i++){
        //     profit+=Math.Max(prices[i]-prices[i-1],0);
        // }
        // return profit;

        //O(n), O(1)
        int i=0, buy, sell, profit=0, N=prices.Length-1;
        while(i<N){
            while(i<N && prices[i+1]<=prices[i]){
                i++;
            }
            buy=prices[i];
            while(i<N && prices[i+1]>prices[i]){
                i++;
            }
            sell=prices[i];

            profit+=sell-buy;
        }
        return profit;

    }
}
// @lc code=end

