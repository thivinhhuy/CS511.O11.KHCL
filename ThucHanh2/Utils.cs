using CustomControls.RJControls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace _21522165_TH1
{
    public static class Utils
    {
        public static int GetTextHeight(RJTextBox Rtext)

        {
            using (Graphics g = Rtext.CreateGraphics())
            {
                SizeF size = g.MeasureString(Rtext.Text, Rtext.Font, 495);
                return (int)Math.Ceiling(size.Width);
            }
        }
    }

}
