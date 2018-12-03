using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DesktopFacebookAPP
{
    public class RoundedEdgeButton : Button
    {
        private GraphicsPath getRoundPath(RectangleF i_Rect, int i_Radius)
        {
            float r2 = i_Radius / 2f;
            GraphicsPath GraphPath = new GraphicsPath();

            GraphPath.AddArc(i_Rect.X, i_Rect.Y, i_Radius, i_Radius, 180, 90);
            GraphPath.AddLine(i_Rect.X + r2, i_Rect.Y, i_Rect.Width - r2, i_Rect.Y);
            GraphPath.AddArc(i_Rect.X + i_Rect.Width - i_Radius, i_Rect.Y, i_Radius, i_Radius, 270, 90);
            GraphPath.AddLine(i_Rect.Width, i_Rect.Y + r2, i_Rect.Width, i_Rect.Height - r2);
            GraphPath.AddArc(i_Rect.X + i_Rect.Width - i_Radius, i_Rect.Y + i_Rect.Height - i_Radius, i_Radius, i_Radius, 0, 90);
            GraphPath.AddLine(i_Rect.Width - r2, i_Rect.Height, i_Rect.X + r2, i_Rect.Height);
            GraphPath.AddArc(i_Rect.X, i_Rect.Y + i_Rect.Height - i_Radius, i_Radius, i_Radius, 90, 90);
            GraphPath.AddLine(i_Rect.X, i_Rect.Height - r2, i_Rect.X, i_Rect.Y + r2);

            GraphPath.CloseFigure();
            return GraphPath;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            RectangleF Rect = new RectangleF(0, 0, this.Width, this.Height);
            GraphicsPath GraphPath = getRoundPath(Rect, 50);

            this.Region = new Region(GraphPath);
            using (Pen pen = new Pen(Color.WhiteSmoke, 3f))
            {
                pen.Alignment = PenAlignment.Inset;
                e.Graphics.DrawPath(pen, GraphPath);
            }
        }
    }
}
