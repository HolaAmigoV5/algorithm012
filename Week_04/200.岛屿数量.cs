/*
 * @lc app=leetcode.cn id=200 lang=csharp
 *
 * [200] 岛屿数量
 */

// @lc code=start
public class Solution {
   int rows=0, cols=0;
    int[,] directions={{-1,0}, {0,-1}, {1,0}, {0,1}};
    public int NumIslands(char[][] grid) {
          //verification
        if(grid==null || grid.Length==0)
            return 0;
        
        rows=grid.Length;
        cols=grid[0].Length;
        int count=0;

        //M1:DFS. O(mn), O(mn)
        // for(int i=0; i<rows; i++){
        //     for(int j=0; j<cols; j++){
        //         if(grid[i][j]=='1'){
        //             count++;
        //             DFS(grid, i,j);
        //         }
        //     }
        // }

        //BFS. O(mn), O(mn)
        // Queue<int[]> queue=new Queue<int[]>();
        // for(int i=0; i<rows; i++){
        //     for(int j=0; j<cols; j++){
        //         if(grid[i][j]=='1'){
        //             count++;
        //             queue.Enqueue(new int[]{i,j});
        //             while(queue.Any()){
        //                 var p=queue.Dequeue();
        //                 for(int k=0; k<4; k++){
        //                     var newx=p[0]+directions[k,0];
        //                     var newy=p[1]+directions[k,1];
        //                     if(IsLand(grid, newx, newy)){
        //                         grid[newx][newy]='0';
        //                         queue.Enqueue(new int[]{newx, newy});
        //                     }
        //                 }
        //             }
        //         }
        //     }
        // }
        // return count;

        //M3: Disjoint set
        int[,] dir={{1,0}, {0,1}};
        int node=rows*cols;
        UnionFind uf=new UnionFind(node+1);

        for(int i=0; i<rows; i++){
            for(int j=0; j<cols; j++){
                if(grid[i][j]=='0'){
                    uf.Union(GetIndex(i,j),node);
                }
                else if(grid[i][j]=='1'){
                    for(int d=0; d<2; d++){
                        var x=i+dir[d,0];
                        var y=j+dir[d,1];
                        if(x<rows && y<cols && grid[x][y]=='1')
                            uf.Union(GetIndex(i,j), GetIndex(x,y));
                    }
                }
            }
        }
        return uf.Count()-1;
    }

    private int GetIndex(int x, int y){
        return x*cols+y;
    }

    private bool IsLand(char[][] grid, int x, int y){
        return x>=0 && x<rows && y>=0 && y<cols && grid[x][y]=='1';
    }

    private void DFS(char[][] grid, int row, int col){
        if(row<0 || row>=rows || col<0|| col>=cols || grid[row][col]=='0')
            return;
        
        grid[row][col]='0';

        for(int i=0; i<4; i++)
            DFS(grid, row+directions[i,0], col+directions[i,1]);
    }

    class UnionFind{
        int count=0;
        int[] parent;
        int[] size;

        public UnionFind(int n){
            count=n;
            parent=new int[n];
            size=new int[n];
            for(int i=0; i<n; i++){
                parent[i]=i;
                size[i]=1;
            }
        }

        public void Union(int p, int q){
            var rootP=Find(p);
            var rootQ=Find(q);
            if(rootP==rootQ)
                return;
            if(size[rootP]>size[rootQ]){
                parent[rootQ]=rootP;
                size[rootP]+=size[rootQ];
            }
            else{
                parent[rootP]=rootQ;
                size[rootQ]+=size[rootP];
            }
            count--;
        }

        public int Find(int x){
            while(parent[x]!=x){
                parent[x]=parent[parent[x]];
                x=parent[x];
            }
            return x;
        }
        public int Count(){
            return count;
        }
    }
}
// @lc code=end

