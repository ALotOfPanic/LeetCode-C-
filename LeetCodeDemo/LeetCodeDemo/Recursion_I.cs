using System;
using System.Collections.Generic;
using static LeetCodeDemo.ExteriorStruct;

namespace LeetCodeDemo
{
    public class Recursion_I
    {
        /// <summary>
        /// 反转字符串
        /// 
        /// 输入：["h","e","l","l","o"] 
        /// 输出：["o","l","l","e","h"]
        /// </summary>
        /// <param name="s"></param>
        public void ReverseString(char[] s)
        {
            if (s == null)
            {
                return;
            }
            int endInt = 0;
            if (s.Length % 2 == 1)
            {
                endInt = 1;
            }
            ReverseString(s, 0, s.Length - 1, endInt);
        }
        private void ReverseString(char[] s, int left, int right, int endInt)
        {
            if (right - left <= endInt)
            {
                return;
            }
            char temp = s[right];
            s[right] = s[left];
            s[left] = temp;
            ReverseString(s, left + 1, right - 1, endInt);
        }

        /// <summary>
        /// 杨辉三角 I   给定一个非负整数 numRows，生成杨辉三角的前 numRows 行。
        /// </summary>
        /// <param name="numRows"></param>
        /// <returns></returns>
        public IList<IList<int>> Generate(int numRows)
        {
            IList<IList<int>> result = new List<IList<int>>();
            for (int i = 0; i < numRows; i++)
            {
                IList<int> row = new List<int>();
                if (i == 0)
                {
                    row.Add(1);
                    result.Add(row);
                    continue;
                }
                if (i == 1)
                {
                    row.Add(1);
                    row.Add(1);
                    result.Add(row);
                    continue;
                }
                for (int j = 0; j <= i; j++)
                {
                    if (j == 0 || j == i)
                    {
                        row.Add(1);
                    }
                    else
                    {
                        IList<int> tempRow = result[i - 1];
                        int temp = tempRow[j - 1] + tempRow[j];
                        row.Add(temp);
                    }
                }
                result.Add(row);
            }
            return result;
        }
        /// <summary>
        /// 杨辉三角 II      给定一个非负索引 k，其中 k ≤ 33，返回杨辉三角的第 k 行。
        /// 获取杨辉三角的指定行   直接使用组合公式C(n, i) = n!/(i!*(n-i)!)   则第(i+1)项是第i项的倍数=(n-i)/(i+1); 
        /// </summary>
        /// <param name="rowIndex"></param>
        /// <returns></returns>
        public IList<int> GetRow(int rowIndex)
        {
            List<int> result = new List<int>();
            for (int i = 0; i <= rowIndex; i++)
            {
                result[i] = 1;
                for (int j = i; j > 1; j--)
                    result[j - 1] = result[j - 2] + result[j - 1];
            }
            return result;
        }

        /// <summary>
        /// 给定一个链表，两两交换其中相邻的节点，并返回交换后的链表。 你不能只是单纯的改变节点内部的值，而是需要实际的进行节点交换。
        /// 给定 1->2->3->4, 你应该返回 2->1->4->3.
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public ListNode SwapPairs(ListNode head)
        {
            if (head.next == null || head == null)
            {
                return head;
            }
            ListNode next = head.next;
            head.next = SwapPairs(next.next);
            next.next = head;
            return next;
        }
        /// <summary>
        /// 反转一个单链表。
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public ListNode ReverseList(ListNode head)
        {
            ListNode prev = null;
            ListNode curr = head;
            while (curr != null)
            {
                ListNode temp = curr.next;
                curr.next = prev;
                prev = curr;
                curr = temp;
            }
            return prev;

#if 递归
            if (head == null || head.next == null)
            {
                return head;
            }
            ListNode p = ReverseList(head.next);
            head.next.next = head;
            head.next = null;
            return p;
#endif


        }

        /// <summary>
        ///  斐波那契数
        /// </summary>
        /// <param name="N"></param>
        /// <returns></returns>
        public int Fib(int N)
        {
            if (N == 1 || N == 2)
            {
                return 1;
            }
            return Fib(N - 1) + Fib(N - 2);
#if 遍历
            int[] sum = new int[N];
            sum[0] = 1;
            sum[1] = 1;
            for (int i = 2; i < N; i++)
            {
                sum[i] = sum[i - 1] + sum[i - 2];
            }
            return sum[N - 1]; 
#endif
        }


        /// <summary>
        /// 爬楼梯   需要 n 阶你才能到达楼顶。  每次你可以爬 1 或 2 个台阶。你有多少种不同的方法可以爬到楼顶呢？  
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns> 
        public int ClimbStairs(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            int[] dp = new int[n + 1];
            dp[1] = 1;
            dp[2] = 2;
            for (int i = 3; i <= n; i++)
            {
                dp[i] = dp[i - 1] + dp[i - 2];
            }
            return dp[n];
#if 暴力搜索
            return climb_Stairs(0, n);
            private int climb_Stairs(int i, int n)
            {
                if (i > n)
                {
                    return 0;
                }
                if (i == n)
                {
                    return 1;
                }
                return climb_Stairs(i + 1, n) + climb_Stairs(i + 2, n);
            }
#endif
        }
        /// <summary>
        /// 二叉树的最大深度
        /// 给定一个二叉树，找出其最大深度。 二叉树的深度为根节点到最远叶子节点的最长路径上的节点数。
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public int MaxDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            int leftDeep = 1, rightDeep = 1;
            if (root.left != null)
            {
                leftDeep = MaxDepth(root.left) + 1;
            }
            if (root.right != null)
            {
                rightDeep = MaxDepth(root.right) + 1;
            }
            return Math.Max(leftDeep, rightDeep);

#if way1
            int deep = 0;
            if (root == null)
            {
                return deep;
            }
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                deep++;
                int size = queue.Count;
                for (int i = 0; i < size; i++)
                {
                    var node = queue.Dequeue();
                    if (node.left != null)
                    {
                        queue.Enqueue(node.left);
                    }
                    if (node.right != null)
                    {
                        queue.Enqueue(node.right);
                    }
                }
            }
            return deep; 
#endif

        }

        /// <summary>
        /// Pow(x, n)
        /// 实现 pow(x, n) ，即计算 x 的 n 次幂函数。
        /// </summary>
        /// <param name="x"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public double MyPow(double x, int n)
        {
            if (x == 0) { return 0; }
            if (n == 0) { return 1; }
            if (n == -1) { return 1 / x; }
            double temp = MyPow(x, (int)Math.Floor((decimal)n / 2));
            if (n % 2 == 0)
            {
                return temp * temp;
            }
            else
            {
                return temp * temp * x;
            }
        }

        /// <summary>
        /// 合并两个有序链表  
        /// 两个升序链表合并为一个新的升序链表并返回。新链表是通过拼接给定的两个链表的所有节点组成的。 
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <returns></returns>
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
#if 迭代
            ListNode prehead = new ListNode(-1); 
            ListNode prev = prehead;
            while (l1 != null && l2 != null)
            {
                if (l1.val <= l2.val)
                {
                    prev.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    prev.next = l2;
                    l2 = l2.next;
                }
                prev = prev.next;
            }
            prev.next = l1 ?? l2;
            return prehead.next;
#endif 
            if (l1 == null)
            {
                return l2;
            }
            else if (l2 == null)
            {
                return l1;
            }
            else if (l1.val < l2.val)
            {

                l1.next = MergeTwoLists(l1.next, l2);
                return l1;
            }
            else
            {
                l2.next = MergeTwoLists(l1, l2.next);
                return l2;
            }
        }
        /// <summary>
        /// 第K个语法符号
        /// 在第一行我们写上一个 0。接下来的每一行，将前一行中的0替换为01，1替换为10
        /// 输入: N = 1, K = 1  输出: 0   结果：0
        ///  
        /// 输入: N = 2, K = 1  输出: 0   结果：01 
        ///  
        /// 输入: N = 3, K = 2  输出: 1  结果：0110
        /// 
        /// 输入: N = 4, K = 5  输出: 1  结果：01101001
        /// </summary>
        /// <param name="N"></param>
        /// <param name="K"></param>
        /// <returns></returns>
        public int KthGrammar(int N, int K)
        {
            if (N == 1) return 0;
            return (~K & 1) ^ KthGrammar(N - 1, (K + 1) / 2);
        }


        /// <summary>
        /// 不同的二叉搜索树 II
        /// 给定一个整数 n，生成所有由 1 ... n 为节点所组成的二叉搜索树。
        /// 输入: 3
        /// //输出:
        ///[
        ///  [1,null,3,2],
        ///  [3,2,null,1],
        ///  [3,1,null,null,2],
        ///  [2,1,3],
        ///  [1,null,2,null,3]
        ///]
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public List<TreeNode> generateTrees(int n)
        {
            return null;
        } 
        #region Exterior API
        #endregion
    }
}
