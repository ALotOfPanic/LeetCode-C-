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
    }

}
