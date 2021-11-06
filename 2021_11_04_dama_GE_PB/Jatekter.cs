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
    public partial class Jatekter : UserControl
    {
        public Jatekter()
        {
            InitializeComponent();
        }

        private void Jatekter_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            global.meretez_alap(gamePANEL, this);
            tabla_general();
            tabla_meretez();
        }

        private void gamePANEL_Click(object sender, EventArgs e)
        {
            global.elore_hoz(global.menu);
        }

        private void Jatekter_SizeChanged(object sender, EventArgs e)
        {
            alap_general();
        }

        private void tabla_general()
        {
            tabla_torol();
            int szeles = (gamePANEL.Width - 24) / 8;
            int sor = 12;
            int oszlop = 12;
            bool szin = true;

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Panel pan = new Panel();
                    gamePANEL.Controls.Add(pan);
                    pan.Size = new Size(szeles, szeles);
                    pan.Location = new Point(sor, oszlop);
                    pan.BackColor = (szin) ? (Color.White) : (Color.Black);
                    szin = !szin;

                    oszlop += szeles;
                }
                szin = !szin;
                sor += szeles;
                oszlop = 12;
            }
        }

        private void tabla_meretez()
        {
            int szeles = (gamePANEL.Width - 24) / 8;
            int sor = 12;
            int oszlop = 12;
            int elemszam = 0;

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (gamePANEL.Controls.Count > 0)
                    {
                        gamePANEL.Controls[elemszam].Size = new Size(szeles, szeles);
                        gamePANEL.Controls[elemszam].Location = new Point(sor, oszlop);
                    }
                    oszlop += szeles;
                    elemszam++;
                }
                sor += szeles;
                oszlop = 12;
            }
        }

        private void tabla_torol()
        {
            gamePANEL.Controls.Clear();
        }

        private void alap_general()
        {
            global.meretez_alap(containerPANEL, this);

            int egyseg = containerPANEL.Width / 24;

            gamePANEL.Size = new Size(egyseg * 20, egyseg * 20);
            gamePANEL.Location = new Point(egyseg * 2, egyseg * 3);

            player1_PANEL.Size = new Size(egyseg * 6, egyseg * 2);
            player1_PANEL.Location = new Point(egyseg * 3, 0);
            
            player2_PANEL.Size = new Size(egyseg * 6, egyseg * 2);
            player2_PANEL.Location = new Point(egyseg * 16, 0);

            tabla_meretez();
        }
    }
}
