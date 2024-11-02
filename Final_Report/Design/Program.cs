using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Doan
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FormDangNhap formDangNhap = new FormDangNhap();
            formDangNhap.Show();
            Application.Run();
        }
        public static class Globals
        {
            static string _idglob;
            public static string idglob
            {
                set { _idglob = value; }
                get { return _idglob; }
            }

        }
        
        public static class Checkchat
        {
            static int _refer;
            public static int refer
            {
                set { _refer = value; }
                get { return _refer; }
            }
        }
        public static class ID
        {
            static string _Ten;
            public static string Ten
            {
                set { _Ten = value; }
                get { return _Ten; }
            }
            static int _Id;
            public static int id
            {
                set { _Id = value; }
                get { return _Id; }
            }

        }
        public static class FileThemAnh
        {
            static List<string> _Fileanh;
            public static List<string> Fileanh
            {
                set { _Fileanh = value; }
                get { return _Fileanh; }
            }

            static int _Video;
            public static int video
            {
                set { _Video = value; }
                get { return _Video; }
            }

        }
    }
}
