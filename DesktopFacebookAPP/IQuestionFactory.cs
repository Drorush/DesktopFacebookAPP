using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace DesktopFacebookAPP
{
    public interface IQuestionFactory
    {
        Question CreateQuestion(FacebookObjectCollection<User> i_Friends);
    }
}
