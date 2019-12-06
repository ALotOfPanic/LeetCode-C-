using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public int LengthOfLIS(int[] nums)
        {
            int len = nums.Length;
            if (nums.Length < 2) return len;
            int[] resultArr = new int[len];
            for (int a = 0; a < len; a++)
            {
                resultArr[a] = 1;
            }
            for (int i = 1; i < len; i++)
            {
                for (int j = i; j < i; j++)
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
            int a = 0;
            int b = 0;
            Dictionary<char, int> secretDic = new Dictionary<char, int>();
            Dictionary<char, int> guessDic = new Dictionary<char, int>();
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
            Dictionary<char, int>.KeyCollection keys = secretDic.Keys;
            foreach (char key in keys)
            {
                if (guessDic.ContainsKey(key))
                {
                    guessDic[key] -= 1;
                    b++;
                }
            }
            return a + "A" + b + "B";
        }

        /// <summary>
        ///删除最小数量的无效括号，使得输入的字符串有效，返回所有可能的结果。说明: 输入可能包含了除(和)以外的字符。
        ///输入: "()())()"
        ///输出: ["()()()", "(())()"] 
        ///输入: "(a)())()"
        ///输出: ["(a)()()", "(a())()"]
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public IList<string> RemoveInvalidParentheses(string str)
        {
            List<string> resultList = new List<string>();
            return resultList;
        }
    }
}
