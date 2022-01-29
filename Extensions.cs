using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPTmodmaker
{
    static class Extensions
    {
        static List<string> ToList(this string[] arr)
        {
            List<string> nl = new List<string>();
            foreach (string i in arr)
            {
                nl.Add(i);
            }
            return nl;
        }
    }
}
