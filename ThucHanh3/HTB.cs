using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thuchanh3
{
    internal class HTB
    {
        public static int GetTextHeight(Panel panel)

        {
            using (Graphics g = panel.CreateGraphics())
            {
                SizeF size = g.MeasureString(panel.Text, panel.Font, 495);
                return (int)Math.Ceiling(size.Width);
            }
        }
    }
}
