using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace DesktopFacebookAPP
{
    public class HowWellDoYouKnowYourFriendsGame
    {
        public enum eQuestionType
        {
            IdentifyByProfilePicture,
            IdentifyByBirthDate,
            IdentifyByLastPost,
        }

        public Question FirstQuestion { get; private set; }

        public Question SecondQuestion { get; private set; }

        public Question ThirdQuestion { get; private set; }

        public HowWellDoYouKnowYourFriendsGame(User i_LoggedInUser)
        {
            if (i_LoggedInUser.Friends.Count < 3)
            {
                throw new NotEnoughFriendsException("Not enough friends to play the game");
            }

            generateQuestions(i_LoggedInUser.Friends);
        }

        private void generateQuestions(FacebookObjectCollection<User> i_Friends)
        {
            FirstQuestion = new Question(eQuestionType.IdentifyByProfilePicture, i_Friends);
            SecondQuestion = new Question(eQuestionType.IdentifyByBirthDate, i_Friends);
            ThirdQuestion = new Question(eQuestionType.IdentifyByLastPost, i_Friends);
        }

        public class Question
        {
            private eQuestionType m_Type { get; }

            public User Answer { get; private set; }

            public List<string> PossibleAnswers { get; set; }

            public FacebookObjectCollection<User> Friends { get; set; }

            public string QuestionContent { get; set; }

            public Question(eQuestionType i_QuestionType, FacebookObjectCollection<User> i_Friends)
            {
                PossibleAnswers = new List<string>();
                m_Type = i_QuestionType;
                Friends = i_Friends;

                generateQuestion();
            }

            private void generateQuestion()
            {
                Answer = getRandomFriend();
                addTwoAnswerOptions();

                switch (m_Type)
                {
                    case eQuestionType.IdentifyByBirthDate:
                        generateBirthdayQuestion();
                        break;
                    case eQuestionType.IdentifyByProfilePicture:
                        generatePictureIdentificationQuestion();
                        break;
                    case eQuestionType.IdentifyByLastPost:
                        generatePostIdentificationQuestion();
                        break;
                }
            }

            private void addTwoAnswerOptions()
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

            private User getRandomFriend()
            {
                User friendToReturn = randomizeFriend();

                switch (m_Type)
                {
                    case eQuestionType.IdentifyByProfilePicture:
                        while (string.IsNullOrEmpty(friendToReturn.PictureNormalURL))
                        {
                            friendToReturn = randomizeFriend();
                        }

                        break;
                    case eQuestionType.IdentifyByBirthDate:
                        while (string.IsNullOrEmpty(friendToReturn.Birthday))
                        {
                            friendToReturn = randomizeFriend();
                        }

                        break;
                    case eQuestionType.IdentifyByLastPost:
                        while (friendToReturn.Posts == null || !friendToReturn.Posts.Any())
                        {
                            friendToReturn = randomizeFriend();
                        }

                        break;
                }

                return friendToReturn;
            }

            private User randomizeFriend()
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
    }
}
