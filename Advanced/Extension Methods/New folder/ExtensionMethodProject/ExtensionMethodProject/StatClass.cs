using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodProject
{
    static class StatClass
    {
        public static void Test3(this Program p)
        {
            Console.WriteLine("Method 3...");
        }

        public static void Test2(this Program p)
        {
            Console.WriteLine("Extension Method 2...");
        }

        public static long Factorial(this Int32 x)
        {
            if(x==1)
            {
                return 1;
            }
            if(x==2)
            {
                return 2;
            }
            else
            {
                return x * Factorial(x - 1);
            }
        }

        public static string ToProper(this string OldStr)
        {
            if(OldStr.Trim().Length > 0)
            {
                string NewStr = null;

                OldStr = OldStr.ToLower();
                string[] sArr = OldStr.Split(' ');

                foreach(string str in sArr)
                {
                    char[] charArr = str.ToCharArray();
                    charArr[0] = char.ToUpper(charArr[0]);

                    if (NewStr == null)
                    {
                        NewStr = new String(charArr);
                    }
                    else
                    {
                        NewStr += " " + new String(charArr);
                    }
                }

                return NewStr;
            }
            return OldStr;
        }
    }
}
