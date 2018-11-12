using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesktopFacebookAPP
{
    class NotEnoughFriendsException : Exception
    {
        public NotEnoughFriendsException() : base() { }

        public NotEnoughFriendsException(string i_Message) : base(i_Message) { }
    }

    static class Utils
    {
        public static void Shuffle<T>(this IList<T> list)
        {
            Random rng = new Random();

            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}
