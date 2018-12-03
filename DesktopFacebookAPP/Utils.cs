using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesktopFacebookAPP
{
    public static class Utils
    {
        public static void Shuffle<T>(this IList<T> io_List)
        {
            Random rng = new Random();

            int n = io_List.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = io_List[k];
                io_List[k] = io_List[n];
                io_List[n] = value;
            }
        }
    }
}
