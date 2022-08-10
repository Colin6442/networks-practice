using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client{
    static class Program{
        [STAThread]
        [DllImport("kernel32.dll", SetLastError=true, ExactSpelling=true)]
        static extern bool FreeConsole();
        static void Main(){
            FreeConsole();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
