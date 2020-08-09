/*
 * @lc app=leetcode.cn id=126 lang=csharp
 *
 * [126] 单词接龙 II
 */

// @lc code=start
public class Solution
{
    List<IList<string>> res = new List<IList<string>>();
    string end = string.Empty;
    string begin = string.Empty;
    HashSet<string> wordSet = null;

    public IList<IList<string>> FindLadders(string beginWord, string endWord, IList<string> wordList)
    {
        wordSet = new HashSet<string>(wordList);
        if (wordSet.Count == 0 || !wordSet.Contains(endWord))
            return res;

        var nodeNeighbors = new Dictionary<string, List<string>>();
        var path = new List<string>();
        begin = beginWord;
        end = endWord;

        BFS(nodeNeighbors);
        DFS(begin, nodeNeighbors, path);
        return res;
    }

    private void BFS(Dictionary<string, List<string>> nodeNeighbors)
    {
        var queue = new Queue<string>();
        queue.Enqueue(begin);
        var visited = new HashSet<string>();
        var toVisited = new HashSet<string>();
        toVisited.Add(begin);
        bool isFound = false;

        while (queue.Any())
        {
            foreach (var item in toVisited)
                visited.Add(item);
            toVisited.Clear();

            int size = queue.Count;
            while (size-- > 0)
            {
                var cur = queue.Dequeue();
                if (cur.Equals(end))
                    isFound = true;
                var neighbors = GetNeighbors(cur, wordSet);
                foreach (var neighbor in neighbors)
                {
                    if (!visited.Contains(neighbor))
                    {
                        if (!nodeNeighbors.ContainsKey(cur))
                            nodeNeighbors[cur] = new List<string>();
                        nodeNeighbors[cur].Add(neighbor);

                        if (!toVisited.Contains(neighbor))
                        {
                            toVisited.Add(neighbor);
                            queue.Enqueue(neighbor);
                        }
                    }
                }
            }
            if (isFound)
                break;
        }
    }

    //DFS:output all paths with the shortest distance
    private void DFS(string cur, Dictionary<string, List<string>> nodeNeighbors,
    List<string> path)
    {
        path.Add(cur);
        if (end.Equals(cur))
            res.Add(new List<string>(path));
        else if (nodeNeighbors.ContainsKey(cur))
        {
            foreach (var next in nodeNeighbors[cur])
                DFS(next, nodeNeighbors, path);
        }
        path.RemoveAt(path.Count - 1);
    }

    private List<string> GetNeighbors(string str, HashSet<string> wordSet)
    {
        var ans = new List<string>();
        char[] chars = str.ToCharArray();
        for (int i = 0; i < str.Length; i++)
        {
            char old = str[i];
            for (char ch = 'a'; ch <= 'z'; ch++)
            {
                if (ch == old)
                    continue;
                chars[i] = ch;
                var newstr = new string(chars);
                if (wordSet.Contains(newstr))
                    ans.Add(newstr);
            }
            chars[i] = old;
        }
        return ans;
    }
}
// @lc code=end

