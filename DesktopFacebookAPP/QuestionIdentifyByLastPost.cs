using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace DesktopFacebookAPP
{
    public class QuestionIdentifyByLastPost : Question
    {
        public QuestionIdentifyByLastPost(FacebookObjectCollection<User> i_Friends) : base(i_Friends)
        {
            string FriendLastPost = Answer.Posts[0].Message;
            QuestionContent = string.Format(
                $"Which of the following friends shared the post: \"{FriendLastPost}\"?");
        }

        public override User getRandomFriend()
        {
            User friendToReturn;
            do
            {
                friendToReturn = randomizeFriend();
            }
            while (friendToReturn.Posts == null || !friendToReturn.Posts.Any());

            return friendToReturn;
        }
    }
}
