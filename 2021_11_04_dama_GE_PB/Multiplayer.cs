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
    public partial class Multiplayer : UserControl
    {
        public Multiplayer()
        {
            InitializeComponent();
        }

        private void Multiplayer_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            global.meretez_alap(infoPANEL, this);
        }

        private void Multiplayer_Resize(object sender, EventArgs e)
        {
            global.meretez_alap(infoPANEL, this);
            meretez();
        }

        private void meretez()
        {
            int egyseg = infoPANEL.Height / 24;

            felkialtoPANEL_1.Size = new Size(egyseg*2, egyseg * 7);
            felkialtoPANEL_1.Location = new Point(egyseg*11, 0);

            felkialtoPANEL_2.Size = new Size(egyseg * 2, egyseg * 2);
            felkialtoPANEL_2.Location = new Point(egyseg * 11, egyseg*8);

            szovegLBL.Height = egyseg * 8;
            szovegLBL.Font = new Font("Arial", (egyseg/5) * 4);

            downloadBTN.Height = egyseg * 5;
            downloadBTN.Font = new Font("Arial", downloadBTN.Height/2, FontStyle.Bold);
            downloadBTN.Cursor = Cursors.Hand;
            downloadBTN.BackColor = Color.FromArgb(0, 255, 0);
            downloadBTN.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 0);
            downloadBTN.FlatAppearance.BorderSize = 5;
            downloadBTN.FlatAppearance.MouseDownBackColor = Color.Black;
        }

        private void downloadBTN_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Végzetes hiba történt!\nA program összeomlott!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Application.Exit();
        }
    }
}
