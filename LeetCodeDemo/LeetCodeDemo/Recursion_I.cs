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
#if 迭代 
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
#endif

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

            return head;
        }

        /// <summary>
        ///  斐波那契数
        /// </summary>
        /// <param name="N"></param>
        /// <returns></returns>
        public int Fib(int N)
        {
#if 递归
            if (N == 1 || N == 2)
            {
                return 1;
            }
            return Fib(N - 1) + Fib(N - 2);
#endif


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

            return 0;
        }


        /// <summary>
        /// 爬楼梯   需要 n 阶你才能到达楼顶。  每次你可以爬 1 或 2 个台阶。你有多少种不同的方法可以爬到楼顶呢？  
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns> 
        public int ClimbStairs(int n)
        {

            return 0;
        }
        #region Exterior API
        #endregion
    }
}
