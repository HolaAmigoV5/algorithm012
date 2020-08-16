/*
 * @lc app=leetcode.cn id=322 lang=csharp
 *
 * [322] 零钱兑换
 */

// @lc code=start
public class Solution {
    Dictionary<int, int> map=new Dictionary<int, int>();
    int ans=int.MaxValue;
    public int CoinChange(int[] coins, int amount) {
        //Iteration. from bottom to top
        // var dp=new int[amount+1];
        // Array.Fill(dp, amount+1);
        // dp[0]=0;
        // for(int i=0; i<dp.Length; i++){
        //     foreach (int coin in coins)
        //     {
        //         if(i-coin<0)
        //             continue;
        //         dp[i]=Math.Min(dp[i], dp[i-coin]+1);
        //     }
        // }
        // return (dp[amount]==amount+1)?-1:dp[amount];

        //Recursion. from top to bottom.
        if(amount==0)
            return 0;
        if(amount<0)
            return -1;
            
        if(map.ContainsKey(amount))
            return map[amount];

        int res=int.MaxValue;
        foreach(var coin in coins){
            int subproblem=CoinChange(coins, amount-coin);
            if(subproblem==-1)
                continue;
            res=Math.Min(res, 1+subproblem);
        }
        map[amount]=res==int.MaxValue?-1:res;
        return res;

        //Recursion2
        // if(amount<1)
        //     return 0;
        // return Helper(coins, amount, new int[amount]);

        // Array.Sort(coins);
        // CoinChangeHelper(coins.Length-1, coins, 0, amount);
        // return ans==int.MaxValue?-1:ans;
    }

    private int Helper(int[] coins, int rem, int[] count){
        if(rem<0)
            return -1;  //not valid
        if(rem==0)
            return 0;  //completed
        if(count[rem-1]!=0)
            return count[rem-1];    //already computed, so reuse.
        
        int min=int.MaxValue;
        foreach(var coin in coins){
            int res=Helper(coins, rem-coin,count);
            if(res==-1)
                continue;
            min=Math.Min(min, 1+res);
        }
        //note the result
        count[rem-1]=(min==int.MaxValue)?-1:min;
        return count[rem-1];
    }

    private void CoinChangeHelper(int index, int[] coins, int count, int needAmount){
        if(needAmount==0){
            ans=Math.Min(count,ans);
            return;
        }
        if(index<0)
            return;
        int i=needAmount/coins[index];
        for(int k=i; k>=0 && count+k<ans;k--)
            CoinChangeHelper(index-1, coins, count+k, needAmount-k*coins[index]);
    }
}
// @lc code=end

