using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper;
using Facebook;
using FacebookWrapper.ObjectModel;

namespace DesktopFacebookAPP
{
    public partial class MainWindow : Form
    {
        private readonly string r_AppID = "1168955353252324";

        private User m_LoggedInUser { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            loginAndInit();
        }

        private void loginAndInit()
        {
            LoginResult result = FacebookService.Login(
                r_AppID,
                "public_profile",
                "email");

            if (!string.IsNullOrEmpty(result.AccessToken))
            {
                m_LoggedInUser = result.LoggedInUser;

                // do something with user info
            }
            else
            {
                MessageBox.Show(result.ErrorMessage);
            }
        }
    }
}
