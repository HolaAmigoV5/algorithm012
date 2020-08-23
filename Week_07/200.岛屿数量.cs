/*
 * @lc app=leetcode.cn id=200 lang=csharp
 *
 * [200] 岛屿数量
 */

// @lc code=start
public class Solution {
    int rows=0, cols=0;
    public int NumIslands(char[][] grid) {
        if(grid==null || grid.Length==0)
            return 0;
        
        rows=grid.Length;
        cols=grid[0].Length;
        int count=0;

        for(int i=0; i<rows; i++){
            for(int j=0; j<cols; j++){
                if(grid[i][j]=='1'){
                    // count++;
                    // DFSSearchLands(grid, i,j);

                    //BFS
                    count++;
                    grid[i][j]='0';
                    var queue=new Queue<int[]>();
                    queue.Enqueue(new int[]{i,j});
                    while(queue.Any()){
                        var p=queue.Dequeue();
                        //grid[p[0]][p[1]]='0';
                        for(int k=0; k<4; k++){
                            int newX=p[0]+(k==1?1:k==3?-1:0);
                            int newY=p[1]+(k==0?1:k==2?-1:0);
                            if(IsValid(grid,newX, newY)){
                                queue.Enqueue(new int[]{newX, newY});
                                grid[newX][newY]='0';
                            }
                                
                        }
                    }
                }
            }
        } 
        return count;
    }

    private bool IsValid(char[][] grid, int x, int y){
        return (x>=0 && x<rows && y>=0 && y<cols && grid[x][y]=='1');
    }

    private void DFSSearchLands(char[][] grid, int x, int y){
        if(x<0 || x>=rows || y<0 || y>=cols || grid[x][y]=='0')
            return;
        grid[x][y]='0';
        for(int i=0; i<4; i++)
            DFSSearchLands(grid, x+(i==1?1:i==3?-1:0), y+(i==0?1:i==2?-1:0));
    }
}
// @lc code=end

