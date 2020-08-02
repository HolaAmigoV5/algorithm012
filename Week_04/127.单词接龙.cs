/*
 * @lc app=leetcode.cn id=127 lang=csharp
 *
 * [127] 单词接龙
 */

// @lc code=start
public class Solution {
    public int LadderLength(string beginWord, string endWord, IList<string> wordList) {
        //O(mn), O(mn)
        if(wordList.Count==0|| !wordList.Contains(endWord))
            return 0;

        //BFS
        Queue<string> queue=new Queue<string>();
        bool[] visited=new bool[wordList.Count];
        int idx=wordList.IndexOf(beginWord);
        if(idx!=-1)
            visited[idx]=true;
        queue.Enqueue(beginWord);

        int count=0;
        while(queue.Any()){
            int size=queue.Count;
            count++;
            while(size-->0){
                string start=queue.Dequeue();
                for(int i=0; i<wordList.Count; i++){
                    if(visited[i])
                        continue;
                    string str=wordList[i];
                    if(!CanConvert(start, str))
                        continue;
                    if(str.Equals(endWord))
                        return count+1;
                    visited[i]=true;
                    queue.Enqueue(str);
                }
            }
        }
        return 0;
    }

    private bool CanConvert(string s1, string s2){
        int count=0;
        for(int i=0; i<s1.Length; i++){
            if(s1[i]!=s2[i]){
                count++;
                if(count>1)
                    return false;
            }
        }
        return count==1;
    }
}
// @lc code=end

