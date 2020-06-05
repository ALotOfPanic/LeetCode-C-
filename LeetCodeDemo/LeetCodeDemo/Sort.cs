using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeDemo
{
    public static class Sort
    {
        #region 插入排序
        public static void InsertSort(int[] arr, bool sort)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {

                }
            }
        }
        #endregion

        #region 选择排序
        public static void ChooseSort(int[] arr, bool sort)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {

                }
            }
        }
        #endregion

        #region 冒泡排序
        public static void BubbleSort(int[] arr, bool sort)
        {
            int temp = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }
        #endregion

        #region 希尔排序
        public static void ShellSort(int[] arr, bool sort)
        {

        }
        #endregion

        #region 堆排序
        public static void HeapSort(int[] arr, bool sort)
        {

        }
        #endregion

        #region 快速排序  
        public static void QuickSort(int[] arr, int left, int right)
        {
            if (left >= right) return;   //两个指针重合就返回，结束调用
            int pivotIndex = QuickSort_Once(arr, left, right);  //会得到一个基准值下标
            QuickSort(arr, left, pivotIndex - 1);  //对基准的左端进行排序  递归
            QuickSort(arr, pivotIndex + 1, right);   //对基准的右端进行排序  递归
        }

        private static int QuickSort_Once(int[] arr, int left, int right)
        {
            int pivot = arr[left];   //将首元素作为基准
            int i = left;
            int j = right;
            while (i < j)
            {
                //从右到左，寻找第一个小于基准pivot的元素
                while (arr[j] >= pivot && i < j)
                {
                    //指针向前移
                    j--;
                }
                //执行到此，j已指向从右端起第一个小于基准pivot的元素，执行替换
                arr[i] = arr[j];

                //从左到右，寻找首个大于基准pivot的元素
                while (arr[i] <= pivot && i < j)
                {
                    //指针向后移
                    i++;
                } 
                arr[j] = arr[i];  //执行到此,i已指向从左端起首个大于基准pivot的元素，执行替换
            }

            //退出while循环,执行至此，必定是 i= j的情况（最后两个指针会碰头）
            //i(或j)所指向的既是基准位置，定位该趟的基准并将该基准位置返回
            arr[i] = pivot;
            return i;
        }
        #endregion

        #region 基数排序
        public static void RadixSort(int[] arr, bool sort)
        {

        }
        #endregion

        #region 桶排序
        public static void BucketSort(int[] arr, bool sort)
        {

        }
        #endregion

        #region 归并排序
        public static void MergeSort(int[] arr, bool sort)
        {

        }
        #endregion

    }
}
