﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;
using static DesktopFacebookAPP.Question;

namespace DesktopFacebookAPP
{
    public class HowWellDoYouKnowYourFriendsGame
    {
        private static object s_LockObj = new object();

        private static HowWellDoYouKnowYourFriendsGame s_Game;

        private List<IQuestionFactory> m_QuestionFactories;

        public FacebookObjectCollection<User> Friends { get; private set; }

        public List<Question> Questions { get; private set; }

        public static HowWellDoYouKnowYourFriendsGame Instance(User i_LoggedInUser)
        {
            if (s_Game == null)
            {
                lock (s_LockObj)
                {
                    if (s_Game == null)
                    {
                        s_Game = new HowWellDoYouKnowYourFriendsGame(i_LoggedInUser)
                        {
                            Friends = i_LoggedInUser.Friends,
                            m_QuestionFactories = new List<IQuestionFactory>
                        {
                            new QuestionFactoryIdentifyByProfilePicture(),
                            new QuestionFactoryIdentifyByBirthday(),
                            new QuestionFactoryIdentifyByLastPost()
                        }
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
            foreach (IQuestionFactory factory in m_QuestionFactories)
            {
                Questions.Add(factory.CreateQuestion(Friends));
            }
        }
    }
}
