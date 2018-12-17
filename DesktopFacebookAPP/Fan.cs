using FacebookWrapper.ObjectModel;

namespace DesktopFacebookAPP
{
    internal class Fan
    {
        public User FanUser { get; set; }

        public int NumOfLikes { get; set; }

        public string FanDisplayContent { get; set; }

        public Fan(User i_User, int i_NumOfLikes)
        {
            this.FanUser = i_User;
            this.NumOfLikes = i_NumOfLikes;

            this.FanDisplayContent = string.Format("{0} - {1} likes", i_User.Name, i_NumOfLikes);
        }
    }
}