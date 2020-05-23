using System;
using System.Collections.Generic;
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
            
            char[] chars = { 'A', ' ', 'm', 'a', 'n', ',', ' ', 'a', ' ', 'p', 'l', 'a', 'n', ',', ' ', 'a', ' ', 'c', 'a', 'n', 'a', 'l', ':', ' ', 'P', 'a', 'n', 'a', 'm', 'a' };
            recursion_I.ReverseString(chars);

            #endregion

            Console.ReadKey();
             
        }
    }

}
