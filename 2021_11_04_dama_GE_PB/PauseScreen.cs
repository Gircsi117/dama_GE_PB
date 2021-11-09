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
    public partial class PauseScreen : UserControl
    {
        public PauseScreen()
        {
            InitializeComponent();
        }

        private void PauseScreen_Load(object sender, EventArgs e)
        {
            global.meretez_alap(centerPANEL, this);
            this.Dock = DockStyle.Fill;
        }

        private void PauseScreen_SizeChanged(object sender, EventArgs e)
        {
            global.meretez_alap(centerPANEL, this);
            Button[] gombok = new Button[4] {contineueBTN, newgameBTN, screenBTN, menuBTN };
            int magas = 1;
            int egyseg = centerPANEL.Width / 24;

            for (int i = 0; i < gombok.Length; i++)
            {
                gombok[i].Size = new Size(egyseg * 18, egyseg * 4);
                gombok[i].Location = new Point(egyseg * 3, egyseg * magas);
                gombok[i].FlatStyle = FlatStyle.Flat;
                gombok[i].FlatAppearance.BorderColor = Color.FromArgb(global.szin1[0], global.szin1[1], global.szin1[2]);
                gombok[i].FlatAppearance.BorderSize = 3;
                gombok[i].FlatAppearance.MouseDownBackColor = Color.FromArgb(global.szin2[0], global.szin2[1], global.szin2[2]);
                gombok[i].ForeColor = Color.FromArgb(global.szin2[0], global.szin2[1], global.szin2[2]);
                gombok[i].BackColor = Color.FromArgb(global.szin1[0], global.szin1[1], global.szin1[2]);
                gombok[i].Font = new Font("Arial", gombok[i].Height / 3);
                gombok[i].MouseEnter += global.erint;
                gombok[i].MouseLeave += global.elhagy;
                gombok[i].Cursor = Cursors.Hand;

                magas += 6;
            }
            
        }

        private void contineueBTN_Click(object sender, EventArgs e)
        {
            global.elore_hoz(global.jatekter, false);
            global.header.Controls[0].Visible = true;
        }

        private void newgameBTN_Click(object sender, EventArgs e)
        {
            global.elore_hoz(global.jatekter);
            global.header.Controls[0].Visible = true;
        }

        private void screenBTN_Click(object sender, EventArgs e)
        {
            if (global.main_form.WindowState == FormWindowState.Maximized)
            {
                int szeles = Screen.PrimaryScreen.WorkingArea.Width;
                int magas = Screen.PrimaryScreen.WorkingArea.Height;

                global.header.BackColor = Color.FromArgb(global.szin1[0], global.szin1[1], global.szin1[2]);
                global.main_form.WindowState = FormWindowState.Normal;
                global.main_form.Location = new Point(szeles / 2 - this.Width / 2, magas / 2 - this.Height / 2);
            }
            else
            {
                global.main_form.WindowState = FormWindowState.Maximized;
                global.header.BackColor = Color.FromArgb(global.szin2[0], global.szin2[1], global.szin2[2]);
            }
        }

        private void menuBTN_Click(object sender, EventArgs e)
        {
            global.elore_hoz(global.menu);
            global.header.Controls[0].Text = "Full";
            global.header.Controls[0].Visible = true;
        }
    }
}
