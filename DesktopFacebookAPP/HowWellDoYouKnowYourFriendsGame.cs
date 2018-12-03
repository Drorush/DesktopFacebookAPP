using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;
using static DesktopFacebookAPP.Question;

namespace DesktopFacebookAPP
{
    public class HowWellDoYouKnowYourFriendsGame
    {

        private List<IQuestionFactory> QuestionFactories { get; set; }

        private static HowWellDoYouKnowYourFriendsGame s_Game;

        public FacebookObjectCollection<User> Friends { get; private set; }

        private static object s_LockObj = new object();

        public List<Question> Questions { get; private set; }

        public static HowWellDoYouKnowYourFriendsGame Instance(User i_LoggedInUser)
        {
            if (s_Game == null)
            {
                lock (s_LockObj)
                {
                    if (s_Game == null)
                    {
                        s_Game = new HowWellDoYouKnowYourFriendsGame(i_LoggedInUser);
                        s_Game.Friends = i_LoggedInUser.Friends;
                        s_Game.QuestionFactories = new List<IQuestionFactory>
                        {
                            new QuestionFactoryIdentifyByProfilePicture(),
                            new QuestionFactoryIdentifyByBirthday(),
                            new QuestionFactoryIdentifyByLastPost()
                        };
                    }
                }
            }

            s_Game.generateQuestions();
            return s_Game;
        }

        private HowWellDoYouKnowYourFriendsGame(User i_LoggedInUser)
        {
            if (i_LoggedInUser.Friends.Count < 3)
            {
                throw new NotEnoughFriendsException("Not enough friends to play the game");
            }
        }

        private void generateQuestions()
        {
            Questions = new List<Question>();
            foreach(IQuestionFactory factory in QuestionFactories)
            {
                Questions.Add(factory.CreateQuestion(Friends));
            }
        }
    }
}
