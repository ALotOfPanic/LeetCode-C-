using System;
using System.Collections.Generic;
using static LeetCodeDemo.ExteriorStruct;

namespace LeetCodeDemo
{
    public class FunctionClass
    {
        /// <summary>
        ///给定一个无序的整数数组，找到其中最长上升子序列的长度。
        ///输入: [10,9,2,5,3,7,101,18]
        ///输出: 4 
        ///解释: 最长的上升子序列是[2, 3, 7, 101]，它的长度是 4。 
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int LengthOfLis(int[] nums)
        {
            int len = nums.Length;
            if (nums.Length < 2) return len;
            int[] resultArr = new int[len];
            for (var a = 0; a < len; a++)
            {
                resultArr[a] = 1;
            }
            for (var i = 1; i < len; i++)
            {
                for (var j = i; j < i; j++)
                {
                    if (nums[j] < nums[i])
                    {
                        resultArr[i] = Math.Max(resultArr[i], resultArr[j] + 1);
                    }
                }
            }
            int result = resultArr[0];
            for (int i = 0; i < len; i++)
            {
                result = Math.Max(result, resultArr[i]);
            }
            return result;
        }

        /// <summary>
        ///写下一个数字让你的朋友猜有多少位数字和确切位置都猜对了（称为“Bulls”, 公牛）有多少位数字猜对了但是位置不对（称为“Cows”, 奶牛）。
        ///请写出一个根据秘密数字和朋友的猜测数返回提示的函数，用 A 表示公牛，用 B表示奶牛。
        ///输入: secret = "1807", guess = "7810"
        ///输出: "1A3B"
        ///解释: 1 公牛和 3 奶牛。公牛是 8，奶牛是 0, 1 和 7。            
        /// </summary>
        /// <param name="secret"></param>
        /// <param name="guess"></param>
        /// <returns></returns>
        public string GetHint(string secret, string guess)
        {
            var a = 0;
            var b = 0;
            var secretDic = new Dictionary<char, int>();
            var guessDic = new Dictionary<char, int>();
            for (int i = 0; i < secret.Length; i++)
            {
                if (secret[i] == guess[i])
                {
                    a++;
                }
                else
                {
                    if (guessDic.ContainsKey(guess[i]))
                    {
                        guessDic[guess[i]] += 1;
                    }
                    else
                    {
                        guessDic.Add(guess[i], i);
                    }
                    if (secretDic.ContainsKey(secret[i]))
                    {
                        secretDic[guess[i]] += 1;
                    }
                    else
                    {
                        secretDic.Add(secret[i], i);
                    }
                }
            }
            foreach (char key in secretDic.Keys)
            {
                if (guessDic.ContainsKey(key))
                {
                    guessDic[key] -= 1;
                    b++;
                }
            }
            return a + "A" + b + "B";
        }

        ///  <summary>
        /// 删除最小数量的无效括号，使得输入的字符串有效，返回所有可能的结果。说明: 输入可能包含了除(和)以外的字符。
        /// 输入: "()())()"
        /// 输出: ["()()()", "(())()"] 
        /// 输入: "(a)())()"
        /// 输出: ["(a)()()", "(a())()"]
        ///  </summary>
        ///  <returns></returns>
        public IList<string> RemoveInvalidParentheses(string str)
        {
            List<string> resultList = new List<string>();
            return resultList;
        }

        /// <summary>
        /// 给定一个没有重复数字的序列，返回其所有可能的全排列。
        /// 输入: [1,2,3]
        /// 输出:[[1,2,3],[1,3,2],[2,1,3],[2,3,1],[3,1,2],[3,2,1]
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public List<List<int>> Permute(int[] nums)
        {
            List<List<int>> answer = new List<List<int>>();
            return answer;
        }
 

        //# 给定一个二叉树，返回所有从根节点到叶子节点的路径。
        //# 输入 [1,2,3,null,5]
        //# 输出: ["1->2->5", "1->3"]
        //# 解释: 所有根节点到叶子节点的路径为: 1->2->5, 1->3
        /**
         * Definition for a binary tree node. 
         */ 

        public IList<string> BinaryTreePaths(TreeNode root)
        {
            List<string> paths = new List<string>();
            PrintPath(root, "", paths);
            return paths;
        }

        public void PrintPath(TreeNode tree, string path, List<string> paths)
        {
            if (tree == null) return; 
            path += tree.val;
            if (tree.left == null && tree.right == null)
            {
                paths.Add(path);
            }
            else
            {
                path += "->";
                PrintPath(tree.left, path, paths);
                PrintPath(tree.right, path, paths);
            }
        }

        /// <summary>
        /// 给定一个整数数组（有正数有负数），找出总和最大的连续数列，并返回总和。
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int MaxSubArray(int[] nums)
        {
            int max = int.MaxValue, i = 0, sum= 0;
            while (i < nums.Length)
            {
                if(sum+ nums[i] < nums[i])
                {
                    sum = 0;
                }
                sum += nums[i];
                if (sum > max)
                {
                    max = sum;
                }
                i++;
            }
            return max;
        } 

    }
}
