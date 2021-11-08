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
        static Panel[,] jatekter = new Panel[8, 8];
        static Panel[,] babuk = new Panel[8, 8];

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

                    jatekter[i, j] = pan;
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

            player1_PANEL.Size = new Size(egyseg * 8, egyseg * 2);
            player1_PANEL.Location = new Point(egyseg * 3, 0);
            
            player2_PANEL.Size = new Size(egyseg * 8, egyseg * 2);
            player2_PANEL.Location = new Point(egyseg * 13, 0);

            p1LBL.Size = new Size(player1_PANEL.Width - 8, player1_PANEL.Height - 8);
            p1LBL.Location = new Point(4, 4);
            p1LBL.Font = new Font("Arial", p1LBL.Height / 2);
            p1LBL.BorderStyle = BorderStyle.FixedSingle;

            p2LBL.Size = new Size(player2_PANEL.Width - 8, player2_PANEL.Height - 8);
            p2LBL.Location = new Point(4, 4);
            p2LBL.Font = new Font("Arial", p2LBL.Height / 2);
            p2LBL.BorderStyle = BorderStyle.FixedSingle;

            kijelol(0);
            tabla_meretez();
        }

        private void babuk_general()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {

                }
            }
        }

        private void kijelol(int index)
        {
            Panel[] panelek = new Panel[2] { player1_PANEL, player2_PANEL };
            Label[] labelek = new Label[2] { p1LBL, p2LBL };
            for (int i = 0; i < panelek.Length; i++)
            {
                if (i == index)
                {
                    panelek[i].BackColor = Color.FromArgb(0, 100, 0);
                    labelek[i].BorderStyle = BorderStyle.FixedSingle;
                }
                else
                {
                    labelek[i].BorderStyle = BorderStyle.None;
                    if (i == 0)
                    {
                        panelek[i].BackColor = Color.Black;
                    }
                    else
                    {
                        panelek[i].BackColor = Color.White;
                    }
                }
            }
        }

        private void Jatekter_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                p1LBL.Text = global.nevek[0];
                p2LBL.Text = global.nevek[1];
            }
        }
    }
}
