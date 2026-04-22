public class Solution {
    private Dictionary<int, int> memo = new Dictionary<int, int>();
    public int CoinChange(int[] coins, int amount) {
        // int n = coins.Length;
        // int ans = solve(coins, amount);
        // return ans==(int)1e9? -1: ans;

        int[] dp = new int[amount+1];
        Array.Fill(dp, amount+1);
        dp[0] = 0;

        for(int i = 1; i<=amount; i++)
        {
            foreach(var coin in coins)
            {
                if(coin<=i)
                {
                    int result = dp[i-coin];
                    dp[i] = Math.Min(dp[i], 1 + result);
                }
            }
        }
        return dp[amount] > amount ? -1 : dp[amount];
    }

    // int solve(int[] coins, int amount)
    // {
    //     if(amount==0) return 0;
    //     if(memo.ContainsKey(amount))
    //         return memo[amount];

    //     int res = (int)1e9;

    //     foreach(var coin in coins)
    //     {
    //         if(amount-coin >= 0)
    //         {
    //             int result = solve(coins, amount-coin);
    //             if(result!=(int)1e9)
    //                 res = Math.Min(res, 1 + result);
    //         }
    //     }
    //     return memo[amount] = res;
    // }
}
