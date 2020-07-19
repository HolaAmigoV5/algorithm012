/*
 * @lc app=leetcode.cn id=239 lang=csharp
 *
 * [239] 滑动窗口最大值
 */

// @lc code=start
public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        //Verification
        if(nums==null || nums.Length*k==0) return new int[0];
        if(k==1) return nums;

        //Violence O(nk), O(n)
        // int len=nums.Length;
        // int[] res=new int[len-k+1];
        // for(int i=0; i<res.Length; i++){
        //     int max=int.MinValue;
        //     for(int j=0; j<k; j++){
        //         max=Math.Max(max, nums[i+j]);
        //         res[i]=max;
        //     }
        // }
        // return res;

        //MonotonicQueue. O(n), O(k)
        // MonotonicQueue window=new MonotonicQueue();
        // int[] res=new int[nums.Length-k+1];
        // int index=0;
        // for(int i=0; i<nums.Length; i++){
        //     if(i<k-1){
        //         window.PushToEnd(nums[i]);
        //     }
        //     else{
        //         window.PushToEnd(nums[i]);
        //         res[index++]=window.Max;
        //         window.PopFromStart(nums[i-k+1]);
        //     }
        // }
        // return res;

        //O(n),O(n)
        int count=nums.Length-k+1;
        int[] res=new int[count];
        LinkedList<int> queue=new LinkedList<int>();
        for(int i=1-k, j=0; j<nums.Length; i++,j++){
            //Push
            while(queue.Any() && queue.Last()<nums[j])
                queue.RemoveLast();
            queue.AddLast(nums[j]);

            //Pop
            if(i>0 && queue.First()==nums[i-1])
                queue.RemoveFirst();

            //Max
            if(i>=0)
                res[i]=queue.First();
        }
        return res;
    }

        private class MonotonicQueue{
        LinkedList<int> queue;
        public MonotonicQueue()=>queue=new LinkedList<int>();
        public int Max=>queue.Max();

        //Pop a item from the start of the queue
        public void PopFromStart(int item){
            if(queue.Any() && queue.First()==item)
                queue.RemoveFirst();
        }

        //Push a item to the end of the queue
        public void PushToEnd(int item){
            while(queue.Any() && queue.Last()<item)
                queue.RemoveLast();
            queue.AddLast(item);
        }
    }
}
// @lc code=end

