using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeDemo
{
    class ArraysAndStrings
    {
        /// <summary>
        /// 搜索插入位置
        /// 给定一个排序数组和一个目标值，在数组中找到目标值，并返回其索引。如果目标值不存在于数组中，返回它将会被按顺序插入的位置。
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int SearchInsert(int[] nums, int target)
        {
            if (nums == null || nums.Length < 0)
            {
                return -1;
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] >= target)
                {
                    return i;
                }
            }
            return nums.Length;
        }
        /// <summary>
        /// 最长回文子串
        /// 给定一个字符串 s，找到 s 中最长的回文子串。你可以假设 s 的最大长度为 1000。
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public string LongestPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return "";
            }

            //正向遍历
            for (int i = 0; i < s.Length; i++)
            {
                int j = s.Length - 1 - i;

            }

            return "";
        }
        /// <summary>
        /// 合并区间  给出一个区间的集合，请合并所有重叠的区间。
        ///  输入:[[1,3],[2,6],[8,10],[15,18]]   输出: [[1,6],[8,10],[15,18]]
        /// </summary>
        /// <param name="intervals"></param>
        /// <returns></returns>
        public int[][] Merge(int[][] intervals)
        {
            if (intervals == null || intervals.Length < 2)
            {
                return intervals;
            }
            Array.Sort(intervals, ((item1, item2) => item1[0].CompareTo(item2[0])));
            int size = intervals.Length;
            List<int[]> list = new List<int[]>();
            for (int i = 0; i < size - 1; i++)
            {
                //合并
                if (intervals[i][1] >= intervals[i + 1][0])
                {
                    //包含
                    if (intervals[i][1] >= intervals[i + 1][1])
                    {
                        intervals[i + 1][0] = intervals[i][0];
                        intervals[i + 1][1] = intervals[i][1];
                    }
                    else
                    {
                        intervals[i + 1][0] = intervals[i][0];
                        intervals[i + 1][1] = intervals[i + 1][1];
                    }
                    //同时 置空当前数组
                    intervals[i] = null;
                }
            }
            return intervals.Where(i => i != null).ToArray();
        }

        /// <summary>
        /// 寻找数组的中心索引
        /// 数组中心索引的左侧所有元素相加的和等于右侧所有元素相加的和。数组不存在中心索引，返回 -1。如果数组有多个中心索引，返回最靠近左边的那一个。
        /// 输入: nums = [1, 7, 3, 6, 5, 6]  输出: 3
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int PivotIndex(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return -1;
            }
            int leftValue = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i > 0)
                {
                    leftValue += nums[i - 1];
                }
                int rightValue = 0;
                for (int j = nums.Length - 1; j > i; j--)
                {
                    rightValue += nums[j];
                }
                if (leftValue == rightValue)
                {
                    return i;
                }
            }
            return -1;
        }

        /// <summary>
        /// 至少是其他数字两倍的最大数
        /// 在一个给定的数组nums中，总是存在一个最大元素 。 查找数组中的最大元素是否至少是数组中每个其他数字的两倍。
        /// 如果有返回最大元素的索引，否则返回-1。
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int DominantIndex(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return -1;
            }
            if (nums.Length == 1)
            {
                return 0;
            }
            int index = 0;
            int max = nums[0];
            int lower = nums[1];
            for (int i = 1; i < nums.Length; i++)
            {
                int n = nums[i];
                if (max >= n)
                {
                    if (lower < n)
                    {
                        lower = n;
                    }
                }
                else
                {
                    index = i;
                    lower = max;
                    max = n;
                }
            }
            if (lower * 2 <= max)
            {
                return index;
            }
            return -1;
        }

        /// <summary>
        /// 给定一个由整数组成的非空数组所表示的非负整数，在该数的基础上加一。
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int[] PlusOne(int[] digits)
        {
            int[] result = new int[digits.Length + 1];
            result[0] = 1;
            for (int i = digits.Length - 1; i > -1; i--)
            {
                int num = digits[i];
                if (num < 9)
                {
                    digits[i] = num + 1;
                    return digits;
                }
                digits[i] = 0;
                result.Append(0);
            }
            return result;
        }


        /// <summary>
        /// 零矩阵  若M × N矩阵中某个元素为0，则将其所在的行与列清零。 
        /// </summary>
        /// <param name="matrix"></param>
        public void SetZeroes(int[][] matrix)
        {
            int m = matrix.Length;
            int n = matrix[0].Length;
            List<int[]> marks = new List<int[]>();
            //先记录有0的下标
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        marks.Add(new int[] { i, j });
                    }
                }
            }
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i][j] == 0 && marks.Contains(new int[] { i, j }))
                    {
                        int row = 0; int col = 0;
                        //把当行 置为0
                        while (col < n)
                        {
                            matrix[i][col] = 0;
                            col++;
                        }
                        //把当列 置为0
                        while (row < m)
                        {
                            matrix[row][j] = 0;
                            row++;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 对角线遍历 
        /// 给定一个含有 M x N 个元素的矩阵（M 行，N 列），请以对角线遍历的顺序返回这个矩阵中的所有元素 
        /// 输入:
        ////[
        //// [ 1, 2, 3 ],   
        //// [ 4, 5, 6 ],
        //// [ 7, 8, 9 ]
        ////]
        /// 输出:  [1,2,4,7,5,3,6,8,9]
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        public int[] FindDiagonalOrder(int[][] matrix)
        {
                if (matrix == null || matrix.Length < 1)
                {
                    return new int[0];
                }
                List<int> result = new List<int>();
                int m = matrix.Length - 1;
                int n = matrix[0].Length - 1;
                if (matrix.Length == 1)
                {
                    for (int i = 0; i < n; i++)
                    {
                        result.Add(matrix[0][i]);
                    }
                }
                int currentRow = 0;
                int currentCol = 0;
                //坐标和(x+y)  奇数↙  偶数 ↗
                while (currentRow * currentCol <= m * n)
                {
                    result.Add(matrix[currentRow][currentCol]);
                    int odvity = (currentRow + currentCol) % 2;
                    //偶数
                    if (odvity == 0)
                    {
                        if (currentCol == m)
                        {
                            if (currentRow >= 0)
                            {
                                currentRow++;
                            }
                        }
                        else
                        {
                            currentCol++;
                            if (currentRow != 0)
                            {
                                currentRow--;
                            }
                        }
                    }
                    //奇数  
                    else
                    {
                        //row 不变
                        if (currentRow == m)
                        {
                            if (currentCol >= 0)
                            {
                                currentCol++;
                            }
                        }
                        else
                        {
                            currentRow++;
                            if (currentCol != 0)
                            {
                                currentCol--;
                            }
                        }
                    }
                }
                return result.ToArray();
        }

        /// <summary>
        /// 反转字符串中的单词 III
        /// 给定一个字符串，你需要反转字符串中每个单词的字符顺序，同时仍保留空格和单词的初始顺序。
        /// 输入: "Let's take LeetCode contest"  输出: "s'teL ekat edoCteeL tsetnoc" 
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public string ReverseWords(string s)
        {
            string[] words = s.Split(' ');
            int wordLength = words.Length;
            string[] result = new string[wordLength];
            for (int i = 0; i < wordLength; i++)
            {
                char[] oldChars = words[i].ToArray();
                int charLength = oldChars.Length;
                char[] newChars = new char[charLength];
                for (int j = charLength - 1; j >= 0; j--)
                {
                    newChars[charLength - 1 - j] = oldChars[j];
                }
                result[i] = new string(newChars);
            }
            return string.Join(" ", result);
        }

        /// <summary>
        /// 最长公共前缀
        /// 编写一个函数来查找字符串数组中的最长公共前缀。 如果不存在公共前缀，返回空字符串 ""。
        /// </summary>
        /// <param name="strs"></param>
        /// <returns></returns>
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs == null || strs.Length < 1)
            {
                return "";
            }
            int minSize = strs.Min(s => s.Length);
            List<char> charArr = new List<char>();
            int strIndex = 0;
            int charIndex = 0;
            while (charIndex < minSize)
            {
                strIndex = 0;
                while (strIndex < strs.Length - 1)
                {
                    if (strs[strIndex][charIndex] == strs[strIndex + 1][charIndex])
                    {
                        strIndex++;
                    }
                    else
                    {
                        return new string(charArr.ToArray());
                    }
                }
                charArr.Add(strs[strIndex][charIndex]);
                charIndex++;
            }
            return new string(charArr.ToArray());
        }
        /// <summary>
        /// 给定一个字符串，逐个翻转字符串中的每个单词。
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public string ReverseEachWords(string s)
        {
            string[] strs = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int left = 0;
            int right = strs.Length - 1;
            while (left < right)
            {
                string temp = strs[left];
                strs[left] = strs[right];
                strs[right] = temp;
                left++;
                right--;
            }
            return string.Join(" ", strs);
        }

        /// <summary>
        /// 两数之和 II - 输入有序数组
        /// 给定一个已按照升序排列 的有序数组，找到两个数使得它们相加之和等于目标数。
        /// 函数应该返回这两个下标值 index1 和 index2，其中 index1 必须小于 index2。  返回的下标值（index1 和 index2）不是从零开始的。
        /// 示例：输入: numbers = [2, 7, 11, 15], target = 9   输出: [1,2]
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] TwoSum(int[] numbers, int target)
        {
            int[] result = new int[2];
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (!dic.ContainsKey(numbers[i]))
                {
                    dic.Add(numbers[i], i);
                }
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                int x = target - numbers[i];
                if (dic.ContainsKey(x) && dic[x] != i)
                {
                    result[0] = Math.Min(dic[x], i) + 1;
                    result[1] = Math.Max(dic[x], i) + 1;
                    break;
                }
            }
            return result;
        }

        /// <summary>
        /// 长度最小的子数组
        /// 给定一个含有 n 个正整数的数组和一个正整数 s ，找出该数组中满足其和 ≥ s 的长度最小的连续子数组，并返回其长度  不存在 返回0
        /// </summary>
        /// <param name="s"></param>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int MinSubArrayLen(int s, int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return 0;
            }
            int result = int.MaxValue;
            int current = 0;
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                while (sum >= s)
                {
                    result = Math.Min(result, i - current + 1);
                    sum -= nums[current++];
                }
            }

            return result == int.MaxValue ? 0 : result;
        }

        /// <summary> 
        /// 实现 strStr()
        /// 给定一个 haystack 字符串和一个 needle 字符串，在 haystack 字符串中找出 needle 字符串出现的第一个位置 (从0开始)。如果不存在，则返回  -1。
        /// 输入: haystack = "hello", needle = "ll"  输出: 2
        /// </summary>
        /// <param name="haystack"></param>
        /// <param name="needle"></param>
        /// <returns></returns>
        public int StrStr(string haystack, string needle)
        {
            if (string.IsNullOrEmpty(needle))
            {
                return 0;
            }
            if (needle.Length > haystack.Length || string.IsNullOrEmpty(haystack))
            {
                return -1;
            }
            //KMP算法
            return -1;
        }

        private int KMP(string haystack, string needle)
        {
            int[] next = GetNext(needle);
            int i = 0;
            int j = 0;
            while (i < haystack.Length)
            {
                if (haystack[i] == needle[j])
                {
                    j++;
                    i++;
                }
                if (j == needle.Length)
                {
                    return i - j;
                }
                else if (i < haystack.Length && haystack[i] != needle[j])
                {
                    if (j != 0)
                        j = next[j - 1];
                    else
                        i++;
                }

            }
            return -1;
        }

        private int[] GetNext(string str)
        {
            return null;
        }
        /// <summary>
        /// 数组拆分 I
        /// 给定长度为 2n 的数组, 你的任务是将这些数分成 n 对, 例如 (a1, b1), (a2, b2), ..., (an, bn) ，使得从1 到 n 的 min(ai, bi) 总和最大
        /// 输入: [1,4,3,2] 输出: 4  解释: n 等于 2, 最大总和为 4 = min(1, 2) + min(3, 4).
        /// </summary>  
        /// <param name="nums"></param>
        /// <returns></returns>
        public int ArrayPairSum(int[] nums)
        {
            Array.Sort(nums, (num1, num2) => num1.CompareTo(num2));
            int sum = 0;
            for (int k = 0; k < nums.Length; k++)
            {
                if (k % 2 == 0)
                {
                    sum += nums[k];
                }
            }
            return sum;
        }



        /// <summary>
        /// 最大连续1的个数
        /// 给定一个二进制数组， 计算其中最大连续1的个数。 输入: [1,1,0,1,1,1] 输出: 3
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            if (nums == null || nums.Length < 1)
            {
                return 0;
            }
            int max = 0, count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    count++;
                    if (max < count)
                    {
                        max = count;
                    }
                }
                else
                {
                    if (max < count)
                    {
                        max = count;
                    }
                    count = 0;
                }
            }
            return max;
        }

        /// <summary>
        ///   删除排序数组中的重复项
        ///   给定一个排序数组，你需要在 原地 删除重复出现的元素，使得每个元素只出现一次，返回移除后数组的新长度。
        ///   要使用额外的数组空间，你必须在 原地 修改输入数组 并在使用 O(1) 额外空间的条件下完成。
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int RemoveDuplicates(int[] nums)
        {
            if (nums == null || nums.Length < 1)
            {
                return 0;
            }
            int count = 1;
            int current = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[current] != nums[i])
                {
                    nums[++current] = nums[i];
                    count++;
                }
            }
            return count;
        }
        /// <summary>
        /// 移除元素
        /// 给你一个数组 nums 和一个值 val，你需要 原地 移除所有数值等于 val 的元素，并返回移除后数组的新长度。
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        public int RemoveElement(int[] nums, int val)
        {
            if (nums == null || nums.Length < 1)
            {
                return 0;
            }
            int index = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[index++] = nums[i];
                }
            }
            return index;
        }

        /// <summary>
        /// 旋转矩阵
        /// 给你一幅由 N × N 矩阵表示的图像，其中每个像素的大小为 4 字节。请你设计一种算法，将图像旋转 90 度。 不占用额外内存空间
        /// </summary>
        /// <param name="matrix"></param>
        public void Rotate(int[][] matrix)
        {
            if (matrix.Length < 2)
            {
                return;
            }
            int m = matrix.Length;
            for (int i = 0; i < m; i++)
            {
                //先以对角线翻转
                for (int j = i; j < m; j++)
                {
                    int temp = matrix[i][j];
                    matrix[i][j] = matrix[j][i];
                    matrix[j][i] = temp;
                }
                //再以纵中线翻转
                for (int j = 0; j < m / 2; j++)
                {
                    int temp = matrix[i][j];
                    matrix[i][j] = matrix[i][(m - 1) - j];
                    matrix[i][(m - 1) - j] = temp;
                }
            }
        }

        /// <summary>
        /// 移动零
        /// 给定一个数组 nums，编写一个函数将所有 0 移动到数组的末尾，同时保持非零元素的相对顺序。
        /// 输入: [0,1,0,3,12]   输出: [1,3,12,0,0]
        /// </summary>
        /// <param name="nums"></param>
        public void MoveZeroes(int[] nums)
        {
            int tail = nums.Length - 1;
            for (int i = 0; i <= tail; i++)
            {
                if (nums[i] == 0)
                {
                    int index = i;
                    while (index < tail)
                    {
                        nums[index] = nums[++index];
                    }
                    nums[tail] = 0;
                    tail--;
                }
            }


#if way1
            int i = 0, j = 0;
            for (i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[j++] = nums[i];
                }
            }
            while (j < nums.Length)
            {
                nums[j++] = 0;
            } 
#endif
        }
    }
}
