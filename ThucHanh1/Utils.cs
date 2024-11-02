﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace _21522165_TH1
{
    public static class Utils
    {
        public static int GetTextHeight(Label lbl)

        {
            using (Graphics g = lbl.CreateGraphics())
            {
                SizeF size = g.MeasureString(lbl.Text, lbl.Font, 495);
                return (int)Math.Ceiling(size.Width);
            }    
    }
    }

}