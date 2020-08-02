/*
 * @lc app=leetcode.cn id=874 lang=csharp
 *
 * [874] 模拟行走机器人
 */

// @lc code=start
public class Solution{
    public int RobotSim(int[] commands, int[][] obstacles){
        // 朝向，根据命令修改朝向计数
        // 北/东/南/西
        int[] dx = new int[] { 0, 1, 0, -1 };
        int[] dy = new int[] { 1, 0, -1, 0 };
        HashSet<int> obSet = new HashSet<int>();
        foreach (int[] obs in obstacles)
            obSet.Add(EncodeObs(obs[0], obs[1]));

        int x = 0, y = 0, di = 0, ans = 0;
        foreach (int cmd in commands){
            switch (cmd){
                case -2://向左转 90 度
                    di = (di + 3) % 4;
                    break;
                case -1://向右转 90 度
                    di = (di + 1) % 4;
                    break;
                default:
                    // 一步一步走，看是否碰到障碍物，遇到则停下
                    for (int i = 0; i < cmd; i++){
                        int nx = x + dx[di];
                        int ny = y + dy[di];
                        if (!obSet.Contains(EncodeObs(nx, ny))){
                            x = nx;
                            y = ny;
                            ans = Math.Max(ans, x * x + y * y);
                        }
                    }
                    break;
            }
        }
        return ans;
    }

    private int EncodeObs(int x, int y){
        return ((x + 30000) << 16) + (y + 30000);
    }
}
// @lc code=end

