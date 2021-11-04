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
            //alap beállítása
            int magas = this.Height;
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
            cimLBL.Size = new Size(magas, magas / 5);
            cimLBL.Font = new Font("Arial", Convert.ToInt32(Math.Round(magas * 0.08)));
            cimLBL.ForeColor = Color.FromArgb(192, 64, 0);
        }

        private void exitBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
