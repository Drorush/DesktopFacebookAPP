using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DesktopFacebookAPP
{
    public class RoundedButton : Button
    {
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            GraphicsPath grPath = new GraphicsPath();
            grPath.AddEllipse(1, 1, this.Width - 4, this.Height - 4);
            this.Region = new System.Drawing.Region(grPath);
            base.OnPaint(e);
        }
    }
}
