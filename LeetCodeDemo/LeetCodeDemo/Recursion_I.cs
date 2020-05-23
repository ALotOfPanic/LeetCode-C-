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
        public void ReverseString(char[] s, int left, int right, int endInt)
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
        /// 给定一个链表，两两交换其中相邻的节点，并返回交换后的链表。 你不能只是单纯的改变节点内部的值，而是需要实际的进行节点交换。
        /// 给定 1->2->3->4, 你应该返回 2->1->4->3.
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public ListNode SwapPairs(ListNode head)
        {
            if (head.next == null)
            {
                return head;
            }
            ListNode secondNode = head.next;
            if (secondNode.next != null)
            {
                ListNode thirdNode = secondNode.next;
                secondNode.next = head;
                head.next = SwapPairs(thirdNode);
            }
            return head;
            
        }


        #region Exterior API
        #endregion
    }
}
