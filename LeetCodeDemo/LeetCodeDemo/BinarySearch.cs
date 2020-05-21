using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeDemo
{
    public class BinarySearch
    {
        //给定一个 n 个元素有序的（升序）整型数组 nums 和一个目标值 target  ，写一个函数搜索 nums 中的 target，如果目标值存在返回下标，否则返回 -1。
        //输入: nums = [-1,0,3,5,9,12], target = 9
        //输出: 4
        //解释: 9 出现在 nums 中并且下标为 4
        public int Search(int[] nums, int target)
        {
            if (nums == null || nums.Length == 0)
            {
                return -1;
            }
            int left = 0, right = nums.Length - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (target == nums[mid])
                {
                    return mid;
                }
                else if (target < nums[mid])
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return -1;
        }

        //搜索旋转排序数组
        //假设按照升序排序的数组在预先未知的某个点上进行了旋转。
        //(例如，数组[0, 1, 2, 4, 5, 6, 7] 可能变为[4, 5, 6, 7, 0, 1, 2] )。
        //搜索一个给定的目标值，如果数组中存在这个目标值，则返回它的索引，否则返回 -1 。
        public int SearchRoate(int[] nums, int target)
        {
            //进行Sort 排序 并记录位置
            Dictionary<int, int> sortDic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                sortDic.Add(nums[i], i);
            }
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i; j < nums.Length; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        int temp = nums[j];
                        nums[j] = nums[i];
                        nums[i] = temp;
                    }
                }
            }
            int left = 0, right = nums.Length - 1;
            int keyIndex = -1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (target == nums[mid])
                {
                    keyIndex = target;
                    break;
                }
                else if (target < nums[mid])
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            if (sortDic.ContainsKey(keyIndex))
            {
                return sortDic[keyIndex];
            }
            return -1;
        }

        
        //输入: n = 10, pick = 6
        //输出: 6
        public int GuessNumber(int n)
        {
            int left = 0, right = n;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (Guess() == 1)
                {
                    left = mid + 1;
                }
                else if (Guess() == -1)
                {
                    right = mid - 1;
                }
                else
                {
                    return mid;
                }
            }
            return -1;
        }

        // x 的平方根
        //实现 int sqrt(int x) 函数。 计算并返回 x 的平方根，其中 x 是非负整数。
        //由于返回类型是整数，结果只保留整数的部分，小数部分将被舍去。
        public int MySqrt(int x)
        {
            if (x == 0)
            {
                return 0;
            }
            if (x == 1)
            {
                return 1;
            }
            long right = x;
            long left = 1;
            long mid = 0;
            while (left <= right)
            {
                mid = left + (right - left) / 2;
                if (mid == x / mid)
                {
                    break;
                }
                else if (mid < x / mid)
                {
                    left = mid + 1;
                }
                else
                    right = mid - 1;
            }
            if (mid > x / mid)
                return (int)mid - 1;
            else
                return (int)mid;
        }

        // 寻找旋转排序数组中的最小值
        public int FindMin(int[] nums)
        {
            return nums.Length;
        }
        /*Pow(x, n) 计算 x 的 n 次幂函数。*/
        //-100.0 < x < 100.0
        //n 是 32 位有符号整数，其数值范围是[−231, 231 − 1] 。
        public double MyPow(double x, int n)
        {
            if (x == 0) { return 0; }
            if (n == 0) { return 1; }
            if (n == -1) { return 1 / x; }
            double temp = MyPow(x, (int)Math.Floor((double)n / 2));
            if (n % 2 == 0)
            {
                return temp * temp;
            }
            else
            {
                return temp * temp * x;
            }
        }

        #region  API 提供内部API

        /** 
        * Forward declaration of guess API.
        * @param  num   your guess
        * @return 	     -1 if num is lower than the guess number
        *			      1 if num is higher than the guess number
        *               otherwise return 0
        * int guess(int num);
        */
        public int Guess()
        {
            return new Random().Next(-1, 1);
        }
        #endregion
    }
}
