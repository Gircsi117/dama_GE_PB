using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2021_11_04_dama_GE_PB
{
    public partial class Form1 : Form
    {
        //public static int[] szin1 = new int[3] {0, 255, 0 };
        public static int[] szin1 = new int[3] {192, 64, 0 };
        public static int[] szin2 = new int[3] { 10, 10, 10 };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //telje sképernyő
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            alap_general();
        }

        //főmenu kinézeti beállításai
        private void alap_general()
        {
            int magas = this.Height;
            int egyseg = magas / 24;

            //alap beállítása
            alapPANEl.Size = new Size(magas - 24, magas - 24);
            alapPANEl.Location = new Point(this.Width / 2 - alapPANEl.Width / 2, 12);

            //cim
            cimLBL.BackColor = Color.FromArgb(50, szin1[0], szin1[1], szin1[2]);
            cimLBL.Size = new Size(magas, egyseg*4);
            cimLBL.Font = new Font("Arial", cimLBL.Height/2);
            cimLBL.ForeColor = Color.FromArgb(szin1[0], szin1[1], szin1[2]);

            //textbox
            TextBox[] p_panels = new TextBox[2] {p1TBOX, p2TBOX};
            int[] pos = new int[2] { 4 * egyseg, 14 * egyseg };

            for (int i = 0; i < p_panels.Length; i++)
            {
                p_panels[i].Size = new Size(egyseg*6, egyseg*2);
                p_panels[i].Font = new Font("Arial", egyseg);
                p_panels[i].Location = new Point(pos[i], egyseg * 6);
                p_panels[i].MouseClick += nev_torol;
                p_panels[i].BorderStyle = BorderStyle.FixedSingle;
            }

            //menu buttons
            Button[] menu_buttons = new Button[4] { startBTN, settingBTN, infoBTN, exitBTN};
            int b_pos = 10;

            for (int i = 0; i < menu_buttons.Length; i++)
            {
                menu_buttons[i].Size = new Size(egyseg * 10, egyseg*2);

                menu_buttons[i].FlatStyle = FlatStyle.Flat;
                menu_buttons[i].FlatAppearance.BorderColor = Color.FromArgb(szin1[0], szin1[1], szin1[2]);
                menu_buttons[i].FlatAppearance.BorderSize = 3;
                menu_buttons[i].ForeColor = Color.FromArgb(szin2[0], szin2[1], szin2[2]);
                menu_buttons[i].BackColor = Color.FromArgb(szin1[0], szin1[1], szin1[2]);
                menu_buttons[i].Font = new Font("Arial", egyseg);
                menu_buttons[i].MouseEnter += erint;
                menu_buttons[i].MouseLeave += elhagy;

                menu_buttons[i].Location = new Point(egyseg * 7, egyseg * b_pos);
                b_pos += 3;
            }
            menu_buttons[menu_buttons.Length-1].Location = new Point(egyseg * 7, menu_buttons[menu_buttons.Length - 1].Location.Y + egyseg);

            this.Focus();
        }

        //menu gomb kattintás
        private void startBTN_MouseClick(object sender, MouseEventArgs e)
        {

            this.Focus();
        }

        private void settingBTN_MouseClick(object sender, MouseEventArgs e)
        {

            this.Focus();
        }

        private void infoBTN_MouseClick(object sender, MouseEventArgs e)
        {

            this.Focus();
        }

        private void exitBTN_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        //menu gombok "animációja"
        private void erint(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.ForeColor = Color.FromArgb(szin1[0], szin1[1], szin1[2]);
            btn.BackColor = Color.FromArgb(szin2[0], szin2[1], szin2[2]);
        }

        private void elhagy(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.ForeColor = Color.FromArgb(szin2[0], szin2[1], szin2[2]);
            btn.BackColor = Color.FromArgb(szin1[0], szin1[1], szin1[2]);
        }

        private void nev_torol(object sender, MouseEventArgs e)
        {
            TextBox tbox = sender as TextBox;
            tbox.Text = "";
        }
    }
}
