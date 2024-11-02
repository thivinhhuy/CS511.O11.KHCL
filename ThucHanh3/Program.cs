using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thuchanh3
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
            DNDK dNDK = new DNDK();
            dNDK.Show();
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
            static string _refer;
            public static string refer
            {
                set { refer = value; }
                get { return _refer; }
            }
        }
    }
}
