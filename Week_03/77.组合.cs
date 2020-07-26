/*
 * @lc app=leetcode.cn id=77 lang=csharp
 *
 * [77] 组合
 */

// @lc code=start
public class Solution {
    List<IList<int>> res=new List<IList<int>>();
    public IList<IList<int>> Combine(int n, int k) {
        //backTracing. O(k*J). O(J). J is the count of Combine.
        if(n==0 || k==0 || n<k)
            return res;
        CombineHelper(n,k,1,new List<int>());
        return res;
    }

    private void CombineHelper(int n, int k, int start, List<int> list){
        //terminator
        if(list.Count==k){
            res.Add(new List<int>(list));
            return;
        }

        // for(int i=start; i<=n; i++){
        //     list.Add(i);
        //     CombineHelper(n,k,i+1,list);
        //     list.Remove(i);
        // }
        for(; start<=n-(k-list.Count)+1; start++){
            list.Add(start);
            CombineHelper(n,k,start+1,list);
            list.Remove(start);
        }
        // while(start<=n){
        //     list.Add(start++);
        //     CombineHelper(n,k,start,list);
        //     list.Remove(start-1);
        // }
    }

}
// @lc code=end

