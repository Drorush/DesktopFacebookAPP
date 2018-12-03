using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesktopFacebookAPP
{
    public class NotEnoughFriendsException : Exception
    {
        public NotEnoughFriendsException() : base()
        {
        }

        public NotEnoughFriendsException(string i_Message) : base(i_Message)
        {
        }
    }
}
