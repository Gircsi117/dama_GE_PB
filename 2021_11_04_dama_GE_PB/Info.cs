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
    public partial class Info : UserControl
    {
        public Info()
        {
            InitializeComponent();
        }

        private void Info_SizeChanged(object sender, EventArgs e)
        {
            global.meretez_alap(centerPANEL, this);
            meretezes();
        }

        private void Info_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        private void meretezes()
        {
            Label[] cimek = new Label[3] {koszonet_cimLBL, jatekrol_cimLBL, szabalyok_cimLBL };
            Label[] szovegek = new Label[3] {koszonet_szovegLBL, jatekrol_szovegLBL, szabalyok_szovegLBL };
            int pos = 0;
            int egyseg = centerPANEL.Width / 24;

            for (int i = 0; i < cimek.Length; i++)
            {
                cimek[i].BackColor = Color.FromArgb(50, global.szin1[0], global.szin1[1], global.szin1[2]);
                cimek[i].ForeColor = Color.FromArgb(global.szin1[0], global.szin1[1], global.szin1[2]);
                cimek[i].Size = new Size(centerPANEL.Width, egyseg * 2);
                cimek[i].Font = new Font("Arial", cimek[i].Height / 2);
                cimek[i].Location = new Point(0, egyseg * pos);

                szovegek[i].ForeColor = Color.FromArgb(global.szin1[0], global.szin1[1], global.szin1[2]);
                szovegek[i].Size = new Size(centerPANEL.Width, egyseg * 5);
                szovegek[i].Font = new Font("Arial", cimek[i].Height / 3);
                szovegek[i].Location = new Point(0, egyseg * (pos + 2));
                szovegek[i].TextAlign = ContentAlignment.TopLeft;

                pos += 8;
            }
        }
    }
}
