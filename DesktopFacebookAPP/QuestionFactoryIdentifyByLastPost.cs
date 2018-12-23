using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace DesktopFacebookAPP
{
    public class QuestionFactoryIdentifyByLastPost : IQuestionFactory
    {
        public Question CreateQuestion(FacebookObjectCollection<User> i_Friends)
        {
            return new QuestionIdentifyByLastPost(i_Friends);
        }
    }
}
