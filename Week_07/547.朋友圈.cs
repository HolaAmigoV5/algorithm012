/*
 * @lc app=leetcode.cn id=547 lang=csharp
 *
 * [547] 朋友圈
 */

// @lc code=start
public class Solution {
    public int FindCircleNum(int[][] M)
    {
        int len = M.Length;
        UnionFind uf = new UnionFind(len);
        for (int i = 0; i < len; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (M[i][j] == 1)
                    uf.Union(i, j);
            }
        }
        return uf.Count();
    }

    class UnionFind
    {
        private int count;
        private int[] parent;
        private int[] size;

        public UnionFind(int n)
        {
            this.count = n;
            parent = new int[n];
            size = new int[n];
            for (int i = 0; i < n; i++)
            {
                parent[i] = i;
                size[i] = 1;
            }
        }

        public void Union(int p, int q)
        {
            int rootP = Find(p);
            int rootQ = Find(q);
            if (rootP == rootQ)
                return;

            if (size[rootP] > size[rootQ])
            {
                parent[rootQ] = rootP;
                size[rootP] += size[rootQ];
            }
            else
            {
                parent[rootP] = rootQ;
                size[rootQ] += size[rootP];
            }
            count--;
        }

        public bool Connected(int p, int q)
        {
            int rootP = Find(p);
            int rootQ = Find(q);
            return rootP == rootQ;
        }

        public int Find(int x)
        {
            while (parent[x] != x)
            {
                parent[x] = parent[parent[x]];
                x = parent[x];
            }
            return x;
        }

        public int Count()
        {
            return count;
        }
    }
}
// @lc code=end

