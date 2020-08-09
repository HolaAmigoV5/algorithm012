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

        //DFS. O(mn), O(mn)
        // for(int i=0; i<rows; i++){
        //     for(int j=0; j<cols; j++){
        //         if(grid[i][j]=='1'){
        //             count++;
        //             DFS(grid, i,j);
        //         }
        //     }
        // }

        //BFS. O(mn), O(mn)
        for(int i=0; i<rows; i++){
            for(int j=0; j<cols; j++){
                if(grid[i][j]=='1'){
                    count++;
                    Queue<int[]> queue=new Queue<int[]>();
                    queue.Enqueue(new int[]{i,j});
                    while(queue.Any()){
                        var p=queue.Dequeue();
                        for(int k=0; k<4; k++){
                            var newx=p[0]+directions[k,0];
                            var newy=p[1]+directions[k,1];
                            if(IsLand(grid, newx, newy)){
                                grid[newx][newy]='0';
                                queue.Enqueue(new int[]{newx, newy});
                            }
                        }
                    }
                }
            }
        }
        return count;
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
}
// @lc code=end

