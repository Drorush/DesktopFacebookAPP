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

    public class QuestionFactoryIdentifyByProfilePicture : IQuestionFactory
    {
        public Question CreateQuestion(FacebookObjectCollection<User> i_Friends)
        {
            return new QuestionIdentifyByProfilePicture(i_Friends);
        }
    }

    public class QuestionFactoryIdentifyByBirthday : IQuestionFactory
    {
        public Question CreateQuestion(FacebookObjectCollection<User> i_Friends)
        {
            return new QuestionIdentifyByBirthday(i_Friends);
        }
    }

    public class QuestionFactoryIdentifyByLastPost : IQuestionFactory
    {
        public Question CreateQuestion(FacebookObjectCollection<User> i_Friends)
        {
            return new QuestionIdentifyByLastPost(i_Friends);
        }
    }
}
