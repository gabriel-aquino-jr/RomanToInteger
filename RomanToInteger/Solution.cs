using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanToInteger
{
    public class Solution
    {
        public enum RomanSymbols
        {
            I = 1,
            V = 5,
            X = 10,
            L = 50,
            C = 100,
            D = 500,
            M = 1000
        }

        public int RomanToInt(string s)
        {
            int sum = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (i+1 < s.Length)
                {
                    if (s[i] == 'I')
                    {
                        if (s[i + 1] == 'V')
                        {
                            sum += 4;
                            i++;
                            continue;
                        }

                        if (s[i + 1] == 'X')
                        {
                            sum += 9;
                            i++;
                            continue;
                        }
                    }

                    if (s[i] == 'X')
                    {
                        if (s[i + 1] == 'L')
                        {
                            sum += 40;
                            i++;
                            continue;
                        }

                        if (s[i + 1] == 'C')
                        {
                            sum += 90;
                            i++;
                            continue;
                        }
                    }

                    if (s[i] == 'C')
                    {
                        if (s[i + 1] == 'D')
                        {
                            sum += 400;
                            i++;
                            continue;
                        }
                        
                        if (s[i + 1] == 'M')
                        {
                            sum += 900;
                            i++;
                            continue;
                        }
                    }
                }
                sum += Convert.ToInt32(Enum.Parse(typeof(RomanSymbols), s[i].ToString()));
            }
            return sum;
        }
    }
}
