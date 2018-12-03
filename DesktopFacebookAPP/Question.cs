using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace DesktopFacebookAPP
{
    public abstract class Question
    {
        public User Answer { get; protected set; }

        public List<string> PossibleAnswers { get; set; }

        public FacebookObjectCollection<User> Friends { get; set; }

        public string QuestionContent { get; protected set; }

        public Question(FacebookObjectCollection<User> i_Friends)
        {
            PossibleAnswers = new List<string>();
            Friends = i_Friends;
            Answer = getRandomFriend();
            addTwoAnswerOptions();
        }

        public void addTwoAnswerOptions()
        {
            PossibleAnswers.Add(Answer.Name);

            while (PossibleAnswers.Count < 3)
            {
                string friend = randomizeFriend().Name;
                if (!PossibleAnswers.Contains(friend))
                {
                    PossibleAnswers.Add(friend);
                }
            }

            PossibleAnswers.Shuffle();
        }

        public abstract User getRandomFriend();


        protected User randomizeFriend()
        {
            Random rnd = new Random();
            return Friends[rnd.Next(0, Friends.Count)];
        }

        private void generatePostIdentificationQuestion()
        {
            string FriendLastPost = Answer.Posts[0].Message;
            QuestionContent = string.Format(
                $"Which of the following friends shared the post: \"{FriendLastPost}\"?");
        }

        private void generatePictureIdentificationQuestion()
        {
            QuestionContent = "Which of the following friends has this profile picture?";
        }

        private void generateBirthdayQuestion()
        {
            string friendBirthday = Answer.Birthday;
            QuestionContent = string.Format(
                $"Which of the following friends born in {friendBirthday}?");
        }
    }

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
            } while (string.IsNullOrEmpty(friendToReturn.PictureNormalURL));

            return friendToReturn;
        }
    }

    public class QuestionIdentifyByBirthday : Question
    {
        public QuestionIdentifyByBirthday(FacebookObjectCollection<User> i_Friends) : base(i_Friends)
        {
            string friendBirthday = Answer.Birthday;
            QuestionContent = string.Format(
                $"Which of the following friends born in {friendBirthday}?");
        }

        public override User getRandomFriend()
        {
            User friendToReturn;

            do
            {
                friendToReturn = randomizeFriend();
            }
            while (string.IsNullOrEmpty(friendToReturn.Birthday));

            return friendToReturn;
        }
    }

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
