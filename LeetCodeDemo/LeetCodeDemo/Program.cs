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
            BinarySearch binary = new BinarySearch();
            int[] nums = { 4, 5, 6, 7, 0, 1, 2 }; int target = 2;
            int result = binary.SearchRoate(nums,target);
            Console.WriteLine(result);
            Console.ReadKey();
        }



    }

}
