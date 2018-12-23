using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace DesktopFacebookAPP
{
    public class QuestionFactoryIdentifyByProfilePicture : IQuestionFactory
    {
        public Question CreateQuestion(FacebookObjectCollection<User> i_Friends)
        {
            return new QuestionIdentifyByProfilePicture(i_Friends);
        }
    }
}
