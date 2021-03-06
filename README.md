# 算法训练营

## 总结脑图

![algorithm](https://github.com/HolaAmigoV5/Images/raw/master/数据结构和算法2.png)

> 完整原图下载地址：https://github.com/HolaAmigoV5/Images

## 第一周

### 如何高效学习

* 不死磕，敢于死记硬背，看国际版高票回答，刷题5遍
* **精通一个领域方法**
  * Chunk it up 切碎知识点：eg ：reddit (ask me anything) ElonMusk 
  * Deliberate Practicing 刻意练习：5遍刷题法，对于薄弱点5+次练习。eg：小女孩练习乒乓球
  * Feedback 反馈 
    * 主动式反馈（自己去找）：看高手代码，吸收高手的招式
    * 被动式反馈（高手指点）：Code Review，老师指导
* **刷题技巧**
  * 切题四件套：① Clarification ② Possible solutions ③ Coding  ④ Test Cases
  * 5遍刷题法：
    * 第一遍：5-10分钟读题+思考，看最优解法，背诵和默写解法
    * 第二遍：自己写代码，LeetCode提交通过
    * 第三遍：24小时候，再写一遍
    * 第四遍：一周后再练习相同的题目
    * 第五遍：面前前一个星期，恢复练习

### 总览

#### 数据结构

* 一维
  * 基础：数组array(string)，链表 linked list
  * 高级：栈 stack，队列 queue，双端队列 deque，集合 set，映射 map(has or map)，etc
* 二维
  * 基础：树 tree，图 graph
  * 高级：二叉搜索树 binary search tree(red-black tree, AVL)，堆 heap，并查集 disjoint set ，字典树Trie
* 特殊
  * 位运算 Bitwise，布隆过滤器 BloomFilter
  * LRU Cache

#### 算法

* 跳转：if-else, swith —— branch
* 循环：for, while loop —— iteration
* 递归：Recursion(Divide & Conquer, Backtrace)
* 搜索：Search，深度优先搜索 Depth first search，广度优先搜索 Breadth first search，A*，etc
* 动态规划：Dynamic Programing
* 二分查找：Binary Search
* 贪心：Greedy
* 数学：Math，几何 Geometry

### 环境技巧

电脑设置

* Google
* Mac: iTerm2+ zsh(oh my zsh) 
* Windows: Microsoft new terminal
* VSCode(推荐); Java: IntelliJ; Python: Pycharm
* LeetCode plugin(VS Code& IntelliJ)
* VSCode:Themes
* Mac电脑上设置:Keyboard中的Key Repeat设置Fast，Delay Until Repeat设置Short

Code Style

* 规范写代码
* 快捷键的熟练使用
* **自顶向下编程方式：重点在前面，逻辑在后面**

### 时空复杂度

#### 时间复杂度

Big O notation

* O(1)：Constant Complexity 常数复杂度
* O(log n)：Logarithmic Complexity 对数复杂度
* O(n)：Linear Complexity 线性时间复杂度
* O(N^2)：N square Complexity 平方
* O(N^3)：N Cubic Complexity 立方
* O(2^N)：Exponential Growth 指数
* O(n!)：Factorial 阶乘

Master Theorem

​	主定理：递归中判定时间复杂度的推理方法。判定递归的时间复杂度，记住下面四种即可。

![Master Theorem](https://github.com/HolaAmigoV5/Images/raw/master/RunTime.png)

* 二分查找(Binary Search)：O(log n)
* 二叉树遍历(Binary tree traversal)：O(n)，每个节点有且访问一次，故时间复杂度为O(n)
* 最优排序矩阵查找(Optimal sorted matrix seach)：O(n)
* 归并排序(Merge sort)：O(nlog n)

#### 空间复杂度

1. 数组的长度
2. 递归的深度

### 数组、链表、跳表

数组(Array)：申请数组时，内存管理器分配一段连续的地址。访问元素时间复杂度O(1)，可以随机访问任意一个元素，访问很快。增加和删除时由于要移位，变成O(n)时间复杂度。ArrayList。时间复杂度如下：

* prepend 	    O(1)   **注意：**正常时prepend操作时间复杂度O(n)，这里在头部预留空间处理，变为O(1)复杂度
* append  		O(1)
* lookup  		  O(1)
* insert 			 O(n)
* delete  		   O(n)

链表(LinkedList)：一个Value和一个指针。单链表，双链表，循环链表 。添加和删除节点，不需要移位，时间复杂度O(1)，查询一个元素时间复杂度是O(n)，因为需要循环查找。**DotNet中提供泛型LinkedList，提供Add, Remove, Find等操作。Array.Sort()方法，在最坏的情况下，时间复杂度为O(nlogn)** 工程应用LRU Cache.时间复杂度如下：

* prepend 	    O(1)
* append  		 O(1)
* lookup  		  O(n)
* insert 			 O(1)
* delete  			O(1)

跳表(skip List)：1989年代出现，对标的是平衡树(AVL Tree)和二分查找，是一种插入/删除/搜索都是O(log n)的数据结构。最大的优势是原理简单、容易实现、方便扩展、效率更高。因此热门项目如Redis、LevelDB等用跳表替代平衡树。**注意：只能用于元素有序的情况。**现实中跳表增加和删除时，因为要维护索引，所以成本比较高。空间复杂度O(n)。工程上应用Redis。

### 栈、队列、双端队列、优先队列

栈(Stack)：先入后出容器结构；添加删除皆为O(1)，查询O(n)，因为无序，查询需要遍历。**DotNet中的栈实质内部用数组Array实现，提供Peek, Pop, Push, Contains, Clone, ToArray等操作。提供泛型和非泛型两种Stack**  

队列(Queue)：先进先出容器结构；添加删除皆为O(1)，查询O(n)，因为无序，查询需要遍历。**DotNet中Queue有泛型和非泛型两种，实际内部依然使用Array实现，提供Dequeue，Enqueue，Peek等操作。**

双端队列(Deque: Double-End Queue)：实际使用较多，实际就是栈和队列的结合体，本质还是一个队列，只是可以在这个队列前端和尾端进行Push和Pop操作。插入和删除都是O(1)，因为无序需遍历，查询还是O(n)。**DotNet提供泛型Deque，内部数组实现，提供EnqueueTail，DequeueHead， DequeueTail操作**

优先队列(Priority Queue)：插入O(1)；取出操作O(log n)，按照元素优先级取出。底层具体实现的数据结构较为多样和复杂(heap，bst，treap)

## 第二周

### 哈希表、映射、集合

​	哈希表(Hash table)，也叫散列表，根据关键码值(key value)而直接进行访问的数据结构。它通过把关键码值映射到表中一个位置来访问记录，以加快查找的速度。这个映射函数叫做散列函数(Hash Function)，存放记录的数组叫做哈希表。**实质是通过哈希函数把值映射到一个位置(index)。查询，添加和删除都是O(1)。**  可能会出现哈希碰撞。

​	DotNet中，hashtable内部实现依靠一个叫**private struct bucket（成员有key, val, hash_coll）的数组(private bucket[] buckets)**维护。由于会出现装箱或拆箱等耗时操作，**微软建议使用Dictionary<Tkey, TValue>泛型**替代hashtable使用。Dictionary<Tkey, TValue>内部实现依靠一个叫**private struct Entry(成员有next, key, value)的数组实现 。提供Add, Clear, ContainsKey, ContainsValue等方法。通过拉链法解决哈希冲突** 哈希函数是**GetHashCode()** 。

**Dictionary<Tkey,TValue>实现原理分析：**

* Add操作：① 通过key计算hashCode；② 对hashCode取余运算，计算该hashCode落在哪个buckets桶中(例如buckets[2])；③ 将hashCode，key，value等信息存入entries[index]中；④ 将entries[index]中的index赋值为对应下标的bucket，如buckets[2]=index；⑤ 最后version++。**只有增加，替换和删除才会version++，version用于保证遍历Dictionary时，又改变Dictionary时能及时抛出异常**
* Resize操作(扩容)
  * 扩容的两种情况：① buckets，entries两个数组满了会扩容； ② Dictionary发生碰撞次数太多，会严重影响性能，也会触发扩容。HashCollisionThreshold=100。
  * 扩容步骤：① buckets, entries翻倍 ② 元素拷贝到新entries ③ Hash碰撞扩容时，用新哈希函数重写计算Hash值 ④对entries每个元素确定新buckets位置 ⑤ 重建hash链。

### 树、二叉搜索树

​	链表(Linked List)是特殊化的树(Tree)，树(Tree)是特殊化的图(Graph)。链表生枝即是树，树中套环变成图。二叉树的遍历：① 前序(pre-order)：根-左-右； ②中序(In-order)：左-根-右；③ 后序(Post-order)：左-右-根

**二叉搜索树** 

​	二叉搜索树，也称二叉排序树、有序二叉树(Ordered Binary Tree)、排序二叉树(Sorted Binary Tree)，查询，插入，删除都是O(logn)，指一棵空树或者具有下列性质的二叉树：

1. 左子树上**所有节点** 的值均小于它的根节点的值；
  2. 右子树上**所有节点** 的值均大于它的根节点的值；
  3. 以此类推：左，右子树也分别为二叉搜索树（这就是重复性！）

中序遍历：升序排序。

### 堆、二叉堆

​	堆(Heap)：可以迅速找到一堆数中最大或最小的数据结构。将根节点最大的堆叫做大顶堆或大根堆，根节点最小的堆叫小顶堆或小根堆。常见的堆有二叉堆、斐波那契堆，严格斐波那契堆(性能最好)等。

假设是大顶堆，常见操作(API)：

1. find-max: O(1)
2. delete-max: O(logN)
3. insert(create): O(logN) or O(1)

二叉堆性质：通过完全二叉树来实现（注意：不是二叉搜索树）；二叉堆(大顶)它满足的性质(① 是一棵完全树，② 树中任意节点的值总是>=其子节点的值)。**二叉堆实现相对容易，时间复杂度刚刚及格** 

二叉堆实现细节

1. 二叉堆一般通过“数组”来实现
2. 根节点是a[0]；索引为i的左孩子索引是(2\*i+1)，索引为i的右孩子索引是(2\*i+2)，索引为i的父节点索引floor((i-1)2)。

Insert 插入操作—O(logN)

1. 新元素一律先插入到堆的尾部
2. 依次向上调整整个堆的结构(一直到根即可)——HeapifyUp

Delete Max 删除堆顶操作——O(logN)

1. 将堆尾元素替换到顶部（即堆顶被替代删除掉）
2. 依次从根部向下调整整个堆的结构(一直到堆尾即可)——heapifyDown

### 图的实现和特性

​	图的属性：Graph(V,E)

* V-vertex 点

  1. 度-入度和出度
  2. 点与点之间：连通与否

* E-edge 边

  1. 有向和无向(单行线)
  2. 权重(边长)

  **无向图中搜索最短路径，首先想到广度优先遍历**

## 第三周

### 泛型递归、树的递归

递归(Recursion)：本质是循环，通过循环体进行的循环。一层层下，一层层回来。

1. recursion terminator 递归终结
2. process logic in current level 处理当前层逻辑
3. drill down 下探下层
4. reverse the current level status if needed.  清理当前层

代码模板(Java)：

```java
// Java
public void recursion(int level, int param) { 
  // terminator 
  if (level > MAX_LEVEL) { 
    // process result 
    return; 
  }
  // process current logic 
  process(level, param); 
  // drill down 
  recursion( level: level + 1, newParam); 
  // restore current status 
}
```

**思维要点：** 

1. 不要人肉进行递归（最大误区）
2. 找到最近最简方法，拆解成可重复解决的问题（重复子问题）
3. 数学归纳法思维

### 分治、回溯

分治：问题拆机成小问题处理后，组合结果后返回。

回溯：也叫“回溯搜索”算法，主要用于在一个庞大的空间搜索我们需要问题的解。解决一个回溯问题，实际就是一个决策树的遍历过程。

1. 路径：已经做出的选择。
2. 选择列表：当前可以做的选择。
3. 结束条件：到达决策树底层，无法再做选择的条件。

```java
//回溯算法框架
result = []
def backtrack(路径, 选择列表):
    if 满足结束条件:
        result.add(路径)
        return
    
    for 选择 in 选择列表:
        做选择
        backtrack(路径, 选择列表)
        撤销选择
```

回溯算法框架：**核心是for循环里面的递归，在递归调用之前【做选择】，递归调用后【撤销选择】。写backtrack函数时，需要维护走过的【路径】和当前可以走的【选择列表】，当触发【结束条件】时，将【路径】记入结果集中。**



## 第四周

### 深度优先

​	深度优先：Depth First Search，是一种`递归遍历算法`，其逻辑就是分别递归遍历节点的子节点，直到一个节点为空或者被访问过，其遍历的顺序和树的先序遍历相同，代码模板和递归的代码模板也十分相似。DFS也有一种非递归写法，即把递归的模式拆解为使用Stack记录每次遍历的内容存入stack，其实现类似于BFS。

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
void dfs(int[][] grid, int r, int c) {
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



### 广度优先

​	广度优先：Breadth First Search，应用于层序遍历和最短路径等问题处理。实际就是用Queue来处理下钻逻辑。代码模板如下：

```c#
private void BFS(Node node) {
    var queue = new Queue<Node>();
    queue.Enqueue(node);
    while (queue.Any()) {
        var cur = queue.Dequeue();
        // 处理逻辑
        visited.Add(cur);
        // ...

        // 将后续的节点存入queue中
        foreach(var child in cur.Children) {
            queue.Enqueue(child);
        } 
    }
}
```



### 贪心算法

​	贪心算法(Greedy)：**在每一步选择中都采取在当前状态下最好或最优的选择**，从而希望导致结果是全局最好或最优的算法。和动态规划不同在于它对每个子问题的解决方案都做出选择，不能回退。动态规划则会保存以前的运算结果，并根据以前的结果对当前进行选择，有回退功能。**贪心：当下做局部最优判断；回溯：能够回退； 动态规划：最优判断+回退**



### 二分查找

​	二分查找：每次查找中间值，然后依次左右移动收缩，最终可以把O(n)的算法优化到O(logn)，但对应的限制就是数组需要`单调性`。

**数组的二分查找：① 数组单调递增或递减少 ②数组nums[left]<=nums[mid]或者nums[mid]<nums[right]，当nums[mid]=nums[right]时，仅当数组只有一个元素，此时left=mid=right=0**

**注意越界：** 当两个int数字无限接近Int.MaxValue时，两个int数`相加`或者`相乘`时肯定越界，此时可以将int数转变为long或者double类型，然后继续后面操作即可。

二分查找的前提：① 目标函数单调性 ② 存在上下界(bounded) ③ 能够通过索引访问(index accessible)。代码模板如下：

```c#
public int search(int[] nums, int target) {
    int lo = 0, hi = nums.length - 1, mid = 0;
    while (lo <= hi) {
        mid = lo + ((hi - lo) >> 1);
        if (nums[mid] == target) {
            return mid;
        }
        if (nums[mid] < target) {
            lo = mid + 1;  //左加右减
        } else {
            hi = mid - 1;
        }
    }
    return -1;
}
```

## 第六周

### 动态规划

#### 相关概念

​	动态规划(Dynamic Programming)=分治+剪枝，用递归实现。动态规划的一般形式就是**求最值**，比如求最长递增子序列，最小编辑距离等。求解动态规划的**核心问题是穷举**，因为要求最值，肯定要吧所有可能的答案穷举出来，然后在其中找最值。因为这类问题存在**重叠子问题**，如果暴力穷举的话，效率低下，所以需要**备忘录**或者**DP table**来优化穷举过程，避免不必要的计算。动态规划一定会具备**最优子结构**，才能通过子问题的最值得到原问题的最值。动态规划的核心思想是穷举求最值，但是问题可以千变万化，穷举所有可行解其实并不是一件容易的事，只有列出正确的**状态转移方程**才能正确的穷举。

**解题思路：** ①确定base case， ②分解子问题， ③归纳DP方程， ④ 迭代/递归，⑤剪枝

**解题思路2：** ①确定状态(确定数组含义)， ②转移方程， ③边界和初始， ④ 计算顺序(已知推出未知)

**三要素 ：** ①重叠子问题 ② 最优子结构 ③ 状态转移方程(DP方程)。

- **重叠子问题：** 很多时候动态规划的穷举存在很多重叠，比如斐波那契树中，存在大量的重复计算。此时就需要剪枝，实现每个子问题不再重叠。

- **最优子结构：** 分解的子问题必须相互独立，互不影响。所有独立的子问题就是最优子结构。

- **状态转移方程（DP方程）** ：如下图的斐波那契数列，f(n)相当于`状态n`，这个n是由`状态n-1`和`状态n-2`相加转移而来，这就叫状态转移。

![fib](https://github.com/HolaAmigoV5/Images/raw/master/fib.png)

​	

>如何思考状态转移方程：**明确 base case ­­­­­­­­→ 明确「状态」→ 明确「选择」 → 定义 dp 数组/函数的含义**

```java
# 初始化 base case
dp[0][0][...] = base
# 进行状态转移
for 状态1 in 状态1的所有取值：
    for 状态2 in 状态2的所有取值：
        for ...
            dp[状态1][状态2][...] = 求最值(选择1，选择2...)
```

> **状态压缩** ：如果我们发现每次状态转移只需要DP table中的一部分，那么可以尝试用状态压缩来缩小DP table的大小，只记录必要的数据。一般来说是把一个二维的DP table压缩成一维，即把空间复杂度从O(n²)压缩到O(n)。比如斐波那契的状态只和之前的两个状态相关，不需要用一个数组DP table来存储所有的状态只要想办法存储之前的两个状态就行了。	

> PS：但凡遇到需要递归的问题，最好都画出递归树，这对你分析算法的复杂度，寻找算法低效的原因都有巨大帮助。递归算法的时间复杂度=子问题个数×子问题需要的时间。迭代是自底向上，递归是自顶向下。

#### 例题分析

​	凑领钱问题：给你 `k` 种面值的硬币，面值分别为 `c1, c2 ... ck`，每种硬币的数量无限，再给一个总金额 `amount`，问你**最少**需要几枚硬币凑出这个金额，如果不可能凑出，算法返回 -1 。

1. 确定base case：目标金额`amount`为0时，算法返回0，因为不需要任何硬币就已经凑出目标金额了；

2. 分解子问题：求凑11块钱最少需要几枚硬币，只需要知道凑10元最少需要几枚硬币+1(1个硬币，这个硬币可能是1元，2元或5元)即可，不断递推到base case（凑0元最少需要0枚硬币）；

3. 归纳DP方程：由简单到一般，归纳总结出DP方程（参考"如何列出状态转移方程"）；

4. 迭代/递归：使用迭代（自底向上）或者递归（自顶向下）方式确定写代码思路；

   <img src="https://github.com/HolaAmigoV5/Images/raw/master/coinchange1.png" style="zoom:70%;" />

5. 剪枝：对于重复进行删除。通过**备忘录**或者**dp数组**消除重复。

**如何列出状态转移方程：** 

1. **确定 base case：** 目标金额`amount`为0时，算法返回0，因为不需要任何硬币就已经凑出目标金额了。

2. **确定「状态」：** 即原问题和子问题中会变化的变量。目标金额会不断地向base case靠近，所以唯一的「状态」就是目标金额`amount`。

3. **确定「选择」：** 即导致「状态」产生变化的行为。所以硬币的面值，就是你的「选择」

4. **明确 `dp`函数/数组的定义：** 递归解题时需要一个递归的dp函数，一般来说函数的参数就是状态转移中会变化的量，也就是上面说到的「选择」；函数的返回值就是题目要求我们计算的量。就凑领钱来说，**`dp(n)`的定义：输入一个目标金额`n`，返回凑出目标金额`n`的最少硬币数量**。迭代解题时需要明确dp数组的定义，把「状态」也就是目标金额作为变量，不过`dp函数`体现在函数参数，而`dp数组`体现在数组索引。就凑领钱来说，**dp数组的定义：当目标金额为i时，至少需要dp[i]枚硬币凑出**。

   <img src="https://github.com/HolaAmigoV5/Images/raw/master/coinchange.png" alt="coinchange" style="zoom:70%;" />

   **凑硬币解法：**

   1. 暴力解法：

      ```c++
      def coinChange(coins: List[int], amount: int):
      
          def dp(n):
              # base case
              if n == 0: return 0
              if n < 0: return -1
              # 求最小值，所以初始化为正无穷
              res = float('INF')
              for coin in coins:
                  subproblem = dp(n - coin)
                  # 子问题无解，跳过
                  if subproblem == -1: continue
                  res = min(res, 1 + subproblem)
      
              return res if res != float('INF') else -1
      
          return dp(amount)
      ```

      

   2. 递归解法（带备忘录， dp函数）：

      ```c++
      def coinChange(coins: List[int], amount: int):
          # 备忘录
          memo = dict()
          def dp(n):
              # 查备忘录，避免重复计算
              if n in memo: return memo[n]
              # base case
              if n == 0: return 0
              if n < 0: return -1
              res = float('INF')
              for coin in coins:
                  subproblem = dp(n - coin)
                  if subproblem == -1: continue
                  res = min(res, 1 + subproblem)
      
              # 记入备忘录
              memo[n] = res if res != float('INF') else -1
              return memo[n]
      
          return dp(amount)
      ```

      

   3. 迭代解法（带dp table, dp数组）：

      ```c++
      int coinChange(vector<int>& coins, int amount) {
          // 数组大小为 amount + 1，初始值也为 amount + 1
          vector<int> dp(amount + 1, amount + 1);
          // base case
          dp[0] = 0;
          // 外层 for 循环在遍历所有状态的所有取值
          for (int i = 0; i < dp.size(); i++) {
              // 内层 for 循环在求所有选择的最小值
              for (int coin : coins) {
                  // 子问题无解，跳过
                  if (i - coin < 0) continue;
                  dp[i] = min(dp[i], 1 + dp[i - coin]);
              }
          }
          return (dp[amount] == amount + 1) ? -1 : dp[amount];
      }
      ```

   

   ​	**解决两个字符串的动态规划问题，一般都是用两个指针** **`i,j`** **分别指向两个字符串的最后，然后一步步往前走，缩小问题的规模**。

## 第七周

### 字典树

​	字典树， 即Trie树，又称单词查找树或键树，是一种树形结构。典型应用是用于统计和排序大量的字符串（但不限于字符串），所以经常被搜索引擎系统应用于文本词频统计。它的优点是最大限度地减少无谓的字符串比较，查询效率比哈希表高。字典树的核心思想是空间换时间。利用字符串的公共前缀来降低查询时间的开销以达到提高效率的目的。

基本性质：

1. 结点本身不存完整单词
2. 从根结点到某一个结点，路径上经过的字符串连接起来，为该结点对应的字符串。
3. 每个结点的所有子结点路径代表的字符都不相同。

字典树代码模板：

```c#
public class Trie
{
    public Trie[] Next;
    public bool IsEnd;
    public string Word;

    /* Initialize your data structure here. */
    public Trie(){
        IsEnd = false;
        Next = new Trie[26];
    }

    /* Inserts a word into the trie. */
    public void Insert(string word){
        if (string.IsNullOrEmpty(word))
            return;

        Trie node = this;
        foreach (var ch in word){
            int index = ch - 'a';
            if (node.Next[index] == null)
                node.Next[index] = new Trie();
            node = node.Next[index];
        }
        node.IsEnd = true;
        node.Word = word;
    }

    /* Returns if the word is in the trie. */
    public bool Search(string word){
        Trie node = SearchPrefix(word);
        return node != null && node.IsEnd;
    }
    
	/* Returns if there is any word in the trie that starts with the given prefix. */
    public bool StartsWith(string prefix){
        Trie node = SearchPrefix(prefix);
        return node != null;
    }

    private Trie SearchPrefix(string word){
        Trie node = this;
        foreach(var ch in word){
            node = node.Next[ch - 'a'];
            if (node == null)
                return null;
        }
        return node;
    }

    public bool IsLeaf(){
        foreach (Trie sub in this.Next){
            if (sub != null)
                return false;
        }
        return true;
    }
}
```



### 并查集

​	并查集（Disjoint Set），用于处理组团和配对问题。

基本操作

1. makeSet(s):建立一个新的并查集，其中包含s个单元集合
2. unionSet(x,y)：把元素x和元素y所在集合合并，要求x和y所在的集合不相交，如果相交则不合并。
3. find(x)：找到元素x所在集合的代表，该操作也可以用于判断两个元素是否位于同一个集合，只要将它们各自代表比较一下就可以了。

并查集代码模板：

```c#
Class UnionFind{
    private int count=0;
    private int[] parent;
    public UnionFind(int n){
        count=n;
        parent=new int[n];
        for(int i=1; i<n; i++){
            parent[i]=i;
        }
    }
    
    public int Find(int p){
        while(p!=parent[p]){
            parent[p]=parent[parent[p]];
            p=parent[p];
        }
        return p;
    }
    
    public void Union(int p, int q){
        int rootP=Find(p);
        int rootQ=Find(q);
        if(rootP==rootQ) return;
        parent[rootP]=rootQ;
        count--;
    }
}
```



### 高级搜索

#### 剪枝

​	去掉重复的分支，通过缓存或者预先判断的方式实现。

#### 双端BFS

​	BFS的扩展，从两端开始搜索，中间相遇。

代码模板：

```c#
 public int MinMutation(string start, string end, string[] bank) {
     var bankSet=new HashSet<string>(bank);
     if(start==null || end ==null || !bankSet.Contains(end))
         return -1;

     // two-ended BFS
     var beginVisited=new HashSet<string>();
     var endVisited=new HashSet<string>();
     var visited=new HashSet<string>();
     int count=0;

     beginVisited.Add(start);
     endVisited.Add(end);
     visited.Add(start);
     visited.Add(end);

     while(beginVisited.Any()){
         count++;
         //choose the smaller to visit
         if(beginVisited.Count>endVisited.Count){
             //change
             var temp=endVisited;
             endVisited=beginVisited;
             beginVisited=temp;
         }

         var nextVisited=new HashSet<string>();
         foreach(string gen in beginVisited){
             var nextGens=GetNeighbors(gen, bankSet);
             foreach(var nGen in nextGens){
                 if(endVisited.Contains(nGen))
                     return count;
                 if(!visited.Contains(nGen)){
                     nextVisited.Add(nGen);
                 }
             }
             beginVisited= nextVisited;
             visited.UnionWith(nextVisited);
         }
     }
     return -1;
  }
```



#### 启发式搜索

​	启发式搜索（Heuristic Search），又称A*算法。启发式函数，又称估价函数，h(n)用来评价哪些结点最有希望的是一个我们要找的节点，h(n)会返回一个非负实数，也可以认为是从结点n的目标结点路径的估计成本。启发式函数是一种告知搜索方向的方法。它提供了一种明智的方法来猜测哪个邻居结点会导向下一个目标。

### AVL树和红黑树

#### AVL树

1. AVL树，发明者G.M.Adelson-Velsky和Evgenii Landis。平衡二叉搜索树

  2. 平衡因子(Balance Factor)， 左子树的高度减去右子树的高度（有时想反），balance factor={-1,0,1}
  3. 通过旋转操作来进行平衡（左旋，右旋，左右旋，右左旋）
  4. 不足：结点需要存储额外信息，且调整次数频繁。

#### 红黑树

​	红黑树（Red-black Tree）,是一种**近似平衡的二叉搜索树(Binary Search Tree)**，它能够确保任何一个结点的左右子树的**高度差小于两倍**。具体来说，红黑树是满足如下条件的二叉搜索树：

1. 每个结点要么是红色，要么是黑色

  2. 根结点是黑色
  3. 每个叶结点(空节点)是黑色
  4. 不能有相邻接的两个红色节点
  5. 从任一结点到其每个叶子的所有路径都包含相同数目的黑色节点

#### 对比(重点)

1. AVL trees provide **faster lookups** than Read Black Trees because they are **more strictly balanced**.
    - AVL树查询更快，因为是严格平衡树
2. Red Black Trees provide **faster insertion and removal**  operations than AVL trees as fewer rotations are done due to relatively relaxed balancing.
    - 红黑树插入和删除更快，因为不用频繁进行旋转操作
3. AVL trees store **balance factors or heights** with each node, thus requires storage for an integer per node whereas Red Black Tree requires only 1 bit of information per node.
    - AVL树每个节点会存储平衡因子或高度，因而每个节点需要存储一个整数， 而红黑树每个节点只用1位。
4. Red Black Trees are used in most of the **language libraries** like map, multimap, multiset in C++ whereas AVL trees are used in **databases** where faster retrievals are required.
    - 红黑树在大多数语言库（例如C ++中的map，multimap，multiset）中使用，而AVL树用在需要更快检索的databases 中使用。

## 第八周

### 位运算

**位运算符**

1. 左移(<<)：位向左移动，前面出去，后面补0
  2. 右移(>>)：位向右移动，前面补0
  3. 按位或(|)：有1或1 
  4. 按位与(&)：有0与0
  5. 按位取反(~)：1变成0，0变成1
  6. 按位异或( ^)：相同为0，不同为1。也可以理解为“不进位加法”
           	1. x^0=x
          	2. x^1s=~x    //1s为全部为1， 1s=~0
          	3. x^(~x)=1s
          	4. x^x=0
          	5. a=10, b=20, 执行交换：a=a^b, b=a^b, a=a^b;
          	6. a^c=a^(b^c)=(a^b)^c

**指定位置的位运算**

1. 将x最右边的n位清零：x&(~0<<n)
2. 获取x的第n位值(0或1)：(x>>n)&1
3. 获取x的第n位幂值：x&(1<<n)
4. 仅将第n位置为1：x|(1<<n)
5. 仅将第n位置为0：x&(~(1<<n))
6. 将x最高位至第n位(含)清零：x&((1<<n)-1)

**实战位运算要点**

- 判断奇偶：x%2\==1 —— (x&1)\==1， x%2\==0 —— （x&1）\==0
- x>>1 —— x/2 ：即x=x/2; —— x=x>>1
- x=x&(x-1) 清零最低位的1
- x=x&(-x) 得到最低位的1，并其他位设0。**0表示‘+’号(正数)，1表示'-'号(负数)。负数以原码的补码形式表示**
- x&~x  = 0
- a=10, b=20，交换a, b：执行如下：
  1. a=a^b：此时a=30
  2. b=a^b：此时b=10
  3. a=a^b：此时a=20

**基础补充**

计算机机器数真正的值称为真值。因为机器数最高位是符号位，计算真值要区分。如`10000101`不表示133， 表示-5。

原码=符号位+真值

反码：正数的反码与原码相同； 负数的反码是对其原码取反，但符号位除外

补码：正数的补码与原码相同，负数的补码等于其反码的末位加1

1. 补码运算时，其符号位与数值部分一起参加运算
2. 补码的符号位相加后，如果有进位出现，要把这个进位舍去

==**特别注意：**位运算的优先级很低(排在加减运算之后)，使用时不能忘记**括号**。==

### 布隆过滤器

​	布隆过滤器(Bloom Filter)，是一个占用空间很小，效率很高的随机数据结构。由一个很长的二进制向量(bit数组)和一系列随机映射函数(Hash算法)构成。布隆过滤器可以用于检索一个元素是否在一个集合中。优点是**空间效率和查询时间效率都远远超过一般的算法** ， 缺点是**有一定的误识别率和删除困难**。 

布隆过滤器添加元素：

- 将待添加元素给k个哈希函数进行哈希运算

- 得到对应位数组上的k个位置 

- 将这k个位置设1

布隆过滤器查询元素：

- 将要查询的元素给k个哈希函数 进行哈希运算
- 得到对应位上的k个位置 
- 如果k个位置有一个为0，则肯定不在集合中 
- 如果k个位置全部为1，则可能在集合中。

### LRU缓存

​	LRU缓存(Least recently used cache)，最少最近被使用的元素会被淘汰。大小和替换策略，使用Hash Table+Double LinkedList实现，能在O(1)的时间复杂度实现查询，修改和更新。

### 排序算法

比较类排序：通过比较来决定元素的相对次序，由于其时间复杂度不能突破O(nlogn)，因此也称为非线性时间比较类排序。

非比较类排序：不通过比较来决定元素间的相对次序，它可以突破基于比较排序的时间下界，以线性时间运行，因此也称为线性时间比较类排序。

**初级排序——O(n^2)**

1. 选择排序(Selection Sort)，每次找最小值，然后放到待排序数组的起始位置。代码如下

   ```c#
   public int[] SelectionSort(int[] arr){
       int len=arr.Length;
       for(int i=0; i<len-1; i++){
           int minIndex=i;
           for(int j=i+1; j<len; j++){
               if(arr[j]<arr[minIndex])
                   minIndex=j;
           }
           int tmp=arr[i];
           arr[i]=arr[minIndex];
           arr[minIndex]=tmp;
       }
       return arr;
   }
   ```

   

2. 插入排序(Insertion Sort)，依次从未排序序列中抽取元素插入已排序序列合适位置。代码如下：

   ```c#
   public int[] InsertionSort(int[] arr){
       int len=arr.Length;
       for(int i=1; i<len; i++){
           int preIndex=i-1;
           int current=arr[i];
           while(preIndex>=0 && arr[preIndex]>current){
               arr[preIndex+1]=arr[preIndex];
               preIndex--;
           }
           arr[preIndex+1]=current;
       }
       return arr;
   }
   ```

   

3. 冒泡排序(Bubble Sort)， 嵌套循环，每次查看相邻的元素，如果逆序，则交换。代码如下：

   ```c#
   public int[] BubbleSort(int[] arr){
   	int len=arr.Length;
   	for(int i=0; i<len-1; i++){
           int isSort=true;
   		for(int j=0; j=len-i-1; j++){
   			if(arr[j]>arr[j+1]){
   				var tmp=arr[j+1];
   				arr[j+1]=arr[j];
   				arr[j]=tmp;
                   isSort=false;
   			}
   		}
           if(isSort)
               break;
   	}
   	return arr;
   }
   ```

   

**高级排序——O(N*logN)——重点，手写，原理**

1. 快速排序(Quick Sort)，数组取标杆pivot，将小元素放pivot左边，大元素放右边，然后依次对左边和右边的子数组继续快排，以达到整个序列有序。代码如下：

   ```c#
   public void QuickSort(int[] arr, int beginIndex, int endIndex){
       if(endIndex<=beginIndex) return;
       int pivotIndex=Partition(arr, beginIndex, endIndex);
       QuickSort(arr, beginIndex, pivotIndex-1);
       QuickSort(arr, pivotIndex+1, endIndex);
   }
   private int Partition(int[] arr, int begin, int end){
       int pivot=end, counter=begin;
       for(int i=begin; i< end; i++){
           if(arr[i]<arr[pivot]){
               Swap(arr, i, counter);
               counter++;
           }
       }
       Swap(arr, pivot，counter);
       return counter;
   }
   private void Swap(int[] arr, int i, in j){
       if(i==j) return;
       var tmp=arr[i];
       arr[i]=arr[j];
       arr[j]=tmp;
   }
   ```

   

2. 归并排序(Merge Sort)，①不断把长度为n的序列分成两个长度为n/2的子序列 ②对这个子序列分别采用归并排序 ③将两个排序好的子序列合并成一个最终的排序序列——先分后合——分治。代码如下：

   ```c#
   public void MergeSort(int[] arr, int left, int right){
       if(left>=right) return;
       int mid=(left+right)>>1;
       
       MergeSort(arr, left, mid);
       MergeSort(arr, mid+1, right);
       Merge(arr, left, mid, right);
   }
   private void Merge(int[] arr, int left, int mid, int right){
       int[] tmp=new int[right-left+1];
       int i=left, j=mid+1, k=0;
       
       while(i<=mid && j<=right)
           tmp[k++]=arr[i]<=arr[j]?arr[i++]:arr[j++];
      	while(i<=mid)
           tmp[k++]=arr[i++];
      	while(j<=right)
           tmp[k++]=arr[j++];
       
       Array.Copy(tmp,0,arr,left, tmp.Length);
   }
   ```

   

3. 堆排序(Heap Sort)，①数组元素建立小(大)顶堆，②依次取堆顶元素并删除。代码如下：

   ```C#
   public void HeapSort(int[] arr){
       int len=arr.Length;
       if(len==0) return;
       
       //build Heap
       //begin to adjust from the last root at the bottom.
       for(int i=len/2-1; i>=0; i--)
           Heapify(arr,i,len);
       
       for(int i=len-1; i>=0; i--){
           //Exchange the top element with the last one.
           Swap(arr,i,0);
           Heapify(arr,0,i);
       }
   }
   private void Heapify(int[] arr, int i, int len){
       int left=2*i+1;
       int right 2*i+2;
       int largest=i;
       
       if(left<len && arr[left]>arr[largest])
           largest=left;
       if(right<len && arr[right]>arr[largest])
           largest=right;
       //the largest one changed.
       if(largest!=i){ 
           Swap(arr, i, largest);
           Heapify(arr, largest, len);
       }
   }
   ```

   堆插入O(logn)， 取最小/大值 O(1)。

**特殊排序——O(n)**

1. 计数排序(Counting Sort)，计数排序要求输入的数据必须是有确定范围的整数。将输入的数据值转为键存储在额外开辟的数组空间中，然后依次把计数大于1的填充回数组。
2. 桶排序(Bucket Sort)，假设输入数据服从均匀分布，将数据分到有限数量的通里，每个桶再分别排序（有可能再使用别的排序算法或以递归方式继续使用桶排序进行排）。
3. 基数排序(Radix Sort)，基数排序是按照低位先排序，然后收集； 再按高位排序，然后再收集； 依次类推，直到最高位。有时候有些属性是有优先级顺序的，先按低优先级排序，再按高优先级排序。

## 第九周

### 高级动态规划

1. 复杂问题分解
2. 最优子结构
3. 状态顺推

### 字符串算法

​	C#中字符串是不可变的，每次操作字符串都会生成新的字符串。C#中字符串比较“\==”和Equals是一样，对于值类型，两者没有区别，对于引用类型来说，“\==”比较的是引用地址，Equals比较的是内容。

**字符串匹配算法**(了解原理)

1. Rabin-Karp算法，暴力算法基础上，进行哈希运算。将目标字符串(长度N)txt中子串(长度M)pat，全部哈希运算，比较哈希值，如果值不同，肯定不匹配，如果相同还需要使用朴素算法再次判断。——类似布隆过滤器。
2. KMP算法(Knuth-Morris-Pratt)，最长公共前后缀个数+字母=前缀表。通过前缀表进行匹配。
3. Boyer-Moore算法：各种编辑器查找功能大多采用此算法。德克萨斯大学的Robert S. Boyer教授和J Strother Moore教授发明了这种算法。
4. Sunday算法



## 有用代码

```c#
for (int j = 0; j < zeronum; j++)
    nums[j] = 0;
for(int i=zeronum-1; i>=0; i--)
    nums[i]=0;

//等效上面
while (zeronum-- > 0)
    nums[zeronum] = 0;

//数组中查询指定元素的索引
Array.IndexOf<int>(nums, target);
Array.Sort(nums);
Array.ForEach(nums, k => Console.Write(k));
nums.GroupBy(i=>i).OrderBy(i=>i.Count()).Take(k).Select(i=>i.Key);

//求众数
nums.GroupBy(i=>i).OrderBy(i=>i.Count()).Select(i=>i.Key).Last();

//使用指定value填充数组
int[] dp=new int[amount+1];
Array.Fill(dp, amount+1);
Array.Reverse(chars); //反转字符数组
string.Join(" ", chars); //数组拼接成字符串

//斐波拉契公式
double sqrt_5 = Math.Sqrt(5);
    double fib_n = Math.Pow((1 + sqrt_5) / 2, n) - Math.Pow((1 - sqrt_5) / 2, n);
    return (int)(fib_n / sqrt_5);

//数根
int root = 1 + ((num - 1) % 9);

//顺序截取字符串，生成子串
 for(int i=0; i<s.Length; i++){
     for(int j=i; j<s.Length; j++){
         var ss=s.Substring(i,j+1-i)
     }
 }

//链表问题
if(head==null || head.next==null) return head;

//将26字母映射到数组中
int[] map=new int[26];
foreach(var ch in tasks){
    map[ch-'A']++;
}

//Dictionary操作
dic.Values.Any(i=>i!=0);

//牛顿迭代法公式：x=(x+a/x)/2;
//1+3+5+7+......+(2n-1)=n*n 等差数列
```
