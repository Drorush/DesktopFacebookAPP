using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DesktopFacebookAPP
{
    class MenuItemButton : Button
    {
        protected ICommand m_Command;
        private Panel m_SidePanel;

        public MenuItemButton(Panel i_SidePanel, ICommand i_Command) : base()
        {
            m_Command = i_Command;
            m_SidePanel = i_SidePanel;
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            m_SidePanel.Top = this.Top;
            m_SidePanel.Height = this.Height;
            if (m_Command != null)
            {
                m_Command.Execute();
            }
        }
    }
}
