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
        public static Panel[,] jatekter = new Panel[8, 8];
        public static string fel = "fekete";
        public static PictureBox selected;

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
            babuk_general();
        }

        private void Jatekter_SizeChanged(object sender, EventArgs e)
        {
            alap_general();
            babu_meretez();
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
                    pan.Click += mozgat;
                    pan.Tag = $"{i};{j}";
                    szin = !szin;

                    sor += szeles;

                    jatekter[i, j] = pan;
                }
                szin = !szin;
                oszlop += szeles;
                sor = 12;
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
                        gamePANEL.Controls[elemszam].Location = new Point(oszlop, sor);
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

            tabla_meretez();
        }

        private void babuk_general()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if(jatekter[j, i].BackColor == Color.White)
                    {
                        PictureBox babupng = new PictureBox();
                        babupng.Name = "feher";
                        babupng.Image = babukIMAGELIST.Images[0];
                        babupng.Size = new Size(gamePANEL.Controls[0].Width - 10, gamePANEL.Controls[0].Width - 10);
                        babupng.Location = new Point(5, 5);
                        babupng.SizeMode = PictureBoxSizeMode.Zoom;
                        babupng.Tag = $"{i};{j}";
                        jatekter[i, j].Controls.Add(babupng);
                        babupng.Click += lepes_hely;
                    }
                }
            }

            for (int i = 5; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (jatekter[j, i].BackColor == Color.White)
                    {
                        PictureBox babupng = new PictureBox();
                        babupng.Name = "fekete";
                        babupng.Image = babukIMAGELIST.Images[2];
                        babupng.Size = new Size(gamePANEL.Controls[0].Width - 10, gamePANEL.Controls[0].Width - 10);
                        babupng.Location = new Point(5, 5);
                        babupng.SizeMode = PictureBoxSizeMode.Zoom;
                        babupng.Tag = $"{i};{j}";
                        jatekter[i, j].Controls.Add(babupng);
                        babupng.Click += lepes_hely;
                    }
                }
            }

            fel_valt();
        }

        private void babu_meretez()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (jatekter[i, j].Controls.Count > 0)
                    {
                        jatekter[i, j].Controls[0].Size = new Size(gamePANEL.Controls[0].Width - 10, gamePANEL.Controls[0].Width - 10);
                        jatekter[i, j].Controls[0].Location = new Point(5, 5);
                    }
                }
            }
        }

        private void lepes_hely(object sender, EventArgs e)
        {
            szin_torol();

            selected = sender as PictureBox;
            int ii = Convert.ToInt32(selected.Tag.ToString().Split(';')[0]);
            int jj = Convert.ToInt32(selected.Tag.ToString().Split(';')[1]);

            if (selected.Name.Contains("feher"))
            {
                if (selected.Name == "feher")
                {
                    hely_kijelol(ii, jj, 1, -1);
                    hely_kijelol(ii, jj, 1, 1);
                }
                else if (selected.Name == "feher_dama")
                {
                    hely_kijelol(ii, jj, 1, -1, true);
                    hely_kijelol(ii, jj, 1, 1, true);
                    hely_kijelol(ii, jj, -1, -1, true);
                    hely_kijelol(ii, jj, -1, 1, true);
                }
            }
            else
            {
                if (selected.Name == "fekete")
                {
                    hely_kijelol(ii, jj, -1, -1);
                    hely_kijelol(ii, jj, -1, 1);
                }
                else if (selected.Name == "fekete_dama")
                {
                    hely_kijelol(ii, jj, 1, -1, true);
                    hely_kijelol(ii, jj, 1, 1, true);
                    hely_kijelol(ii, jj, -1, -1, true);
                    hely_kijelol(ii, jj, -1, 1, true);
                }
            }
        }

        private void hely_kijelol(int ii, int jj, int irany_ii, int irany_jj, bool damae = false)
        {
            bool mehet = true;

            if (ii + irany_ii >= 0 && jj + irany_jj >= 0 && ii + irany_ii < 8 && jj + irany_jj < 8)
            {
                if (jatekter[ii + irany_ii, jj + irany_jj].Controls.Count == 0)
                {
                    jatekter[ii + irany_ii, jj + irany_jj].BackColor = Color.Yellow;
                }
                else if (jatekter[ii + irany_ii, jj + irany_jj].Controls.Count != 0 && jatekter[ii + irany_ii, jj + irany_jj].Enabled == false)
                {
                    if (ii + irany_ii * 2 >= 0 && jj + irany_jj * 2 >= 0 && ii + irany_ii * 2 < 8 && jj + irany_jj * 2 < 8)
                    {
                        if (jatekter[ii + irany_ii * 2, jj + irany_jj * 2].Controls.Count == 0)
                        {
                            jatekter[ii + irany_ii, jj + irany_jj].BackColor = Color.Pink;
                            jatekter[ii + irany_ii * 2, jj + irany_jj * 2].BackColor = Color.Red;
                            mehet = false;
                        }

                    }
                }

                if (damae && (jatekter[ii, jj].BackColor == Color.Yellow || jatekter[ii, jj].Enabled == true) && jatekter[ii + irany_ii, jj + irany_jj].Controls.Count == 0 && mehet)
                {
                    hely_kijelol((ii + irany_ii), (jj + irany_jj), irany_ii, irany_jj, true);
                }
            }
        }

        private void mozgat(object sender, EventArgs e)
        {
            Panel pan = sender as Panel;
            int sor = Convert.ToInt32(pan.Tag.ToString().Split(';')[0]);

            //Színezés
            if (pan.BackColor == Color.Yellow)
            {
                pan.Controls.Add(selected);
                selected.Tag = pan.Tag;
            }
            else if (pan.BackColor == Color.Red)
            {
                pan.Controls.Add(selected);
                selected.Tag = pan.Tag;
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (jatekter[i, j].BackColor == Color.Pink)
                        {
                            jatekter[i, j].Controls.Clear();
                            jatekter[i, j].Enabled = true;
                        }
                    }
                }
            }

            //Dáma létrehozása
            if (selected.Name.Contains("feher") && sor == 7)
            {
                selected.Image = babukIMAGELIST.Images[1];
                selected.Name = "feher_dama";
            }
            else if (selected.Name.Contains("fekete") && sor == 0)
            {
                selected.Image = babukIMAGELIST.Images[3];
                selected.Name = "fekete_dama";
            }

            //játékos váltás
            if (pan.BackColor != Color.White && pan.BackColor != Color.Black)
            {
                switch (fel)
                {
                    case "fekete": fel = "feher"; break;
                    case "feher": fel = "fekete"; break;

                    default: break;
                }

                szin_torol();
                fel_valt();
                babuszam_vizsgal();
            }
        }

        private void babuszam_vizsgal()
        {
            int db = 0;

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (jatekter[i, j].Controls.Count > 0)
                    {
                        if (jatekter[i, j].Controls[0].Name.Contains(fel))
                        {
                            db++;
                            //MessageBox.Show("alma");
                        }
                    }
                }
            }

            if (db == 0)
            {
                game_over();
            }
        }

        private void szin_torol()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (jatekter[i, j].BackColor != Color.Black && jatekter[i, j].BackColor != Color.White)
                    {
                        jatekter[i, j].BackColor = Color.White;
                    }
                }
            }
        }

        private void fel_valt()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (jatekter[i, j].Controls.Count > 0)
                    {
                        if (jatekter[i, j].Controls[0].Name.Contains(fel))
                        {
                            jatekter[i, j].Enabled = true;
                        }
                        else
                        {
                            jatekter[i, j].Enabled = false;
                            jatekter[i, j].BackColor = Color.LightSkyBlue;
                        }
                    }
                }
            }

            switch (fel)
            {
                case "fekete": kijelol(0); break;
                case "feher": kijelol(1); break;

                default: break;
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

        private void game_over()
        {
            string nev;

            if (fel == "feher")
            {
                nev = p1LBL.Text;
            }
            else
            {
                nev = p2LBL.Text;
            }

            MessageBox.Show($"Game Over\nNyertes: {nev}", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
            global.elore_hoz(global.menu);
        }

        private void Jatekter_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                p1LBL.Text = global.nevek[0];
                p2LBL.Text = global.nevek[1];

                fel_valt();
                fel = "fekete";

                tabla_general();
                babuk_general();
            }
        }

        private void gamePANEL_Click(object sender, EventArgs e)
        {
            //game_over();
        }
    }
}
