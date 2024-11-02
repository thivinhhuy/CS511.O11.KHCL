using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Doan.Roundedtext;


namespace Doam
{
    internal class Utils
    {
        public static int GetTextHeight(RJtext txt)
        {
            using (Graphics G = txt.CreateGraphics())
            {
                SizeF size = G.MeasureString(txt.Texts, txt.Font, 495);
                return (int)Math.Ceiling(size.Height);
            }
        }
    }
}
