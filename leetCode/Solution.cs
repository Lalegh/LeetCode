using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode
{
    public class Solution
    {
        public static int FindMaxConsecutiveOnes(int[] nums)
        {
            int res = 0;
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    res = 0;
                }
                else
                {
                    res += 1;
                    sum = res > sum ? res : sum;
                }
            }
            return sum;
        }
        public static string LongestCommonPrefix(string[] strs)
        {
            string res = "";

            for (int i = 0; i < strs.Length; i++)
            {
                if(i == 0)
                {
                    return "";
                }
                if (i == 0)
                {
                    res = strs[i];
                    continue;
                }
                else {
                    for (int j = 0; j < res.Length; j++)
                    { 
                        if (strs[i][j] != res[j])
                        {
                            res = res.Substring(0, j);
                            break;
                        }
                    if (j + 1 == strs[i].Length)
                    {

                        res = res.Substring(0, j + 1);
                        break;
                    }


                    else
                    {
                        continue;
                    }
                }

            }

            }
            return res;

        }
        public bool IsValid(string s)
        {
            Stack<char> res = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(' || s[i] == '[' || s[i] == '{' || s[i] == '}')
                {
                    res.Push(s[i]);
                }
                else if (s[i] == ')'||s[i] == '}'||s[i] == ']')
                {
                    res.Pop();
                    
                }
            }
            return res.Count == 0;
        }
        public static bool IsPalindrome(int x)
        {
            bool flag = true;
            
            return flag;
        }
    }
}
