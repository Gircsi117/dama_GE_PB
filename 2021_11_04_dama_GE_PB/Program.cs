using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2021_11_04_dama_GE_PB
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    public class global
    {
        public static int[] szin1 = new int[3] { 192, 64, 0 };
        public static int[] szin2 = new int[3] { 10, 10, 10 };

        public static UserControl menu;

        public static void erint(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.ForeColor = System.Drawing.Color.FromArgb(global.szin1[0], global.szin1[1], global.szin1[2]);
            btn.BackColor = System.Drawing.Color.FromArgb(global.szin2[0], global.szin2[1], global.szin2[2]);
        }

        public static void elhagy(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.ForeColor = System.Drawing.Color.FromArgb(global.szin2[0], global.szin2[1], global.szin2[2]);
            btn.BackColor = System.Drawing.Color.FromArgb(global.szin1[0], global.szin1[1], global.szin1[2]);
        }
    }
}
