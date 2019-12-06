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
            string text = "They went on and on till they came to a river";
            string[] strs = text.Split(' ');//获取单词数组
            Dictionary<string, int> dic = new Dictionary<string, int>();
            foreach (string str in strs)
            {
                if (dic.TryGetValue(str, out int num))
                {
                    dic[str] = dic[str]++;
                }
                else
                {
                    dic[str] = 1;
                }
            }
            foreach (var d in dic)
            {
                Console.WriteLine(d);
            }
            Console.ReadKey();
        }


      
    }

}
