using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace DesktopFacebookAPP
{
    public class QuestionIdentifyByLastPost : Question
    {
        public QuestionIdentifyByLastPost(FacebookObjectCollection<User> i_Friends) : base(i_Friends,
            user => user.Posts == null || !user.Posts.Any())
        {
            string FriendLastPost = Answer.Posts[0].Message;
            QuestionContent = string.Format(
                $"Which of the following friends shared the post: \"{FriendLastPost}\"?");
        }
    }
}
