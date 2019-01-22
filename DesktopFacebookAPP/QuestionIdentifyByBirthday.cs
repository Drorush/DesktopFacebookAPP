using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace DesktopFacebookAPP
{
    public class QuestionIdentifyByBirthday : Question
    {
        public QuestionIdentifyByBirthday(FacebookObjectCollection<User> i_Friends) : 
            base(i_Friends, user => string.IsNullOrEmpty(user.Birthday))
        {
            string friendBirthday = Answer.Birthday;
            QuestionContent = string.Format(
                $"Which of the following friends born in {friendBirthday}?");
        }
    }
}
