using Doan.RJUserControl;
using Doan.Roundedtext;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doan.Height
{
    internal class HeightUserChatText
    {
        public static int GetTextHeight(RJtext Rtext)

        {
            using (Graphics g = Rtext.CreateGraphics())
            {
                SizeF size = g.MeasureString(Rtext.Text, Rtext.Font, 495);
                return (int)Math.Ceiling(size.Width);
            }
        }
    }
}
