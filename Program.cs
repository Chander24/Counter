using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            CounterModeEnum counterModeEnum = CounterModeEnum.Reset;
            if (args.Length > 0)
            {
                string rMode = args[0];
                switch (rMode)
                {
                    case "reset":
                        counterModeEnum = CounterModeEnum.Reset;
                        break;
                    case "add":
                        counterModeEnum = CounterModeEnum.Add;
                        break;
                    case "sub":
                        counterModeEnum = CounterModeEnum.Sub;
                        break;
                    default:
                        counterModeEnum = CounterModeEnum.Reset;
                        break;
                }
            }
            string filePath = Configuration.GetFilePath();
            if (!string.IsNullOrEmpty(filePath))
            {
                string s = System.IO.File.ReadAllText(filePath);
                string b = string.Empty;
                int val;

                for (int i = 0; i < s.Length; i++)
                {
                    if (Char.IsDigit(s[i]))
                        b += s[i];
                }

                if (b.Length > 0)
                {
                    val = int.Parse(b);
                    int newValAdd = val + 1;
                    int newValSub = val - 1;

                    if (val == 0 && counterModeEnum == CounterModeEnum.Sub)
                    {
                        s = s.Replace(val.ToString(), "0");
                    }
                    else
                    {
                        switch (counterModeEnum)
                        {
                            case CounterModeEnum.Reset:
                                s = s.Replace(val.ToString(), "0");
                                break;
                            case CounterModeEnum.Add:
                                s = s.Replace(val.ToString(), newValAdd.ToString());
                                break;
                            case CounterModeEnum.Sub:
                                s = s.Replace(val.ToString(), newValSub.ToString());
                                break;
                            default:
                                s = s.Replace(val.ToString(), "0");
                                break;
                        }
                    }
                    System.IO.File.WriteAllText(filePath, s);
                }
            }
        }
    }
}
