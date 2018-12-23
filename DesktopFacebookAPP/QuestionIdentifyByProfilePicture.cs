using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace DesktopFacebookAPP
{
    public class QuestionIdentifyByProfilePicture : Question
    {
        public QuestionIdentifyByProfilePicture(FacebookObjectCollection<User> i_Friends) : base(i_Friends)
        {
            QuestionContent = "Which of the following friends has this profile picture?";
        }

        public override User getRandomFriend()
        {
            User friendToReturn;
            do
            {
                friendToReturn = randomizeFriend();
            }
            while (string.IsNullOrEmpty(friendToReturn.PictureNormalURL));

            return friendToReturn;
        }
    }
}
