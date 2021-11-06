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
    public partial class Menu : UserControl
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            //telje sképernyő
            this.BorderStyle = BorderStyle.None;
            this.Dock = DockStyle.Fill;

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
            int kivon = (global.main_form.WindowState == FormWindowState.Maximized) ? (global.header.Height) : (0);
            int magas = ((this.Height < this.Width) ? (this.Height) : (this.Width)) - kivon;
            int egyseg = magas / 24;

            global.meretez_alap(alapPANEl, this);

            //cim
            cimLBL.BackColor = Color.FromArgb(50, global.szin1[0], global.szin1[1], global.szin1[2]);
            cimLBL.Size = new Size(magas, egyseg * 4);
            cimLBL.Font = new Font("Arial", cimLBL.Height / 2);
            cimLBL.ForeColor = Color.FromArgb(global.szin1[0], global.szin1[1], global.szin1[2]);

            //textbox
            TextBox[] p_panels = new TextBox[2] { p1TBOX, p2TBOX };
            int[] pos = new int[2] { 4 * egyseg, 14 * egyseg };

            for (int i = 0; i < p_panels.Length; i++)
            {
                p_panels[i].Size = new Size(egyseg * 6, egyseg * 2);
                p_panels[i].Font = new Font("Arial", egyseg);
                p_panels[i].Location = new Point(pos[i], egyseg * 6);
                p_panels[i].MouseClick += nev_torol;
                p_panels[i].BorderStyle = BorderStyle.FixedSingle;
            }

            //menu buttons
            Button[] menu_buttons = new Button[4] { startBTN, multiBTN, infoBTN, exitBTN };
            int b_pos = 10;

            for (int i = 0; i < menu_buttons.Length; i++)
            {
                menu_buttons[i].Size = new Size(egyseg * 10, egyseg * 2);

                menu_buttons[i].FlatStyle = FlatStyle.Flat;
                menu_buttons[i].FlatAppearance.BorderColor = Color.FromArgb(global.szin1[0], global.szin1[1], global.szin1[2]);
                menu_buttons[i].FlatAppearance.BorderSize = 3;
                menu_buttons[i].FlatAppearance.MouseDownBackColor = Color.FromArgb(global.szin2[0], global.szin2[1], global.szin2[2]);
                menu_buttons[i].ForeColor = Color.FromArgb(global.szin2[0], global.szin2[1], global.szin2[2]);
                menu_buttons[i].BackColor = Color.FromArgb(global.szin1[0], global.szin1[1], global.szin1[2]);
                menu_buttons[i].Font = new Font("Arial", egyseg);
                menu_buttons[i].MouseEnter += global.erint;
                menu_buttons[i].MouseLeave += global.elhagy;
                menu_buttons[i].Cursor = Cursors.Hand;

                menu_buttons[i].Location = new Point(egyseg * 7, egyseg * b_pos);
                b_pos += 3;
            }
            menu_buttons[menu_buttons.Length - 1].Location = new Point(egyseg * 7, menu_buttons[menu_buttons.Length - 1].Location.Y + egyseg * 2);

            this.Focus();
        }

        private void nev_torol(object sender, MouseEventArgs e)
        {
            TextBox tbox = sender as TextBox;
            tbox.Text = "";
        }

        private void Menu_SizeChanged(object sender, EventArgs e)
        {
            alap_general();
        }

        private void exitBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void startBTN_MouseClick(object sender, MouseEventArgs e)
        {
            global.elore_hoz(global.jatekter);
        }

        private void multiBTN_MouseClick(object sender, MouseEventArgs e)
        {
            global.elore_hoz(global.multiplayer);
        }
    }
}
