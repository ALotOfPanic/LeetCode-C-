using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 初始化类
            Recursion_I recursion_I = new Recursion_I();
            BinarySearch binarySearch = new BinarySearch();
            N_aryTree n_AryTree = new N_aryTree();
            ArraysAndStrings arraysAndStrings = new ArraysAndStrings();
            QueueAndStack queueAndStack = new QueueAndStack();
            Linked linked = new Linked();
            #endregion


            #region  测试方法区域 
            //Random random;
            //int[] thousandData = new int[1 * 1000];
            //for (int i = 0; i < thousandData.Length; i++)
            //{
            //    random = new Random(GetRandomSeed());
            //    thousandData[i] = random.Next(1, 3000);
            //}
            //int[] tenThousandData = new int[100 * 100];
            //for (int i = 0; i < tenThousandData.Length; i++)
            //{
            //    random = new Random(GetRandomSeed());
            //    tenThousandData[i] = random.Next(1, 3000);
            //}
            //int[] millionData = new int[100 * 100 * 100];
            //for (int i = 0; i < millionData.Length; i++)
            //{
            //    random = new Random(GetRandomSeed());
            //    millionData[i] = random.Next(1, 3000);
            //}
            //int[] billionData = new int[100 * 100 * 1000];
            //for (int i = 0; i < billionData.Length; i++)
            //{
            //    random = new Random(GetRandomSeed());
            //    billionData[i] = random.Next(1, 3000);
            //} 
            //Stopwatch watch = new Stopwatch();
            //watch.Start();
            //Sort.QuickSort(thousandData, 0, thousandData.Length - 1);
            //Console.WriteLine("thousand用时(毫秒)：" + watch.Elapsed);

            //Sort.QuickSort(tenThousandData, 0, tenThousandData.Length - 1);
            //Console.WriteLine("tenThousand用时(毫秒)：" + watch.Elapsed);

            //watch.Restart();
            //Sort.QuickSort(millionData, 0, millionData.Length - 1);
            //Console.WriteLine("million用时(毫秒)：" + watch.Elapsed);

            //watch.Restart();
            //Sort.QuickSort(billionData, 0, millionData.Length - 1);
            //Console.WriteLine("billion用时(毫秒)：" + watch.Elapsed);

            //string s = "  hello world!  ";
            //string s = "the sky is a blue";
            //arraysAndStrings.ReverseEachWords(s);

            //int[] numbers = new int[] { 2, 7, 11, 15 };
            //int twoSumResult = arraysAndStrings.ArrayPairSum(numbers);

            //int s = 4; int[] nums = { 1, 4, 4 };
            //int result = arraysAndStrings.MinSubArrayLen(s, nums);

            int[][] nums = new int[][]{
               new int[]{ 1, 2, 3},
               new int[]{ 4, 5, 6},
               new int[]{ 7, 8, 9},
            };
            //1，2，5，9，6，3，4，7，10，13，14，11，8，12，15，16
            var x = arraysAndStrings.FindDiagonalOrder(nums);
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    Console.Write(nums[i][j]);
                }
                Console.WriteLine("\t");
            }
            //int[][] nums = new int[][]{
            //    new int[] {1,3},
            //    new int[] {2,6},
            //    new int[] { 8, 12 },
            //    new int[] { 10, 18 }
            //};
            //var x=arraysAndStrings.Merge(nums);
            //string strs = "babad";
            //string str = arraysAndStrings.LongestPalindrome(strs);
            Console.ReadKey();




            #endregion
        }
        static int GetRandomSeed()
        {
            byte[] bytes = new byte[4];
            System.Security.Cryptography.RNGCryptoServiceProvider rng = new System.Security.Cryptography.RNGCryptoServiceProvider();
            rng.GetBytes(bytes);
            return BitConverter.ToInt32(bytes, 0);
        }
    }

}