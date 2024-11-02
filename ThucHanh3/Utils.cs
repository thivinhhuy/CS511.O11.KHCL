using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thuchanh3
{
    internal class Utils
    {
        public static int GetTextHeight(TextBox Rtext)

        {
            using (Graphics g = Rtext.CreateGraphics())
            {
                SizeF size = g.MeasureString(Rtext.Text, Rtext.Font, 495);
                return (int)Math.Ceiling(size.Width);
            }
        }
    }
}
