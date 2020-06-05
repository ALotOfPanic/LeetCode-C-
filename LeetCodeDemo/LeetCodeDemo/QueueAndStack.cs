using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeDemo
{
    public class QueueAndStack
    {
        /// <summary>
        /// 普通队列 - 实现
        /// </summary>
        class MyQueue
        {
            // store elements
            private readonly List<int> data;
            // a pointer to indicate the start position
            private int p_start;
            public MyQueue()
            {
                data = new List<int>();
                p_start = 0;
            }
            /** Insert an element into the queue. Return true if the operation is successful. */
            public bool EnQueue(int x)
            {
                data.Add(x);
                return true;
            }
            /** Delete an element from the queue. Return true if the operation is successful. */
            public bool DeQueue()
            {
                if (IsEmpty() == true)
                {
                    return false;
                }
                p_start++;
                return true;
            }
            /** Get the front item from the queue. */
            public int Front()
            {
                return data[p_start];
            }
            /** Checks whether the queue is empty or not. */
            public bool IsEmpty()
            {
                return p_start >= data.Count();
            }
        };
        /// <summary>
        /// 循环队列
        /// </summary>
        public class MyCircularQueue
        {
            private int[] data;
            private int head;
            private int tail;
            private int size;
            /** Initialize your data structure here. Set the size of the queue to be k. */
            public MyCircularQueue(int k)
            {
                data = new int[k];
                head = -1;
                tail = -1;
                size = k;
            }

            /** Insert an element into the circular queue. Return true if the operation is successful. */
            public bool EnQueue(int value)
            {
                //满了插不进
                if (IsFull())
                {
                    return false;
                }
                //如果空了  
                if (IsEmpty())
                {
                    //head 初始化
                    head = 0; 
                }
                //tail 后移
                tail = (tail + 1) % size;
                data[tail] = value;
                return true;
            }

            /** Delete an element from the circular queue. Return true if the operation is successful. */
            public bool DeQueue()
            {
                //如果空了  
                if (IsEmpty())
                {
                    return false;
                }
                //当只有一个元素时  即head == tail
                if (head == tail)
                {
                    //初始化
                    head = tail = -1;
                    return true;
                }
                head = (head + 1) % size;
                return true;
            }

            /** Get the front item from the queue. */
            public int Front()
            {
                if (IsEmpty())
                {
                    return -1;
                }
                return data[head];
            }

            /** Get the last item from the queue. */
            public int Rear()
            {
                if (IsEmpty())
                {
                    return -1;
                }
                return data[tail];
            }

            /** Checks whether the circular queue is empty or not. */
            public bool IsEmpty()
            {
                //head ==-1 为空
                return head == -1;
            }

            /** Checks whether the circular queue is full or not. */
            public bool IsFull()
            {
                //head == tail+ 为满
                return (tail + 1) % size == head;
            }
        }
        /// <summary>
        /// 岛屿数量   给你一个由 '1'（陆地）和 '0'（水）组成的的二维网格，请你计算网格中岛屿的数量。
        /// 岛屿总是被水包围，并且每座岛屿只能由水平方向或竖直方向上相邻的陆地连接形成。
        /// </summary>
        /// <param name="grid"></param>
        /// <returns></returns>
        public int WallAndDoor(char[][] grid)
        {
            int row = grid.Rank;
            Queue<char> queue = new Queue<char>();

            return -1;

        }

        /// <summary>
        /// 岛屿数量   给你一个由 '1'（陆地）和 '0'（水）组成的的二维网格，请你计算网格中岛屿的数量。
        /// 岛屿总是被水包围，并且每座岛屿只能由水平方向或竖直方向上相邻的陆地连接形成。
        /// </summary>
        /// <param name="grid"></param>
        /// <returns></returns>
        public int NumIslands(char[][] grid)
        {
            return -1;

        }

        /// <summary>
        /// 打开转盘锁
        /// 有一个带有四个圆形拨轮的转盘锁。每个拨轮都有10个数字： '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' 。每个拨轮可以自由旋转：例如把 '9' 变为  '0'，'0' 变为 '9' 。每次旋转都只能旋转一个拨轮的一位数字。
        /// 锁的初始数字为 '0000' ，一个代表四个拨轮的数字的字符串
        /// 列表 deadends 包含了一组死亡数字，一旦拨轮的数字和列表里的任何一个元素相同，这个锁将会被永久锁定，无法再被旋转。
        /// 字符串 target 代表可以解锁的数字，你需要给出最小的旋转次数，如果无论如何不能解锁，返回 -1。
        /// </summary>
        /// <param name="deadends"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int OpenLock(string[] deadends, string target)
        {

            return -1;
        }
    }
}
