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
        //Szinek
        public static int[] szin1 = new int[3] {192, 64, 0 };
        public static int[] szin2 = new int[3] { 10, 10, 10 };

        //változók
        private bool drag = false;
        private Point oldalHely = new Point(0, 0);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //telje sképernyő
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;

            int szeles = Screen.PrimaryScreen.WorkingArea.Width;
            int magas = Screen.PrimaryScreen.WorkingArea.Height;

            this.Width = (szeles / 10 * 7);
            this.Height = (magas / 10 * 7);
            this.Location = new Point(szeles / 2 - this.Width / 2, magas / 2 - this.Height / 2);

            alap_general();
        }

        //főmenu kinézeti beállításai
        private void alap_general()
        {
            int magas = ((this.Height < this.Width) ? (this.Height) : (this.Width)) - headerPANEL.Height;
            int egyseg = magas / 24;

            //header
            headerPANEL.BackColor = Color.FromArgb(szin1[0], szin1[1], szin1[2]);
            headerPANEL.Cursor = Cursors.Hand;

            fullBTN.Dock = DockStyle.Right;
            fullBTN.Cursor = Cursors.Hand;
            fullBTN.FlatStyle = FlatStyle.Flat;
            fullBTN.FlatAppearance.BorderColor = Color.FromArgb(szin1[0], szin1[1], szin1[2]);
            fullBTN.FlatAppearance.BorderSize = 1;

            fullBTN.MouseEnter += erint;
            fullBTN.MouseLeave += elhagy;


            //alap beállítása
            alapPANEl.Size = new Size(magas - 24, magas - 24);
            alapPANEl.Location = new Point(this.Width / 2 - alapPANEl.Width / 2, (this.Height / 2 - alapPANEl.Height / 2) + headerPANEL.Height/2);
            alapPANEl.Anchor = AnchorStyles.None;

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
                menu_buttons[i].Cursor = Cursors.Hand;

                menu_buttons[i].Location = new Point(egyseg * 7, egyseg * b_pos);
                b_pos += 3;
            }
            menu_buttons[menu_buttons.Length-1].Location = new Point(egyseg * 7, menu_buttons[menu_buttons.Length - 1].Location.Y + egyseg*2);

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

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            alap_general();
        }

        //Lap mozgathatósága
        private void headerPANEL_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            oldalHely = new Point(e.X, e.Y);
        }

        private void headerPANEL_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void headerPANEL_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.oldalHely.X, p.Y - this.oldalHely.Y);
            }
        }

        //méretezhetőség
        private void fullBTN_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                int szeles = Screen.PrimaryScreen.WorkingArea.Width;
                int magas = Screen.PrimaryScreen.WorkingArea.Height;

                headerPANEL.Visible = true;
                this.WindowState = FormWindowState.Normal;
                this.Location = new Point(szeles / 2 - this.Width /2 , magas / 2 - this.Height / 2);
            }
            else
            {
                headerPANEL.Visible = false;
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void header_nezet(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                if (e.Y < 30)
                {
                    headerPANEL.Visible = true;
                }
                else
                {
                    headerPANEL.Visible = false;
                }
            }
        }
    }
}
