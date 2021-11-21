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
            atadas();

            //telje sképernyő
            this.FormBorderStyle = FormBorderStyle.None;

            int szeles = Screen.PrimaryScreen.WorkingArea.Width;
            int magas = Screen.PrimaryScreen.WorkingArea.Height;

            this.Width = (szeles / 10 * 7);
            this.Height = (magas / 10 * 7);
            this.Location = new Point(szeles / 2 - this.Width / 2, magas / 2 - this.Height / 2);

            fullBTN.FlatStyle = FlatStyle.Flat;
            fullBTN.FlatAppearance.BorderColor = Color.FromArgb(global.szin1[0], global.szin1[1], global.szin1[2]);
            fullBTN.FlatAppearance.BorderSize = 3;
            fullBTN.ForeColor = Color.FromArgb(global.szin2[0], global.szin2[1], global.szin2[2]);
            fullBTN.BackColor = Color.FromArgb(global.szin1[0], global.szin1[1], global.szin1[2]);
            fullBTN.MouseEnter += global.erint;
            fullBTN.MouseLeave += global.elhagy;
            fullBTN.Cursor = Cursors.Hand;
        }

        private void atadas()
        {
            global.main_form = this;

            global.header = headerPANEL;
            global.menu = new Menu();
            global.jatekter = new Jatekter();

            global.kivalasztott = global.menu;
            global.multiplayer = new Multiplayer();
            global.pause = new PauseScreen();
            global.info = new Info();

            this.Controls.Add(global.menu);
            this.Controls.Add(global.jatekter);
            this.Controls.Add(global.multiplayer);
            this.Controls.Add(global.pause);
            this.Controls.Add(global.info);

            global.elore_hoz(global.info);
            global.elore_hoz(global.pause);
            global.elore_hoz(global.multiplayer);
            global.elore_hoz(global.jatekter);
            global.elore_hoz(global.menu);
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
            if (this.WindowState != FormWindowState.Maximized && this.Location.Y <= 0)
            {
                this.WindowState = FormWindowState.Maximized;
                global.header.BackColor = Color.FromArgb(global.szin2[0], global.szin2[1], global.szin2[2]);
            }
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
            if ((sender as Button).Text == "Full")
            {
                if (this.WindowState == FormWindowState.Maximized)
                {
                    global.kivalasztott.BringToFront();
                    int szeles = Screen.PrimaryScreen.WorkingArea.Width;
                    int magas = Screen.PrimaryScreen.WorkingArea.Height;


                    global.header.BackColor = Color.FromArgb(global.szin1[0], global.szin1[1], global.szin1[2]);
                    this.WindowState = FormWindowState.Normal;
                    this.Location = new Point(szeles / 2 - this.Width / 2, magas / 2 - this.Height / 2);
                }
                else
                {
                    this.WindowState = FormWindowState.Maximized;
                    global.header.BackColor = Color.FromArgb(global.szin2[0], global.szin2[1], global.szin2[2]);
                }
            }
            else if((sender as Button).Text == "Menu")
            {
                global.elore_hoz(global.pause);
                global.header.Controls[0].Visible = false;
            }
            else if((sender as Button).Text == "Back")
            {
                global.elore_hoz(global.menu);
                (sender as Button).Text = "Full";
            }
        }
    }
}
