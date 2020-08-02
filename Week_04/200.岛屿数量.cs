/*
 * @lc app=leetcode.cn id=200 lang=csharp
 *
 * [200] 岛屿数量
 */

// @lc code=start
public class Solution {
    public int NumIslands(char[][] grid) {
        if(grid==null || grid.Length==0)
            return 0;
        
        //O(mn), O(mn)
        int nr=grid.Length;
        int nc=grid[0].Length;
        int num_islands=0;
        for(int r=0; r<nr; r++){
            for(int c=0;c<nc; c++){
                if(grid[r][c]=='1'){
                    num_islands++;
                    DFS(grid,r,c);
                }
                    
            }
        }
        return num_islands++;
    }

    private void DFS(char[][] grid, int r, int c){
        int nr=grid.Length;
        int nc=grid[0].Length;

        if(r<0 || c<0 || r>=nr || c>=nc || grid[r][c]=='0')
            return;
        
        grid[r][c]='0';
        DFS(grid, r-1,c);
        DFS(grid,r+1,c);
        DFS(grid,r,c-1);
        DFS(grid,r,c+1);
    }
}
// @lc code=end

