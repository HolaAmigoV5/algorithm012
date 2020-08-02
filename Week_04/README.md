## 第四周 总结

### 搜索

#### 深度优先搜索

​	深度优先：Depth First Search。

**DFS的树结构代码：**

```java
void traverse(TreeNode root) {
    // 判断 base case
    if (root == null) {
        return;
    }
    // 访问两个相邻结点：左子结点、右子结点
    traverse(root.left);
    traverse(root.right);
}
```

**DFS网格结构代码：**

```java
oid dfs(int[][] grid, int r, int c) {
    // 判断 base case
    if (!inArea(grid, r, c)) {
        return;
    }
    // 如果这个格子不是岛屿，直接返回
    if (grid[r][c] != 1) {
        return;
    }
    grid[r][c] = 2; // 将格子标记为「已遍历过」
    
    // 访问上、下、左、右四个相邻结点
    dfs(grid, r - 1, c);
    dfs(grid, r + 1, c);
    dfs(grid, r, c - 1);
    dfs(grid, r, c + 1);
}

// 判断坐标 (r, c) 是否在网格中
boolean inArea(int[][] grid, int r, int c) {
    return 0 <= r && r < grid.length 
        	&& 0 <= c && c < grid[0].length;
}
```



#### 广度优先搜索

​	广度优先：Breadth First Search，应用于层序遍历和最短路径等问题处理

#### 贪心

​	贪心算法(Greedy)：**在每一步选择中都采取在当前状态下最好或最优的选择**，从而希望导致结果是全局最好或最优的算法。和动态规划不同在于它对每个子问题的解决方案都做出选择，不能回退。动态规划则会保存以前的运算结果，并根据以前的结果对当前进行选择，有回退功能。**贪心：当下做局部最优判断；回溯：能够回退； 动态规划：最优判断+回退**

#### 二分查找

二分查找的前提：① 目标函数单调性 ② 存在上下界(bounded) ③ 能够通过索引访问(index accessible)

### 课后刷题

| 题号 | 名称                                                         | 难度   | 分类     | 解法               |
| ---- | ------------------------------------------------------------ | ------ | -------- | ------------------ |
| 122  | [122. 买卖股票的最佳时机 II](https://leetcode-cn.com/problems/best-time-to-buy-and-sell-stock-ii/) | 🟢 简单 | 场景     | 贪心               |
| 127  | [127. 单词接龙](https://leetcode-cn.com/problems/word-ladder/) | 🟡 中等 | 图       | BFS/双向BFS 图遍历 |
| 200  | [200. 岛屿数量](https://leetcode-cn.com/problems/number-of-islands/) | 🟡 中等 | 网格问题 | DFS/BFS            |
| 455  | [455. 分发饼干](https://leetcode-cn.com/problems/assign-cookies/) | 🟢 简单 | 场景     | 最小的给最小胃口   |
| 860  | [860. 柠檬水找零](https://leetcode-cn.com/problems/lemonade-change/) | 🟢 简单 | 场景     | if...else..        |
| 874  | [874. 模拟行走机器人](https://leetcode-cn.com/problems/walking-robot-simulation/) | 🟢 简单 | 哈希     |                    |

