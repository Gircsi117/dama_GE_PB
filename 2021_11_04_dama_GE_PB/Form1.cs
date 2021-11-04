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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            alap_general();
        }

        private void alap_general()
        {
            int magas = this.Height;
            int egyseg = magas / 12;

            //alap beállítása
            alapPANEl.Size = new Size(magas - 24, magas - 24);
            alapPANEl.Location = new Point(this.Width / 2 - alapPANEl.Width / 2, 12);

            //exit button
            exitBTN.FlatStyle = FlatStyle.Flat;
            exitBTN.FlatAppearance.BorderColor = Color.FromArgb(192, 64, 0);
            exitBTN.FlatAppearance.BorderSize = 1;
            exitBTN.ForeColor = Color.FromArgb(192, 64, 0);
            exitBTN.Font = new Font("Arial", Convert.ToInt32(Math.Round(magas * 0.02)));
            exitBTN.Location = new Point(this.Width - (exitBTN.Width + 12), 12);

            //cim
            cimLBL.BackColor = Color.FromArgb(50, 192, 64, 0);
            cimLBL.Size = new Size(magas, egyseg*2);
            cimLBL.Font = new Font("Arial", cimLBL.Height/2);
            cimLBL.ForeColor = Color.FromArgb(192, 64, 0);

            //pPanel_1
            Panel[] p_panels = new Panel[2] { player_namePANEL_1, player_namePANEL_2 };
            int[] pos = new int[2] {2*egyseg, 7*egyseg};
            for (int i = 0; i < p_panels.Length; i++)
            {
                p_panels[i].Size = new Size(egyseg*3, egyseg*2);
                p_panels[i].Location = new Point(pos[i], egyseg*3);

                //panel
                p_panels[i].Controls[1].Location = new Point(0, 0);
                p_panels[i].Controls[1].Size = new Size(p_panels[i].Width, egyseg);
                p_panels[i].Controls[1].Font = new Font("Arial", egyseg / 2);

                //textbox
                p_panels[i].Controls[0].Location = new Point(0, egyseg);
                p_panels[i].Controls[0].Size = new Size(p_panels[i].Width, egyseg);
                p_panels[i].Controls[0].Font = new Font("Arial", egyseg / 2);

            }

            this.Focus();
        }

        private void exitBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
